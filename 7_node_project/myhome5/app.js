var createError = require('http-errors');
var express = require('express');
var path = require('path');
var cookieParser = require('cookie-parser');
var logger = require('morgan');

var config = require('./rotues/config');

// 세션을 사용하기 위해서
var session = require("express-session");
var mysql = require("mysql2");
var mysqlstore = require("express-mysql-session")(session);


var indexRouter = require('./routes/index');
var usersRouter = require('./routes/users');
var memberRouter = require('./routes/member');


var app = express();

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs');

//세션을 처리하는 미들웨서
var options = {
  connectionLimit:10,    
  host:config.DBINFO.host,
  user:config.DBINFO.user,
  password:config.DBINFO.password,  
  database:config.DBINFO.database     
};
var sessionStore = new mysqlstore(options);
app.use(session({
    key:"ewiodsndsnkl", // 대충 아무거나 길고 복잡하게 넣는다. 세션을 암호화할때 사용한다
    secret:"session_cookie_secret",
    store:sessionStore,
    resave:false,
    saveUninitialized:false
  }
));

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

app.use('/', indexRouter);
app.use('/users', usersRouter);
app.use('/member', memberRouter);


// catch 404 and forward to error handler
app.use(function(req, res, next) {
  next(createError(404));
});

// error handler
app.use(function(err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  res.render('error');
});

module.exports = app;
