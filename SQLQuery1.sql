CREATE PROCEDURE dbo.SP_calculate_Available_Position_Amount @Title varchar(150)
AS
declare @Amount int
select @Amount = sum(distinct p.Position_Amount) - COUNT(*)
from [bgu-users\alre].Positions as p join [bgu-users\alre].Employees as e on p.Title = e.Title
where e.Title = @Title
return @Amount


 


