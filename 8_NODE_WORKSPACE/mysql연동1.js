//mysql연동1.js

//npm install mysql 
let mysql = require('mysql');

//1.mysql  연결정보기반으로 객체 생성  
let pool = mysql.createPool({
    connectionLimit:10,    //연결이 안될경우 10초간 기다려봄 10초 넘으면 예외발생
    host:'localhost',      //디비 ip 
    user:'user01',         //디비 계정
    password:'1234',       //디비 계정 패스워드  
    database:'mydb',       //디비명     
    port:3306              //포트번호 
});

//2. 디비 접속하기
pool.getConnection( (err, conn)=>{
    //err-디비 접속시 오류 발생시 
    //conn - 디비와의 연결 객체 
    if( err)
    {
        console.log(err);
        return;
    }

    let sql = `insert into tb_score (name, kor, eng, mat, wdate) 
                values('새학생', 70, 70, 70, now()) `;

    conn.query(sql, (err, rows)=>{
        //err = 쿼리 실행 오류 발생시  
        //rows - 쿼리 실행후 결과를 가져온다 
        if( err)
        {
            console.log(err);
            return;
        }
        console.log("inserted");
        
        conn.release(); //연결닫기 
    })
});

//node  mysql연동1.js 

/*
1.  연결하고 
let conn = pool.getConnection();
...
2. sql="....."
let result = conn.querY("...........")

3.출력이나 나머지 처리 

pool.getConnection( ()=>{
     쿼리실행 ( ()=>{
         쿼리실행 ( ()=>{
             쿼리실행 ( ()=>{
            })
        })   
     })
})
*/


