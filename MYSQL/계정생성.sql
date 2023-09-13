
/*
MySQL - DBMS :DataBase Management System :디비를 관리하는 프로그램 
 
*/
-- 1. 데이터베이스를 먼저 만든다. 
CREATE DATABASE mydb DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;

-- 2.mysql 계정생성하기 
-- 'user01'@'localhost'   : localhost 디비서버랑 웹서버랑 동일 컴퓨터에 있어야 한다. 
-- 외부로 부터 접근이 가능하게 하려면 % 를 사용해야 한다. user01'@'%'  웹서버하고 디비 서버를 분리시킬 수 있다 
-- 내부 create user 'user01'@'localhost' identified by '1234';
-- 외부 create user 'user01'@'%' identified by '1234';

create user 'user01'@'localhost' identified by '1234';

-- 3. 디비 따로 계정 따로 root 계정이 사용자 계정한테 디비에 대한 권한을 주자 
grant all privileges on mydb.* to 'user01'@'localhost';

flush privileges;  -- 여기까지 해야 적용된다. 


-- 콘솔상에서 mysql 을 작동시킬 수 있다. 

-- mysql 설치 위치가 C:\Program Files\MySQL\MySQL Server 8.0\bin
-- 시작 - cmd - mysql 
-- mysql  명령어를 어떤 폴더에 있던 사용이 가능하게 하고 싶다. 
-- os의 환경변수에 등록과정을 거쳐야 한다 
-- 내PC - 마우스 오른쪽 - 속성 - 고급시스템 설정 - 환경변수  
-- 시스템 선택 후  path 수정[편집]  누르고  새로만들기 에 위 경로를 붙인다. 
-- C:\Program Files\MySQL\MySQL Server 8.0\bin



-- 패스워드 수정 : 루트계정에서 user01의 패스워드를 변경한다. 
alter user 'user01'@'localhost' identified by '1234';






