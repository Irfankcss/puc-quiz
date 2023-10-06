CREATE DATABASE Puc_Quiz_Questions
GO
USE Puc_Quiz_Questions

CREATE TABLE Question
(
	QuestionID INT CONSTRAINT PK_Questions PRIMARY KEY IDENTITY(1,1),
	Question_Text TEXT NOT NULL,
	Correct_Answer NVARCHAR(100) NOT NULL,
	Incorrect_Answer1 NVARCHAR(100) NOT NULL,
	Incorrect_Answer2 NVARCHAR(100) NOT NULL,
	Incorrect_Answer3 NVARCHAR(100) NOT NULL
)

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('TestQ','TestC','TestI1','TestI2','TestI3')

SELECT *
FROM Question

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('Who won the NBA title in 2012','Miami Heat','Los Angeles Lakers','Houston Rockets','Cleveland Cavaliers')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('Which planet is closest to the sun','Mercury','Jupiter','Earth','Saturn')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('What nut is in the middle of a Ferrero Rocher','Hazelnut','Peanut','Almond','Cashew')