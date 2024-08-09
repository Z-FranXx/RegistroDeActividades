create table users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) null,
	password VARCHAR(MAX) null,
	date_register DATE null
)

SELECT * FROM users