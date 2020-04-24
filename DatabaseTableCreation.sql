CREATE TABLE ajjMeetings (
	meetingID INT AUTO_INCREMENT NOT NULL,
	date DATE NOT NULL,
	title VARCHAR(50) NOT NULL,
	location VARCHAR(50) NOT NULL,
	startTime VARCHAR(20) NOT NULL, 
	endTime VARCHAR(20) NOT NULL,
	attendees VARCHAR(255) NOT NULL,
	description VARCHAR(255) DEFAULT NULL,
	PRIMARY KEY (meetingID)
) ;

CREATE TABLE ajjUsers (
	userID INT AUTO_INCREMENT NOT NULL,
	fullName VARCHAR(50) NOT NULL,
	username VARCHAR(50),
	rank INT(50) NOT NULL,
	PRIMARY KEY (userID)
) ;



