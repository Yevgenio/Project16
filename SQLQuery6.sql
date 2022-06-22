CREATE PROCEDURE dbo.SP_Create_Remarks_On_Cadet_Assignment @CadetID varchar(9) , @Remarks varchar(300)
AS
update [bgu-users\alre].Assignments_for_Cadets
set Remarks = @Remarks
where [bgu-users\alre].Assignments_for_Cadets.Cadet_ID = @CadetID 

execute SP_Create_Remarks_On_Cadet_Assignment 112958882 , 'Required to perform again'