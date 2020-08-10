--use master

--drop database if exists ComicDB
--go

--create database ComicDB
--go

--use ComicDB
--go 


--drop table if exists Heroes
--go
--drop table if exists Teams
--go
--drop table if exists Villains
--go

--create table Teams(
--TeamID int not null identity primary key,
--TeamName nvarchar(50)
--)

--create table Heroes (
--HeroID int not null identity primary key,
--Alias nvarchar(50),
--RealName nvarchar(50) ,
--TeamID int FOREIGN KEY REFERENCES Teams(TeamID),
--VillainTeamID int FOREIGN KEY REFERENCES Teams(TeamID)
--)

--create table Villains (
--VillainID int not null identity primary key,
--Alias nvarchar(50),
--RealName nvarchar(50) ,
--TeamID int FOREIGN KEY REFERENCES Teams(TeamID),
--HeroTeamID int FOREIGN KEY REFERENCES Teams(TeamID),
--HeroID int Foreign Key REferences Heroes(HeroID)
--)
--Insert into Teams values('X-men')
--Insert into Teams values('Avengers')
--Insert into Teams values('Justice League')
--Insert into Teams values('Brotherhood of Mutants')
--Insert into Teams values('AIM')
--Insert into Teams values('Legion of Doom')


--Insert into Heroes values('Wolverine','James "Logan" Howlett',1,4)
--Insert into Heroes values('Cyclops','Scott Summers',1,4)
Insert into Heroes values('Iron Man','Tony Stark',2,4)
Insert into Heroes values('Wonder Woman','Diana Prince',3,5)
Insert into Heroes values('Professor X','Charles Xaiver',1,4)




insert into Villains values('Magneto','Max Eisenhardt',4,1,5)
insert into Villains values('Iron Monger','Obadiah Stane',5,2,3)
insert into Villains values('Ares','Ares',3,3,4)

select * from Heroes
select * from Villains
select * from Teams