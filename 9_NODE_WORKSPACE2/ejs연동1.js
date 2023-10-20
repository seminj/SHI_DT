let http = require("http");
let url = require("url");
let fs = require("fs");
let ejs = require("ejs");

let route = require("./route1");

let server = http.createServer( (req, res)=>{

    if(req.method=="GET") //브라우저에서 보낼 수 있음 
    {
        let pathName = url.parse(req.url).pathname;
        if(pathName == '/test1'){
            route.test1(req, res);
        }        
        else if(pathName == '/test2'){
            route.test2(req, res);
        }
        else{
            res.writeHead(200, {"Content-Type":"text/html; charset=utf-8"});
            res.end("<h1>My Home</h1>");
        }
    }
    else {
        res.writeHead(200, {"Content-Type":"text/html; charset=utf-8"});
        res.end("<h1>POST방식 처리</h1>"); //postman
    }
});
//createServer 도 비동기 함수이다. 반환값은 완성된 서버에 대한 참조이다 

server.listen( 4000, ()=>{
    console.log( "server start http://127.0.0.1:4000");
});