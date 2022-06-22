using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class EmployeeAttendance
    {
        private DateTime dayWorkStart;
        private DateTime dayWorkEnd;
        private WorkPlaceEnum workPlace;
        private ReportStatusEnum attendanceReportStatus;
        public Employee employee;

        public EmployeeAttendance(DateTime start, DateTime end, WorkPlaceEnum wp, ReportStatusEnum attendanceReport, Employee e,
           bool is_new)
        {
            this.dayWorkStart = start;
            this.dayWorkEnd = end;
            this.workPlace = wp;
            this.attendanceReportStatus = attendanceReport;
            this.employee = e;
            if (is_new)
            {
                this.create_EmployeeAttendance();
                Program.EmployeeAttendances.Add(this);
            }
        }

        public DateTime DayWorkStart { get => dayWorkStart; set => dayWorkStart = value; }
        public DateTime DayWorkEnd { get => dayWorkEnd; set => dayWorkEnd = value; }
        public WorkPlaceEnum WorkPlace { get => workPlace; set => workPlace = value; }
        public ReportStatusEnum AttendanceReportStatus { get => attendanceReportStatus; set => attendanceReportStatus = value; }
        public Employee Employee { get => employee; set => employee = value; }

        public void create_EmployeeAttendance()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_EmployeeAttendance @dayWorkStart , @dayWorkEnd , @workPlace, @AttendanceReportStatus, @employee";
            c.Parameters.AddWithValue("@DayWorkStart", this.dayWorkStart);
            c.Parameters.AddWithValue("@DayWorkEnd", this.dayWorkEnd);
            c.Parameters.AddWithValue("@WorkPlace", this.workPlace.ToString());
            c.Parameters.AddWithValue("@AttendanceReportStatus", this.attendanceReportStatus.ToString());
            c.Parameters.AddWithValue("@Employee", this.employee);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void edit_Attendance_report()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE update_EmployeeAttendance @dayWorkStart , @dayWorkEnd , @workPlace, @AttendanceReportStatus, @employee";
            c.Parameters.AddWithValue("@DayWorkStart", this.dayWorkStart);
            c.Parameters.AddWithValue("@DayWorkEnd", this.dayWorkEnd);
            c.Parameters.AddWithValue("@WorkPlace", this.workPlace.ToString());
            c.Parameters.AddWithValue("@AttendanceReportStatus", this.attendanceReportStatus.ToString());
            c.Parameters.AddWithValue("@Employee", this.employee);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void delete_Attendance_report()
        {
            Program.EmployeeAttendances.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Attendance_report @dayWorkStart, @employee";
            c.Parameters.AddWithValue("@dayWorkStart", this.dayWorkStart);
            c.Parameters.AddWithValue("@employee", this.employee);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void approve_Report_Status(string id, int month, int year)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Approve_Report_Status @EmployeeId, @Month, @Year, @AttendanceReportStatus";
            c.Parameters.AddWithValue("@EmployeeId", id);
            c.Parameters.AddWithValue("@Month", month);
            c.Parameters.AddWithValue("@Year", year);
            c.Parameters.AddWithValue("@AttendanceReportStatus", this.attendanceReportStatus.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
