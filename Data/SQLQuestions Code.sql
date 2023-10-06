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

DELETE FROM Question



INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('Who won the NBA title in 2012','Miami Heat','Los Angeles Lakers','Houston Rockets','Cleveland Cavaliers')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('Which planet is closest to the sun','Mercury','Jupiter','Earth','Saturn')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('What nut is in the middle of a Ferrero Rocher','Hazelnut','Peanut','Almond','Cashew')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('What three colours make up the flag of Lithuania?','Yellow, green, red','Yellow, red, blue','Blue, red, green','Red and green')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('Who painted the Mona Lisa','Leonardo da Vinci','Vincent van Gogh','Johannes Vermeer','Pablo Picasso')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('Who plays Delboy Trotter in Only Fools And Horses','David Jason','Buster Merryfield','John Challis','Nicholas Lyndhurst')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('What is the capital of Iceland','Reykjavík','Hafnarfjörður','Kópavogur','Akóravane')


 INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
 VALUES('','','','','')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('How many time zones are there in Russia','11','10','3','21')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('What is the slang name for New York City, used by locals','Gotham','The Big Apple','York','Marw')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('Which football team is known as ‘The Red Devils’','Manchester United','Arsenal','Real Madrid','Bayern Munich')

INSERT INTO Question(Question_Text,Correct_Answer,Incorrect_Answer1,Incorrect_Answer2,Incorrect_Answer3)
VALUES('What is the speed of sound','1234,82km/h','151,11km/h','3,14km/h','420,00km/h')

SELECT *
FROM Question


