create table [User](
Id int identity(100,1) not null,
[Login] varchar(15) not null,
[Hash] varbinary(100) not null,
[Email] varchar(50) not null,
RegDate datetime not null,
LastVisitDate datetime null,
constraint PK_User primary key(Id),
constraint UQ_User_Login unique([Login]),
constraint UQ_User_Email unique(Email))

create table [Message](
Id int identity(1,1) not null,
[Text] varchar(140) not null,
Date datetime not null,
UserId int not null,
constraint PK_Message primary key(Id),
constraint FK_Message_User foreign key(UserId)
references [User](Id))
go

create table ErrorLogin(
Code int not null,
Text varchar(50) not null,
constraint PK_ErrorLogin primary key(Code))
go

insert into ErrorLogin(Code, Text)
	values(1,'Fail')
go