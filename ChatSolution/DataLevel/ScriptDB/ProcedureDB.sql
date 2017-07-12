create procedure [Login]
@login varchar(15),
@password binary(100)
as
select case 
			when exists(select '' from [User] where Login=@login and password=@password)
				then 0
			else 1
		end
go

create procedure [Registration]
@login varchar(15),
@password varbinary(100),
@email varchar(50)
as
select case 
			when exists(select '' from [User] where Login=@login)
				then 1
			when exists(select '' from [User] where Email=@email)
				then 2
			else 0
		end
go

create procedure [Logout]
@login varchar(15)
as
update [User]
	set LastVisitDate=GETDATE()
	where Login=@login
go

create procedure [AddMessage]
@text nvarchar(140),
@userId int
as
  insert into [Message] ([Text],[Date],[UserId])
	values(@text,GETDATE(),@userId)
go