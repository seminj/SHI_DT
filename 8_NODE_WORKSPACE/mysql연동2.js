//터미널에서 npm install mysql 설치하기

let mysql = require('mysql');

//1. mysql 연결 정보 기반으로 객체 생성
let pool = mysql.createPool({
    connectionLimit:10,   //연결이 안 될 경우, 10초 간 기다렸다가 10초가 넘으면 예외발생
    host:'localhost',     //db ip
    user:'user01',        //db 계정
    password:'1234',      //db 계정 패스워드
    database:'mydb',      //db명
    port:3306             //포트번호
});

//2. db에 접속하기
pool.getConnection( (err, conn)=>{
    //err : db 접속 시 오류 발생할 때
    //conn : db와의 연결 객체
    if(err)
    {
        console.log(err);
        return;
    }
    
    //쿼리구문 적용 구간   //연결 후에는 "" -> ``
    let sql = ` insert into tb_score (name, kor, eng, mat, wdate) 
                values('새학생', 70, 70, 70, now()) `;

    conn.query(sql, (err, rows)=>{
        //err : 쿼리 실행오류 발생할 때
        //rows : 쿼리 실행 후 결과를 가져옴
        if(err)
        {
            console.log(err);
            return;
        }
        console.log("inserted");
        conn.release();   //연결닫기
    });
});

/*
1. 연결하고
let conn = pool.getConnection();
...
2. sql="....."
let result = conn.query("......")

3.출력이나 나머지 처리
pool.getConnection( ()=>{
    쿼리실행 ( ()=>{
        쿼리실행 ( ()=>{
            쿼리실행 ( ()=>{

            }
        }
    })
})
*/