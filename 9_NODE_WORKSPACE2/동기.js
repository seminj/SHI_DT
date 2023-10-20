// 동기.js
/* 함수가 일을 시작해서 마칠때까지 대기를 한다.*/
let fs = require("fs");
// nodesjs가 제공하는 파일관련 라이브러리
// readFileSync - 동기함수라 함수가 종료할 때 읽은 파일의 내용을 반환한다.

let txt = fs.readFileSync("test.txt", "utf-8");
console.log(txt);
console.log("완료");

