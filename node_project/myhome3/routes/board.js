var express = require('express');
var router = express.Router();
let db = require('./commonDB');

/* GET home page. */
// board/list -> 이 url을 처리 안하고 있다.
// board => board/list/1로 전환한다.
router.get('/', function(req, res, next) {
    res.redirect("/board/list/1")
  });


//  http://127.0.0.1:3000/board/list/1#
router.get('/list/:pg', async function(req, res, next) {
    let pg = parseInt(req.params.pg) ?? 1;
    console.log(pg); // 확인용
    let start = (pg-1)*10; // 글 시작위치

    let sql;
    sql = 
        `
            select id, title, writer ,contents, date_format(wdate, '%Y-%m-%d') wdate, hit 
            from tb_board
            order by id desc
            limit ?, 10
        `;
    // limit (?-1)*10, 10   : 원하는만큼만 데이터를 가져온다. 한 페이지당 10개를 가져온다.
    // limit 시작위치(offset), 개수
    // (pg-1)*10 ~ 10개만 
    
    let boardList = await db.loadDB(sql, [start]);
    res.render("board/board_list", {boardList:boardList});

  });

router.get('/write', function(req, res, next) {
    res.render("board/board_write")
  });

  router.post('/save', async function(req, res, next) {
    let title = req.body.title;
    let writer = req.body.writer;
    let contents = req.body.contents;

    let sql = 
                `
                    insert into tb_board(title, writer, contents, wdate, hit)
                    values(?,?,?,now(),0)
                `;

    await db.saveDB(sql,[title, writer, contents]);

    //res.redirect("/board/list/1")
    // ajax 통신시 json 데이터 전송
    res.send({result:"success"});
  });

router.get('/view/:id', async function(req, res, next) {
    let id = req.params.id;
    let sql = `update tb_board set hit = hit+1 where id=?`;
    await db.saveDB(sql,[id]);

    sql = `
            select id, title, writer ,contents, date_format(wdate, '%Y-%m-%d') wdate, hit 
            from tb_board
            where id = ?
        `;
    let board = await db.loadDB(sql,[id]); 
    // 반환값이 배열형태이다. 첫번째것만 보내야 한다
    console.log(board);
    res.render("board/board_view", {board:board});
  });


  module.exports = router;