--DROP TABLE Trainees
--DROP TABLE Trainers
--DROP TABLE Academy


--CREATE TABLE Academy
--(
--	Academy_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL
--	,Location VARCHAR (20)
--)
--CREATE TABLE Trainers
--(
--	Trainer_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL
--	,First_Name VARCHAR (15)
--	,Age VARCHAR (2)
--	,Course VARCHAR (15)
--	,Academy_ID INT 
--	,FOREIGN KEY (Academy_ID) REFERENCES Academy(Academy_ID)
--)

--CREATE TABLE Trainees
--(
--	Trainee_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL
--	,First_Name VARCHAR (15)
--	,Last_Name VARCHAR (15)
--	,Age VARCHAR (2)
--	,Course VARCHAR (15)
--	,Trainer_ID INT 
--	,FOREIGN KEY (Trainer_ID) REFERENCES Trainers(Trainer_ID)
--	,Academy_ID INT 
--	,FOREIGN KEY (Academy_ID) REFERENCES Academy(Academy_ID)
--)

SELECT * FROM Academy
SELECT * FROM Trainers
SELECT * FROM Trainees
