use db_ASP

create table Registration_Form(
Id int Primary Key not null identity(1,1),
FirstName varchar(20) not null,
LastName varchar(20) not null,
Current_Address varchar(200) not null,
Data_Of_Birth Date not null,
Contactno int not null,
Email varchar(20) not null,
[Password] varchar(20) not null,
[Confirm Password] varchar(20) not null
);


