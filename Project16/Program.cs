using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project16
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Answer> Answers;
        public static System.Collections.Generic.List<Cadet> Cadets;
        public static System.Collections.Generic.List<CadetAssignment> CadetAssignments;
        public static System.Collections.Generic.List<EmployeeAttendance> EmployeeAttendances;
        public static System.Collections.Generic.List<Parent> Parents;
        public static System.Collections.Generic.List<Position> Positions;
        public static System.Collections.Generic.List<Question> Questions;
        public static System.Collections.Generic.List<TrainingActivity> TrainingActivities;
        public static System.Collections.Generic.List<Volunteer> Volunteers;
        public static System.Collections.Generic.List<VolunteerRequest> VolunteerRequests;
        [STAThread]

        public static Employee seekEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.EmployeeNumber == id)
                    return e;
            }
            return null;
        }

        public static Cadet seekCadet(string id)
        {
            foreach (Cadet c in Cadets)
            {
                if (c.CadetID == id)
                    return c;
            }
            return null;
        }

        public static Parent seekParent(string id)
        {
            foreach (Parent p in Parents)
            {
                if (p.ParentID == id)
                    return p;
            }
            return null;
        }

        public static Volunteer seekVolunteer(string id)
        {
            foreach (Volunteer v in Volunteers)
            {
                if (v.VolunteerID == id)
                    return v;
            }
            return null;
        }

        public static Position seekPosition(string title)
        {
            foreach (Position p in Positions)
            {
                if (p.Title == title)
                    return p;
            }
            return null;
        }

        public static Question seekQuestion(int question)
        {
            foreach (Question q in Questions)
            {
                if (q.QuestionNumber == question)
                    return q;
            }
            return null;
        }

        public static TrainingActivity seekTrainingActivities(DateTime activity)
        {
            foreach (TrainingActivity ta in TrainingActivities)
            {
                if (ta.TrainingActivityDate == activity)
                    return ta;
            }
            return null;
        }

        public static void initLists()//מילוי ואתחול הרשימות מתוך בסיס הנתונים
        {
            init_Parents();
            init_Positions();
            init_Employees();
            init_Cadets();
            init_Volunteers();
            init_Answers();
            init_CadetAssignments();
            init_EmployeeAttendances();
            init_Questions();
            init_TrainingActivities();
            init_VolunteerRequests();
        }

        public static void init_Parents()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Parents";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Parents = new List<Parent>();
            while (rdr.Read())
            {
                GenderEnum G = (GenderEnum)Enum.Parse(typeof(GenderEnum), rdr.GetValue(3).ToString());
                Parent p = new Parent(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(),
                    G, rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(),
                    DateTime.Parse((rdr.GetValue(8).ToString())), rdr.GetValue(9).ToString(), false);
                Parents.Add(p);
            }
        }

        public static void init_Positions()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Positions";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Positions = new List<Position>();
            while (rdr.Read())
            {
                PopulationEnum po = (PopulationEnum)Enum.Parse(typeof(PopulationEnum), rdr.GetValue(4).ToString());
                Position p = new Position(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()),
                    decimal.Parse(rdr.GetValue(2).ToString()), int.Parse(rdr.GetValue(3).ToString()), po, false);
                Positions.Add(p);
            }
        }

        public static void init_Employees()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Employees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Employees = new List<Employee>();
            while (rdr.Read())
            {
                GenderEnum G = (GenderEnum)Enum.Parse(typeof(GenderEnum), rdr.GetValue(4).ToString());
                MaritalEnum M = (MaritalEnum)Enum.Parse(typeof(MaritalEnum), rdr.GetValue(12).ToString());
                Employee e = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(),
                    rdr.GetValue(3).ToString(), G, rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(),
                    rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), DateTime.Parse((rdr.GetValue(10).ToString())), DateTime.Parse((rdr.GetValue(11).ToString())),
                    M, DateTime.Parse((rdr.GetValue(13).ToString())), seekPosition(rdr.GetValue(14).ToString()), false);
                Employees.Add(e);
            }
        }

        public static void init_Cadets()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Cadets";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Cadets = new List<Cadet>();
            while (rdr.Read())
            {
                GenderEnum G = (GenderEnum)Enum.Parse(typeof(GenderEnum), rdr.GetValue(3).ToString());
                CadetStatusEnum CS = (CadetStatusEnum)Enum.Parse(typeof(CadetStatusEnum), rdr.GetValue(10).ToString());
                Cadet ct = new Cadet(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(),
                    G, rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(),
                    DateTime.Parse((rdr.GetValue(8).ToString())), rdr.GetValue(9).ToString(), CS, false);
                Cadets.Add(ct);
            }
        }

        public static void init_Volunteers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Volunteers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Volunteers = new List<Volunteer>();
            while (rdr.Read())
            {
                GenderEnum G = (GenderEnum)Enum.Parse(typeof(GenderEnum), rdr.GetValue(3).ToString());
                ScholarshipEnum S = (ScholarshipEnum)Enum.Parse(typeof(ScholarshipEnum), rdr.GetValue(10).ToString());
                InstitutionEnum I = (InstitutionEnum)Enum.Parse(typeof(InstitutionEnum), rdr.GetValue(11).ToString());
                Volunteer v = new Volunteer(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(),
                    G, rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(),
                    rdr.GetValue(8).ToString(), DateTime.Parse((rdr.GetValue(9).ToString())), S, I,
                    seekEmployee(rdr.GetValue(12).ToString()), seekPosition(rdr.GetValue(13).ToString()), false);
                Volunteers.Add(v);
            }
        }

        public static void init_Answers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Answers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Answers = new List<Answer>();
            while (rdr.Read())
            {
                Answer a = new Answer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(),
                   double.Parse(rdr.GetValue(2).ToString()), seekQuestion(int.Parse(rdr.GetValue(3).ToString())), false);
                Answers.Add(a);
            }
        }

        public static void init_CadetAssignments()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_CadetAssignments";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            CadetAssignments = new List<CadetAssignment>();
            while (rdr.Read())
            {
                AssignmentStatusEnum AS = (AssignmentStatusEnum)Enum.Parse(typeof(AssignmentStatusEnum), rdr.GetValue(1).ToString());
                CadetAssignment ca = new CadetAssignment(rdr.GetValue(0).ToString(), AS, false);
                CadetAssignments.Add(ca);
            }
        }

        public static void init_EmployeeAttendances()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_EmployeeAttendances";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            EmployeeAttendances = new List<EmployeeAttendance>();
            while (rdr.Read())
            {
                WorkPlaceEnum WP = (WorkPlaceEnum)Enum.Parse(typeof(WorkPlaceEnum), rdr.GetValue(2).ToString());
                EmployeeAttendance ea = new EmployeeAttendance(DateTime.Parse((rdr.GetValue(0).ToString())),
                    DateTime.Parse((rdr.GetValue(1).ToString())), WP, seekEmployee(rdr.GetValue(3).ToString()), false);
                EmployeeAttendances.Add(ea);
            }
        }

        public static void init_Questions()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Questions";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Questions = new List<Question>();
            while (rdr.Read())
            {
                Question q = new Question(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), false);
                Questions.Add(q);
            }
        }

        public static void init_TrainingActivities()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_TrainingActivities";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            TrainingActivities = new List<TrainingActivity>();
            while (rdr.Read())
            {
                VolunteerPlaceEnum VP = (VolunteerPlaceEnum)Enum.Parse(typeof(VolunteerPlaceEnum), rdr.GetValue(2).ToString());
                ActivityTypeEnum AT = (ActivityTypeEnum)Enum.Parse(typeof(ActivityTypeEnum), rdr.GetValue(3).ToString());
                TrainingActivity ta = new TrainingActivity(DateTime.Parse((rdr.GetValue(0).ToString())),
                    rdr.GetValue(1).ToString(), VP, AT, rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(),
                    rdr.GetValue(6).ToString(), seekVolunteer(rdr.GetValue(7).ToString()), false);
                TrainingActivities.Add(ta);
            }
        }

        public static void init_VolunteerRequests()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_VolunteerRequests";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            VolunteerRequests = new List<VolunteerRequest>();
            while (rdr.Read())
            {
                int temp = Convert.ToInt32(rdr.GetBoolean(11));
                bool statement;
                if (temp == 1)
                {
                    statement = true;
                }
                else
                {
                    statement = false;
                }
                GenderEnum G = (GenderEnum)Enum.Parse(typeof(GenderEnum), rdr.GetValue(3).ToString());
                MaritalEnum M = (MaritalEnum)Enum.Parse(typeof(MaritalEnum), rdr.GetValue(5).ToString());
                InstitutionEnum I = (InstitutionEnum)Enum.Parse(typeof(InstitutionEnum), rdr.GetValue(9).ToString());
                VolunteerPlaceEnum VP = (VolunteerPlaceEnum)Enum.Parse(typeof(VolunteerPlaceEnum), rdr.GetValue(10).ToString());
                VolunteerRequest vr = new VolunteerRequest(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                    rdr.GetValue(2).ToString(), G, DateTime.Parse((rdr.GetValue(4).ToString())), M,
                    rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), I,
                    VP, statement, rdr.GetValue(11).ToString(), seekVolunteer(rdr.GetValue(12).ToString()), false);
                VolunteerRequests.Add(vr);
            }
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            Application.Run(new Form1());
        }
    }
}
