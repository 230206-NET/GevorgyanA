CREATE TABLE USERS (
    ID INT PRIMARY KEY IDENTITY(1,1),
    NAME VARCHAR(20) UNIQUE,
    PASSWORD VARCHAR(20), 
    ISMANAGER INT,
    CONSTRAINT PASSWORD_VALIDATION CHECK (PASSWORD LIKE '%[a-z]%' and PASSWORD LIKE '%[A-Z]%' and PASSWORD LIKE '%[0-9]%' and PASSWORD LIKE '%[!@#$%^&*]%' and LEN(PASSWORD)>5),
    CONSTRAINT USERNAME_LENGTH CHECK (LEN(NAME)>3)  --(PASSWORD like '%[0-9]%' and PASSWORD like '%[A-Z]%' and PASSWORD like '%[a-z]%')
);


CREATE TABLE TICKET (
    ID INT PRIMARY KEY IDENTITY(1,1),
    DESCRIPTION VARCHAR(20),
    AMOUNT DECIMAL(20),
    STATUS INT,
    UserID INT FOREIGN KEY REFERENCES USERS(ID)
);

DROP TABLE TICKET;
DROP TABLE USERS;

SELECT * FROM Ticket;
SELECT * FROM USERS;