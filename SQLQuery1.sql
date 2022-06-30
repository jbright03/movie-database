alter proc adduser

@username varchar(50),
@password varchar(50)
as
insert into logintable(username,password)
values (@username,@password)