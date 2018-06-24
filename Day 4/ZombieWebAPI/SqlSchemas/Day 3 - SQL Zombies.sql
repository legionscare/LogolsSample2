/* Drop existing zombietime DB and create DB */

DROP DATABASE zombietime;

CREATE DATABASE zombietime;
USE zombietime;

/* Create schemas */

CREATE TABLE Person (
	PersonId int NOT NULL AUTO_INCREMENT,
    FirstName varchar(20),
    LastName varchar(20),
    PersonStatusId int,
    PRIMARY KEY (PersonId)
);

CREATE TABLE PersonStatus (
	PersonStatusId int NOT NULL,
    StatusDescription varchar(20),
    PRIMARY KEY (PersonStatusId)
);

/* Insert data sets into database */

INSERT INTO PersonStatus ( PersonStatusId, StatusDescription ) VALUES 
	( 1, 'Alive' ), 
    ( 2, 'Zombie' ), 
    ( 3, 'Dead' ), 
    ( 4, 'Unknown' ),
    ( 5, 'Omnipotent' );

INSERT INTO Person ( FirstName, LastName, PersonStatusId ) VALUES 
	( 'Billy', 'Ray', 3 ), 
    ( 'Tom', 'Wopat', 3),
    ( 'Creflo', 'Madison', 1 ), 
	( 'Tyrone', 'Biggums', 4 ), 
	( 'Mitt', 'Romney', 2 ),
	( 'Tom', 'Okra', 1 ),
    ( 'Perry', 'White', 4 );

SELECT P.FirstName AS FirstName, P.LastName AS LastName, Stat.StatusDescription AS StatusDescription FROM person P RIGHT OUTER JOIN personstatus Stat ON P.PersonStatusId = Stat.PersonStatusId WHERE ( P.PersonStatusId = 1 && P.FirstName = 'Tom' );
