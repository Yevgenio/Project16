CREATE PROCEDURE dbo.SP_Marked_Cadet_Assignment_As_Done @CadetID varchar(9) , @AssignmentStatus varchar(20)
AS
update [bgu-users\alre].Assignments_for_Cadets
set Assignment_Status = @AssignmentStatus
where [bgu-users\alre].Assignments_for_Cadets.Cadet_ID = @CadetID 

execute SP_Marked_Cadet_Assignment_As_Done 112958882 , 'Done'