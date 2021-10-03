

use timtest;

drop table if exists API_DB_Connection_Demo_Table;

go
create table API_DB_Connection_Demo_Table(
    did int primary key,
    data1 NVARCHAR(100),
    data2 NVARCHAR(100)
)
go

insert into API_DB_Connection_Demo_Table(did, data1,data2) VALUES
(1, 'something one', 'something else one'),
(2, 'something two', 'something else two'),
(3, 'something three', 'something else three'),
(4, 'something four', 'something else four');


select * from API_DB_Connection_Demo_Table;