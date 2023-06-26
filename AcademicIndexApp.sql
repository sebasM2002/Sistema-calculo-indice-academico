create database academic_index_app;
use academic_index_app;

CREATE TABLE `building` (
  `BuildingID` char(3) NOT NULL,
  `BuildingName` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  PRIMARY KEY (`BuildingID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `career` (
  `ID_Career` char(3) NOT NULL,
  `Career` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Career`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `course` (
  `CourseID` varchar(7) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `CourseName` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Credits` int DEFAULT NULL,
  PRIMARY KEY (`CourseID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `PreRequisite` (
  `CourseID` varchar(7) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `PreRequisiteID` varchar(7) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`CourseID`, `PreRequisiteID`),
  FOREIGN KEY (`CourseID`) REFERENCES `course` (`CourseID`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `CoRequisite` (
  `CourseID` varchar(7) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `CoRequisiteID` varchar(7) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`CourseID`, `CoRequisiteID`),
  FOREIGN KEY (`CourseID`) REFERENCES `course` (`CourseID`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `inqueries` (
  `InqueryID` varchar(10) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `InqueryType` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Description` varchar(500) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`InqueryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `permisions` (
  `PermID` int NOT NULL,
  `PermDescription` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`PermID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `section` (
  `SectionID` int NOT NULL,
  `Section` varchar(4) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  PRIMARY KEY (`SectionID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `trimester` (
  `TrimesterID` int NOT NULL,
  `Name` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`TrimesterID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `userroles` (
  `RoleID` int NOT NULL,
  `RoleDescription` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`RoleID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `HashAlgorithm` (
  `HashAlgorithmID` int NOT NULL,
  `AlgorithmDescription` nvarchar(10) NOT NULL,
  PRIMARY KEY (`HashAlgorithmID`)
);

CREATE TABLE `useraccounts` (
  `UserID` int NOT NULL,
  `FirstName` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `DateOfBirth` date NOT NULL,
  `EMailAddress` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Image` blob,
  `Age` int NOT NULL,
  `GPA` decimal(3,2) DEFAULT NULL,
  `NumTrimesters` int DEFAULT NULL,
  `Gender` char(1) NOT NULL,
  `AcademicArea` varchar(60) NOT NULL,
  `Identification` varchar(16) NOT NULL,
  `AddressLine` varchar(200) NOT NULL,
  `LastName` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `RoleID` int NOT NULL,
  PRIMARY KEY (`UserID`,`RoleID`),
  KEY `RoleID` (`RoleID`),
  CONSTRAINT `useraccounts_ibfk_1` FOREIGN KEY (`RoleID`) REFERENCES `userroles` (`RoleID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `role_permisions` (
  `RoleID` int NOT NULL,
  `PermID` int NOT NULL,
  PRIMARY KEY (`RoleID`,`PermID`),
  KEY `PermID` (`PermID`),
  CONSTRAINT `role_permisions_ibfk_1` FOREIGN KEY (`RoleID`) REFERENCES `userroles` (`RoleID`),
  CONSTRAINT `role_permisions_ibfk_2` FOREIGN KEY (`PermID`) REFERENCES `permisions` (`PermID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `room` (
  `RoomID` varchar(8) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `BuildingID` char(3) DEFAULT NULL,
  PRIMARY KEY (`RoomID`),
  KEY `BuildingID` (`BuildingID`),
  CONSTRAINT `room_ibfk_1` FOREIGN KEY (`BuildingID`) REFERENCES `building` (`BuildingID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `userinqueries` (
  `UserID` int NOT NULL,
  `InqueryID` varchar(10) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`UserID`,`InqueryID`),
  KEY `InqueryID` (`InqueryID`),
  CONSTRAINT `userinqueries_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `useraccounts` (`UserID`),
  CONSTRAINT `userinqueries_ibfk_2` FOREIGN KEY (`InqueryID`) REFERENCES `inqueries` (`InqueryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `userdatalogin` (
  `UserID` int NOT NULL,
  `PasswordHash` varchar(250) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `PasswordSalt` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `EMailAddress` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `HashAlgorithmID` int NOT NULL,
  `PassRecoveryToken` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `RecoveryTokenTime` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  KEY `HashAlgorithmID` (`HashAlgorithmID`),
  CONSTRAINT `userdatalogin_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `useraccounts` (`UserID`),
  CONSTRAINT `userdatalogin_ibfk_2` FOREIGN KEY (`HashAlgorithmID`) REFERENCES `hashalgorithm` (`HashAlgorithmID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Course_Section_Room` (
  `CourseID` nvarchar(7) NOT NULL,
  `SectionID` int NOT NULL,
  `RoomID` nvarchar(8) NOT NULL,
  `TrimesterID` int NOT NULL,
  `Year` date NOT NULL,
  `Day` nvarchar(12) NOT NULL,
  `StartTime` time NOT NULL,
  `EndTime` time NOT NULL,
  `NumStudents` int NOT NULL,
  `TeacherFirstName` nvarchar(100) NOT NULL,
  `TeacherLastName` nvarchar(100) NOT NULL,
  PRIMARY KEY (`CourseID`, `SectionID`, `RoomID`, `TrimesterID`, `Year`, `Day`),
  FOREIGN KEY (`CourseID`) REFERENCES `course` (`CourseID`),
  FOREIGN KEY (`SectionID`) REFERENCES `section` (`SectionID`),
  FOREIGN KEY (`RoomID`) REFERENCES `room` (`RoomID`),
  FOREIGN KEY (`TrimesterID`) REFERENCES `trimester` (`TrimesterID`)
);

CREATE TABLE `CourseReport` (
  `UserID` int NOT NULL,
  `CourseID` nvarchar(7) NOT NULL,
  `Section` int NOT NULL,
  `TrimesterID` int NOT NULL,
  `Year` date NOT NULL,
  `Grade` decimal (3,1) NOT NULL,
  `Letter` char(3) NOT NULL,
  PRIMARY KEY (`UserID`, `CourseID`, `TrimesterID`, `Year`),
  FOREIGN KEY (`UserID`) REFERENCES `useraccounts` (`UserID`),
  FOREIGN KEY (`CourseID`) REFERENCES `course` (`CourseID`),
  FOREIGN KEY (`TrimesterID`) REFERENCES `trimester` (`TrimesterID`)
);

CREATE TABLE `UserCareer` (
  `ID_Career` char(3) NOT NULL,
  `UserID` int NOT NULL,
  PRIMARY KEY (`ID_Career`, `UserID`),
  FOREIGN KEY (`UserID`) REFERENCES `useraccounts` (`UserID`),
  FOREIGN KEY (`ID_Career`) REFERENCES `career` (`ID_Career`)
);

CREATE TABLE `TeacherCourse` (
  `CourseID` nvarchar(7) NOT NULL,
  `UserID` int NOT NULL,
  PRIMARY KEY (`CourseID`, `UserID`),
  FOREIGN KEY (`UserID`) REFERENCES `useraccounts` (`UserID`),
  FOREIGN KEY (`CourseID`) REFERENCES `course` (`CourseID`)
);

