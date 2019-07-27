-- テーブル構成
create table enemy(
`id` int auto_increment primary key,
`name` varchar(64) not null,
`isBoss` tinyint(1),
`Hp` int not null,
`Mp` int null,
`Atk` int null,
`Def` int null,
`Int` int null,
`Mnd` int null,
`Spd` int null,
`Lvl` int null,
`Exp` int null);
-- テストデータ
insert into enemy (
`name`,
`isBoss`,
`Hp`,
`Mp`,
`Atk`,
`Def`,
`Int`,
`Mnd`,
`Spd`,
`Lvl`,
`Exp`)
values (
 'Ryuoh',
 1,
 3000,
 3000,
 500,
 500,
 300,
 300,
 450,
 99,
 10000 );
