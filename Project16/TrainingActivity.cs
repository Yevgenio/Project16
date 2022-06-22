using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class TrainingActivity
    {
        private DateTime trainingActivityDate;
        private string school;
        private VolunteerPlaceEnum city;
        private ActivityTypeEnum type;
        private string trainingAspects;
        private string logisticalAspects;
        private string exceptionalEvents;
        public Volunteer volunteer;
        public List<CadetAttendance> cadetAttendance;

        public TrainingActivity(DateTime trainingActivity, string s, VolunteerPlaceEnum c, ActivityTypeEnum t,
            string training, string logistical, string exceptional, Volunteer v, bool is_new)
        {
            this.trainingActivityDate = trainingActivity;
            this.school = s;
            this.city = c;
            this.type = t;
            this.trainingAspects = training;
            this.logisticalAspects = logistical;
            this.exceptionalEvents = exceptional;
            this.volunteer = v;
            this.cadetAttendance = new List<CadetAttendance>();
            if (is_new)
            {
                this.create_TrainingActivity();
                Program.TrainingActivities.Add(this);
            }
        }

        public DateTime TrainingActivityDate { get => trainingActivityDate; set => trainingActivityDate = value; }
        public string School { get => school; set => school = value; }
        public VolunteerPlaceEnum City { get => city; set => city = value; }
        public ActivityTypeEnum Type { get => type; set => type = value; }
        public string TrainingAspects { get => trainingAspects; set => trainingAspects = value; }
        public string LogisticalAspects { get => logisticalAspects; set => logisticalAspects = value; }
        public string ExceptionalEvents { get => exceptionalEvents; set => exceptionalEvents = value; }
        public Volunteer Volunteer { get => volunteer; set => volunteer = value; }
        public List<CadetAttendance> CadetAttendance { get => cadetAttendance; set => cadetAttendance = value; }

        public void create_TrainingActivity()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_TrainingActivity @TrainingActivityDate ,@School, @City, @Type, @TrainingAspects, @LogisticalAspects, @ExceptionalEvents, @Volunteer";
            c.Parameters.AddWithValue("@TrainingActivityDate", this.trainingActivityDate);
            c.Parameters.AddWithValue("@School", this.school);
            c.Parameters.AddWithValue("@City", this.city.ToString());
            c.Parameters.AddWithValue("@Type", this.type.ToString());
            c.Parameters.AddWithValue("@TrainingAspects", this.trainingAspects);
            c.Parameters.AddWithValue("@LogisticalAspects", this.logisticalAspects);
            c.Parameters.AddWithValue("@ExceptionalEvents", this.exceptionalEvents);
            c.Parameters.AddWithValue("@Volunteer", this.volunteer);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
