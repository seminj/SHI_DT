var express = require('express');
var router = express.Router();

router.get("/", (req, res)=>{
    //views/test2.ejs 파일이 있어야 연결 가능.
    res.render("test2", {name:"홍길동", age:23, phone:"010-0000-0001" });
});

router.get("/add", (req, res)=>{

    let x = parseInt(req.query.x);
    let y = parseInt(req.query.y);
    res.render("test2", {x:x, y:y, result:x+y});
});

module.exports = router;