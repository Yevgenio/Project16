using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class CadetAttendance
    {
        private bool attendanceStatus;
        private string behaviorDescription;
        private string learningDescription;
        private string grade;
        public Cadet cadet;
        public TrainingActivity trainingActivity;

        public CadetAttendance(bool Status, string behavior, string learning, string g,
            Cadet c, TrainingActivity ta)
        {
            this.attendanceStatus = Status;
            this.behaviorDescription = behavior;
            this.learningDescription = learning;
            this.grade = g;
            this.cadet = c;
            this.trainingActivity = ta;
        }

        public bool AttendanceStatus { get => attendanceStatus; set => attendanceStatus = value; }
        public string BehaviorDescription { get => behaviorDescription; set => behaviorDescription = value; }
        public string LearningDescription { get => learningDescription; set => learningDescription = value; }
        public Cadet Cadet { get => cadet; set => cadet = value; }
        public TrainingActivity TrainingActivity { get => trainingActivity; set => trainingActivity = value; }
        public string Grade { get => grade; set => grade = value; }
    }
}
