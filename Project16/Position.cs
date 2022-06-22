using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class Position
    {
        private string title;
        private int positionAmount;
        private Decimal salary;
        private int hoursRequired;
        private PopulationEnum targetPopulation;
        public List<Employee> employee;
        public List<Volunteer> volunteer;

        public Position(string t, int amount, Decimal s, int hours, PopulationEnum p,
           bool is_new)
        {
            this.title = t;
            this.positionAmount = amount;
            this.salary = s;
            this.hoursRequired = hours;
            this.targetPopulation = p;
            this.employee = new List<Employee>();
            this.volunteer = new List<Volunteer>();
            if (is_new)
            {
                this.create_Position();
                Program.Positions.Add(this);
            }
        }

        public string Title { get => title; set => title = value; }
        public int PositionAmount { get => positionAmount; set => positionAmount = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public int HoursRequired { get => hoursRequired; set => hoursRequired = value; }
        public PopulationEnum TargetPopulation { get => targetPopulation; set => targetPopulation = value; }
        public List<Employee> Employee { get => employee; set => employee = value; }
        public List<Volunteer> Volunteer { get => volunteer; set => volunteer = value; }

        public void create_Position()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Position @Title, @PositionAmount, @Salary, @HoursRequired, @Population";
            c.Parameters.AddWithValue("@Title", this.title);
            c.Parameters.AddWithValue("@PositionAmount", this.positionAmount);
            c.Parameters.AddWithValue("@Salary", this.salary);
            c.Parameters.AddWithValue("@HoursRequired", this.hoursRequired);
            c.Parameters.AddWithValue("@Population", this.targetPopulation.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        
        public int calculate_Available_Position_Amount(string title)
        {
            int occupied = calculate_Non_Available_Position_Amount(title);
            int position_Amount = 0;
            foreach (Position p in Program.Positions)
            {
                if (p.Title == title)
                    position_Amount = p.PositionAmount;
            }
            int available_Position_Amount = position_Amount - occupied;
            return available_Position_Amount;
        }

        public int calculate_Non_Available_Position_Amount(string title)
        {
            int occupied = 0;
            foreach (Employee e in Program.Employees)
            {
                if (e.position.title == title)
                    occupied++;
            }
            return occupied;
        }

        public void toString()// קוד הדפסה לדוגמה
        {
            Console.WriteLine("title " + this.title + " positionAmount " + this.positionAmount + " salary " + this.salary
               + " hoursRequired " + this.hoursRequired + " targetPopulation " + this.targetPopulation);
        }
    }
}
