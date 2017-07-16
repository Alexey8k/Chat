﻿create procedure [Login]
@hash varbinary(100)
as
select case 
			when exists(select '' from [User] where [Hash]=@hash)
				then 0
			else 2
		end	Result
go

create procedure [Registration]
@login varchar(15),
@hash varbinary(100),
@email varchar(50)
as
declare @result int = case 
			when exists(select '' from [User] where [Login]=@login)
				then 1
			when exists(select '' from [User] where Email=@email)
				then 2
			else 0
		end
if @result=0
	insert into [User]([Login],[Email],[Hash],[RegDate])
		values(@login,@email,@hash,GETDATE())
select @result Result
go

create procedure [Logout]
@userId int
as
update [User]
	set LastVisitDate=GETDATE()
	where Id=@userId
go

create procedure [AddMessage]
@text nvarchar(140),
@userId int
as
  insert into [Message] ([Text],[Date],[UserId])
	values(@text,GETDATE(),@userId)
go

create procedure GetMessages
@userId int
as
select m.Text,m.UserId,m.Date from [Message] m
	join [User] u on u.LastVisitDate<=m.Date
	where u.Id=@userId
go

create procedure GetUser
@hash varbinary(100)
as
select * from [User]
	where [Hash]=@hash
go