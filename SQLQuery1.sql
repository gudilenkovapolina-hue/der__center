CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    login VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL
);

INSERT INTO users (login, password) VALUES ('Полина', '03.10.2008');

ALTER TABLE users ADD FullName VARCHAR(100);
ALTER TABLE users ADD Age INT;
ALTER TABLE users ADD Phone VARCHAR(20);
ALTER TABLE users ADD ParentName VARCHAR(100);

UPDATE users 
SET FullName = 'Полина Гудиленкова', 
    Age = 18, 
    Phone = '+7 (904) 052-12-16', 
    ParentName = 'Гудиленкова Мария Петровна'
WHERE password = '03.10.2008';