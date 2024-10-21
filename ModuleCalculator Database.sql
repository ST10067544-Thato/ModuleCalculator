CREATE DATABASE ModuleCalculatorDB;

USE ModuleCalculatorDB;

-- Create the users table
CREATE TABLE Users 
(
    UserID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARBINARY(MAX) NOT NULL --saved as a hash
);

--Select * FROM USERS;

--drop table Users;

CREATE TABLE Modules
(
	ModuleID INT PRIMARY KEY IDENTITY(1,1),
	UserID INT NOT NULL,
	ModuleName VARCHAR(150) NOT NULL,
	ModuleCode VARCHAR(10) NOT NULL,
	ModuleCredits INT NOT NULL,
	ClassHours INT NOT NULL,
	SemesterStartDate DATE NOT NULL,
	SemesterWeeks INT NOT NULL,
	SelfStudyHours INT NOT NULL,
	UNIQUE (UserID, ModuleCode), -- Unique constraint on UserID and ModuleCode so that 1 user can only register for a module code once.
	FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

--Select * FROM Modules;

--drop table Modules;