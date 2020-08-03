use master

drop database if exists CatDB
go

create database CatDB
go

use CatDB
go 

drop table Cats
go

create table Cats (
CatID int not null identity primary key,
CatName nvarchar(50),
Age int ,
Description nvarchar(50)
)

Insert into Cats values('Ozzie',15,'Mainecoon')
Insert into Cats values('Lucy',3,'Sphinx')
Insert into Cats values('Jasper',1,'Black & White')

select * from Cats