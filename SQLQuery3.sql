CREATE PROCEDURE dbo.SP_Check_Recruitment_Assignment @CandidateID varchar(9) , @RecruitmentAssignment varchar(500)
AS
update [bgu-users\alre].Volunteer_Requests
set Recruitment_Assignment = @RecruitmentAssignment
where [bgu-users\alre].Volunteer_Requests.Candidate_ID = @CandidateID 

execute SP_ADD_Recuitment_Assignment 694319209 , 'Discussion - What do you think the term membership includes? Do you think you have strengthened the ties of membership in the group?'