using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class Question
    {
        private int questionnaireId;
        private int questionNumber;
        private string content;
        public List<Answer> answer;

        public Question(int id, int number, string c, bool is_new)
        {
            this.questionnaireId = id;
            this.questionNumber = number;
            this.content = c;
            this.answer = new List<Answer>();
            if (is_new)
            {
                this.create_Question();
                Program.Questions.Add(this);
            }
        }
        public int QuestionnaireId { get => questionnaireId; set => questionnaireId = value; }
        public int QuestionNumber { get => questionNumber; set => questionNumber = value; }
        public string Content { get => content; set => content = value; }
        public List<Answer> Answer { get => answer; set => answer = value; }

        public void create_Question()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Question @QuestionnaireId ,@QuestionNumber , @Content , @Answer";
            c.Parameters.AddWithValue("@QuestionnaireId", this.questionnaireId);
            c.Parameters.AddWithValue("@QuestionNumber", this.questionNumber);
            c.Parameters.AddWithValue("@Content", this.content);
            c.Parameters.AddWithValue("@Answer", this.answer);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Qustion_By_Creator()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_Question @QuestionnaireId ,@QuestionNumber , @Content , @Answer";
            c.Parameters.AddWithValue("@QuestionnaireId", this.questionnaireId);
            c.Parameters.AddWithValue("@QuestionNumber", this.questionNumber);
            c.Parameters.AddWithValue("@Content", this.content);
            c.Parameters.AddWithValue("@Answer", this.answer);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
