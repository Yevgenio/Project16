
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string employeeId;
        private string employeeNumber;
        private GenderEnum gender;
        private string addressCity;
        private string addressStreet;
        private string addressHouseNumber;
        private string phoneNumber;
        private string email;
        private DateTime birthDate;
        private DateTime employmentStartDate;
        private MaritalEnum maritalStatus;
        private string anniversaryDate;
        private string password;
        public Position position;
        public List<EmployeeAttendance> employeeAttendance;
        public List<Volunteer> volunteer;
        public List<VolunteerRequest> volunteerRequest;

        public Employee(string fName, string lName, string ID, string empNumber, GenderEnum g, string city, string street,
           string houseNumber, string phone, string e, DateTime birth, DateTime employmentStart, MaritalEnum m
            , string anniversary, string ps, Position p, bool is_new)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.employeeId = ID;
            this.employeeNumber = empNumber;
            this.gender = g;
            this.addressCity = city;
            this.addressStreet = street;
            this.addressHouseNumber = houseNumber;
            this.phoneNumber = phone;
            this.email = e;
            this.birthDate = birth;
            this.employmentStartDate = employmentStart;
            this.maritalStatus = m;
            this.anniversaryDate = anniversary;
            this.password = ps;
            this.position = p;
            this.employeeAttendance = new List<EmployeeAttendance>();
            this.volunteer = new List<Volunteer>();
            this.volunteerRequest = new List<VolunteerRequest>();
            if (is_new)
            {
                this.create_Employee();
                Program.Employees.Add(this);
            }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmployeeID { get => employeeId; set => employeeId = value; }
        public string EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public string AddressCity { get => addressCity; set => addressCity = value; }
        public string AddressStreet { get => addressStreet; set => addressStreet = value; }
        public string AddressHouseNumber { get => addressHouseNumber; set => addressHouseNumber = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public DateTime EmploymentStartDate { get => employmentStartDate; set => employmentStartDate = value; }
        public MaritalEnum MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        public string AnniversaryDate { get => anniversaryDate; set => anniversaryDate = value; }
        public string Password { get => password; set => password = value; }
        public Position Position { get => position; set => position = value; }
        public List<EmployeeAttendance> EmployeeAttendance { get => employeeAttendance; set => employeeAttendance = value; }
        public List<Volunteer> Volunteer { get => volunteer; set => volunteer = value; }
        public List<VolunteerRequest> VolunteerRequest { get => volunteerRequest; set => volunteerRequest = value; }

        public void create_Employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Employee @FirstName , @LastName , @ID, @EmployeeNumber , @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber , @Email, @BirthDate, @EmploymentStartDate, @MaritalStatus, @AnniversaryDate, @Password, @Position";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.employeeId);
            c.Parameters.AddWithValue("@EmployeeNumber", this.employeeNumber);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@EmploymentStartDate", this.employmentStartDate);
            c.Parameters.AddWithValue("@Marital", this.maritalStatus.ToString());
            c.Parameters.AddWithValue("@AnniversaryDate", this.anniversaryDate);
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Position", this.position);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_Employee @FirstName , @LastName , @ID, @EmployeeNumber , @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber , @Email, @BirthDate, @EmploymentStartDate, @MaritalStatus, @AnniversaryDate, @Password, @Position";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.employeeId);
            c.Parameters.AddWithValue("@EmployeeNumber", this.employeeNumber);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@EmploymentStartDate", this.employmentStartDate);
            c.Parameters.AddWithValue("@Marital", this.maritalStatus.ToString());
            c.Parameters.AddWithValue("@AnniversaryDate", this.anniversaryDate);
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Position", this.position);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void delete_Employee()
        {
            Program.Employees.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Employee @EmployeeNumber";
            c.Parameters.AddWithValue("@EmployeeNumber", this.employeeId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        //public void review_Organization_Activity_Report()
        //{
        //}
    }
}
