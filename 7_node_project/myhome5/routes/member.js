var express = require('express');
var router = express.Router();
var commonDB = require("./commonDB");

/* GET home page. */

// /member/signin
router.get('/signin', function(req, res, next) {
  res.render('member/signin'); // member/signin.ejs 
});

router.get('/login', function(req, res, next) {
    res.render('member/login'); // member/login.ejs 
});

router.get('/signout', function(req, res, next) {
    res.render('member/signout'); // member/signout.ejs 
});

router.use('/idcheck', async function(req, res, next) {
    //디비하고 데이터 주고받고 데이터를 json형태로 전달해야 한다 
    //클라이언트가 보낸 정보를 받는다 
    //get:query, params post:body 
    let userid = req.body.userid;

    let sql =  `select count(*) cnt from tb_member where userid=?`;
    let result = await commonDB.loadDB(sql, [userid]);
    console.log( result[0]["cnt"]);
    if( result[0]["cnt"]=="0")
      res.send({"result":"success"});
    else 
      res.send({"result":"fail"});
});

router.use('/save', async function(req, res, next) {
  
  let userid = req.body.userid;
  let password = req.body.password;
  let username = req.body.username;
  let phone = req.body.phone;
  let email = req.body.email;

  let sql =  `insert into tb_member(userid, password, username, email, phone, wdate)
    values(?, ?, ?, ?, ? , now())
`;

  await commonDB.saveDB(sql, [userid, password, username, email, phone]);
  res.send({"result":"success"});
  
});

/* 
세션 - 서버에 사용자 정보를 저장하는 특별한 객체이다.
각 클라이언트가 접속해오면 클라이언트마다 자동으로 만들어진다.
로그온 정보나 장바구니 정보등을 저장하기 위해 사용한다.
지나치게 많은 정보는 저장을 못한다. 디비랑 같이 사용한다.

쿠키 - 로컬에 저장된다. 예전에는 로그온한 아이디 등의 정보를 저장하기도 했으나
그냥 텍스트파일에 가까워서 보안이 너무 취약하고 서버측에서 
백도어 바이러스 등을 심기도 해서 사용을 거의 하지 않다가 최근에
백앤드-프론트앤드 개발등에 토큰을 저장하기 위한 용도로 다시 많이 사용된다.

npm install express-session
npm install express-mysql-session

*/


router.use('/logon', async function(req, res, next) {
  let userid = req.body.userid;
  let password = req.body.password;

  let sql =  `insert username, email, phone from tb_member where userid=?`
  let result = await commonDB.loadDB(sql, [userid]);

  if(result.length>0) //아이디가 없을 경우에
  {
    res.send({"result":"fail", "msg":"해당하는 아이디가 없습니다"});
    return;
  }
  
  if(result[0]["password"] !=password)
  {
    res.send({"result":"fail", "msg":"패스워드가 일치하지 않습니다"});
    return;
  }

  // 세션에 저장한다.
    req.session["userid"]=userid;
    req.session["username"]=username;
    req.session["email"]=email;

    req.session.save(()=>{
      // 세션에 정보들이 제대로 저장되면 호출된다.
      console.log("사용자 아이디: ", req.session.userid);
      console.log("사용자 이름: ", req.session.username);
      console.log("이메일: ", req.session.email);
      res.send({"result":"success"});
    });
    req.session.save();

module.exports = router;
