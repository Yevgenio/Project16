using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class Answer
    {
        private int answerNumber;
        private string content;
        private double weight;
        public Question question;

        public Answer(int answer, string c, double w, Question q, bool is_new)
        {
            this.answerNumber = answer;
            this.content = c;
            this.weight = w;
            this.question = q;
            if (is_new)
            {
                this.create_Answer();
                Program.Answers.Add(this);
            }
        }


        public int AnswerNumber { get => answerNumber; set => answerNumber = value; }
        public string Content { get => content; set => content = value; }
        public double Weight { get => weight; set => weight = value; }
        public Question Question { get => question; set => question = value; }


        public void create_Answer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Answer @AnswerNumber , @Content , @Weight, @Question";
            c.Parameters.AddWithValue("@AnswerNumber", this.answerNumber);
            c.Parameters.AddWithValue("@Content", this.content);
            c.Parameters.AddWithValue("@Weight", this.weight);
            c.Parameters.AddWithValue("@Question", this.question);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Answer_By_Creator()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_Answer @AnswerNumber , @Content , @Weight, @Question";
            c.Parameters.AddWithValue("@AnswerNumber", this.answerNumber);
            c.Parameters.AddWithValue("@Content", this.content);
            c.Parameters.AddWithValue("@Weight", this.weight);
            c.Parameters.AddWithValue("@Question", this.question);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        //public double calculate_Answer_Result()
        //{
        //}
    }
}
