CREATE PROCEDURE dbo.SP_Approve_Report_Status @EmployeeId varchar(9) , @Month int , @Year int, @AttendanceReportStatus varchar(50) 
AS
update [bgu-users\alre].Employee_Attendances
set Attendance_Report_Status = @AttendanceReportStatus
where [bgu-users\alre].Employee_Attendances.Employee_Number = @EmployeeId and month([bgu-users\alre].Employee_Attendances.Day_Work_Start) = @Month and year([bgu-users\alre].Employee_Attendances.Day_Work_Start) = @Year 

execute SP_Approve_Report_Status 25835523 , 2 ,2022 , 'Approved_and_transferred_for_payment'