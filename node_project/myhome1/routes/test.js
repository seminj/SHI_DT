var express = require('express');
var router = express.Router();

/* GET home page */
//app.use("/test",testRouter);
// /test로 시작하는 모든 url은 이 라우터가 처리한다.
//http://127.0.0.1:3000/test
router.get('/', function(req,res,netx){
    //html 문서, 정보
    res.render('test1',{title:'this is test'});

});
module.exports = router;