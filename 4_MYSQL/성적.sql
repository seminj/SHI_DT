create table tb_score(
   id bigint primary key auto_increment,  -- primary key, 자동증가
   name varchar(40),  
   kor int,
   eng int,
   mat int,
   wdate datetime 
);

insert into tb_score(name, kor, eng, mat, wdate) value('홍길동', 90, 80, 100, now());
insert into tb_score(name, kor, eng, mat, wdate) value('임꺽정', 100, 80, 100, now());
insert into tb_score(name, kor, eng, mat, wdate) value('장길산', 90, 80, 80, now());
insert into tb_score(name, kor, eng, mat, wdate) value('김정하', 100, 100, 100, now());
insert into tb_score(name, kor, eng, mat, wdate) value('이정미', 70, 80, 100, now());

select * from tb_score;