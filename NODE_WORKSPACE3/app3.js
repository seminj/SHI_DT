/* 
1. html 파일과 어떻게 결홥할지
npm install ejs
*/
let express = require('express');
let app  = new express();

app.set('view engine', 'ejs'); //ejs 엔진 설정하기

//포스트방식으로 데이터 처리는 bodyparser 라는 미들웨어를 사용하다가 4 버전부터는 내장형으로 바뀐다. 
//모든 요청들이 이 미들웨어를 거쳐 가면서  req  객체에 body 라는 요소를 추가한다. 
app.use(express.json());
app.use(express.urlencoded({extended:true}));

app.get("/", (req, res)=>{

    //express에서 res객체 함수를 추가했음 render 임, http모듈에서는 파일읽어서 렌더링해서 end 함수로 보냄
    res.render("index", {"title":"Express"});
    // 파일명, 보낼데이터
    //express 에서 html 파일은 views 라는 폴더에 저장해야 하고
    //ejs엔진을 사용할 경우에 확장자는 ejs 이다.
    //views 폴더를 만들고 그 폴더 아래에 index.ejs 파일을 만든다.
});

app.get("/add", (req,res)=>{
    res.render("add");
});

//결과처리 라우터 만들기


app.use((req, res)=>{
     res.writeHead(404, {'Content-Type':'text/html;charset=utf-8'});
    res.end('<h1>존재하지 않는 페이지입니다.</h1>');
});

app.listen(4000, ()=>{
    console.log("Server start at http://127.0.0.1:4000");
});

