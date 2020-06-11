use master
go
create database mvvm
-------------
use mvvm
go
create table Consultation
(
ID int primary key identity(1, 1),
FIO varchar(60),
Subject varchar(30),
Startime datetime,
Endtime datetime,
IsRecorded tinyint
)
alter table Consultation
add  Date date
go
insert into Consultation(FIO, Subject, Startime, Endtime,IsRecorded, Date)
values ('Короленя Р.О.', 'КГИГ', '2020-06-11 15:30:00', '2020-06-11 16:30:00', 1, '2020-06-11')
delete Consultation where FIO like 'Короленя Р.О.'