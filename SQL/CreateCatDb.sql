use master

drop database if exists CatDB
go

create database CatDB
go

use CatDB
go 


drop table if exists Cats
go
drop table if exists Breeds
go

create table Cats (
CatID int not null identity primary key,
CatName nvarchar(50),
Age int ,
Description nvarchar(50)
)
create table Breeds (
BreedID int not null identity primary key,
BreedName nvarchar(50)
)

Insert into Cats values('Ozzie',15,'Mainecoon')
Insert into Cats values('Lucy',3,'Sphinx')
Insert into Cats values('Jasper',1,'Black & White')




insert into Breeds values ('Mainecoon')
insert into Breeds values ('Tabby')
insert into Breeds values ('Sphinx')

select * from Cats
select * from Breeds