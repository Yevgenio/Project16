CREATE PROCEDURE dbo.SP_Check_Recruitment_Assignment @CandidateID varchar(9) , @Grade int
AS
update [bgu-users\alre].Volunteer_Requests
set Grade = @Grade
where [bgu-users\alre].Volunteer_Requests.Candidate_ID = @CandidateID 

execute SP_Check_Recruitment_Assignment 141360675 , 70