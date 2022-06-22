using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class Cadet
    {
        private string firstName;
        private string lastName;
        private string cadetId;
        private GenderEnum gender;
        private string addressCity;
        private string addressStreet;
        private string addressHouseNumber;
        private string phoneNumber;
        private DateTime birthDate;
        private string email;
        private CadetStatusEnum activityStatus;
        private string password;
        public List<Volunteer> volunteer;
        public List<Parent> parent;
        public List<CadetAssignment> cadetAssignment;
        public List<CadetAttendance> cadetAttendance;

        public Cadet(string fName, string lName, string ID, GenderEnum g, string city, string street,
           string houseNumber, string phone, DateTime birth, string e, CadetStatusEnum cs, string ps, bool is_new)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.cadetId = ID;
            this.gender = g;
            this.addressCity = city;
            this.addressStreet = street;
            this.addressHouseNumber = houseNumber;
            this.phoneNumber = phone;
            this.birthDate = birth;
            this.email = e;
            this.activityStatus = cs;
            this.password = ps;
            this.volunteer = new List<Volunteer>();
            this.parent = new List<Parent>();
            this.cadetAssignment = new List<CadetAssignment>();
            this.cadetAttendance = new List<CadetAttendance>();
            if (is_new)
            {
                this.create_Cadet();
                Program.Cadets.Add(this);
            }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string CadetID { get => cadetId; set => cadetId = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public string AddressCity { get => addressCity; set => addressCity = value; }
        public string AddressStreet { get => addressStreet; set => addressStreet = value; }
        public string AddressHouseNumber { get => addressHouseNumber; set => addressHouseNumber = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Email { get => email; set => email = value; }
        public CadetStatusEnum ActivityStatus { get => activityStatus; set => activityStatus = value; }
        public string Password { get => password; set => password = value; }
        public List<Volunteer> Volunteer { get => volunteer; set => volunteer = value; }
        public List<Parent> Parent { get => parent; set => parent = value; }
        public List<CadetAssignment> CadetAssignment { get => cadetAssignment; set => cadetAssignment = value; }
        public List<CadetAttendance> CadetAttendance { get => cadetAttendance; set => cadetAttendance = value; }


        public void create_Cadet()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Cadet @FirstName , @LastName , @ID, @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber, @BirthDate, @Email, @ActivityStatus, @Password";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.cadetId);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@CadetStatus", this.activityStatus.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Cadet()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_Cadet @FirstName , @LastName , @ID, @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber, @BirthDate, @Email, @ActivityStatus, @Password";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.cadetId);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@CadetStatus", this.activityStatus.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void delete_Cadet()
        {
            Program.Cadets.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Cadet @ID";
            c.Parameters.AddWithValue("@ID", this.cadetId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
