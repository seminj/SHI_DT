// 공통으로 사용할 디비정보 config.js
const DBINFO={
    host:'localhost',      //디비 ip 
    user:'ProjectDB',         //디비 계정
    password:'0000',       //디비 계정 패스워드  
    database:'project',       //디비명     
    port:3306              //포트번호 
};

exports.DBINFO = DBINFO; // 외부로 노출시켜야 다른 파일에서 사용이 가능하다