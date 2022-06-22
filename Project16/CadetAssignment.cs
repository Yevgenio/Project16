using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class CadetAssignment
    {
        private string assignmentDescription;
        private AssignmentStatusEnum assignmentStatus;
        private string remarks;
        public List<Cadet> cadet;

        public CadetAssignment(string assignment, AssignmentStatusEnum status, string r, bool is_new)
        {
            this.assignmentDescription = assignment;
            this.assignmentStatus = status;
            this.remarks = r;
            this.cadet = new List<Cadet>();
            if (is_new)
            {
                this.create_Cadet_Assignment();
                Program.CadetAssignments.Add(this);

            }
        }

        public string AssignmentDescription { get => assignmentDescription; set => assignmentDescription = value; }
        public AssignmentStatusEnum AssignmentStatus { get => assignmentStatus; set => assignmentStatus = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public List<Cadet> Cadet { get => cadet; set => cadet = value; }

        public void create_Cadet_Assignment()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Cadet_Assignment @AssignmentDescription, @AssignmentStatus, @Remarks";
            c.Parameters.AddWithValue("@AssignmentDescription", this.assignmentDescription);
            c.Parameters.AddWithValue("@AssignmentStatus", this.assignmentStatus.ToString());
            c.Parameters.AddWithValue("@Remarks", this.remarks);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void marked_Cadet_Assignment_As_Done(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Marked_Cadet_Assignment_As_Done @CadetID, @AssignmentStatus";
            c.Parameters.AddWithValue("@CadetID", id);
            c.Parameters.AddWithValue("@AssignmentStatus", this.assignmentStatus);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void create_Remarks_On_Cadet_Assignment(string id)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Create_Remarks_On_Cadet_Assignment @CadetID, @Remarks";
            c.Parameters.AddWithValue("@CadetID", id);
            c.Parameters.AddWithValue("@Remarks", this.remarks);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
