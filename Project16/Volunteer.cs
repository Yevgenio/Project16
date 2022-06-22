using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class Volunteer
    {
        private string firstName;
        private string lastName;
        private string volunteerId;
        private GenderEnum gender;
        private string addressCity;
        private string addressStreet;
        private string addressHouseNumber;
        private string phoneNumber;
        private string email;
        private DateTime birthDate;
        private ScholarshipEnum scholarshipType;
        private InstitutionEnum academicInstitution;
        private string password;
        public Employee employee;
        public Position position;
        public List<VolunteerRequest> volunteerRequest;
        public List<Cadet> cadet;
        public List<TrainingActivity> trainingActivity;

        public Volunteer(string fName, string lName, string ID, GenderEnum g, string city, string street,
           string houseNumber, string phone, string e, DateTime birth, ScholarshipEnum s, InstitutionEnum i, string ps, Employee emp,
           Position p, bool is_new)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.volunteerId = ID;
            this.addressCity = city;
            this.addressStreet = street;
            this.addressHouseNumber = houseNumber;
            this.phoneNumber = phone;
            this.email = e;
            this.birthDate = birth;
            this.scholarshipType = s;
            this.academicInstitution = i;
            this.password = ps;
            this.employee = emp;
            this.position = p;
            this.volunteerRequest = new List<VolunteerRequest>();
            this.cadet = new List<Cadet>();
            this.trainingActivity = new List<TrainingActivity>();
            if (is_new)
            {
                this.create_Volunteer();
                Program.Volunteers.Add(this);
            }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string VolunteerID { get => volunteerId; set => volunteerId = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public string AddressCity { get => addressCity; set => addressCity = value; }
        public string AddressStreet { get => addressStreet; set => addressStreet = value; }
        public string AddressHouseNumber { get => addressHouseNumber; set => addressHouseNumber = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public ScholarshipEnum ScholarshipType { get => scholarshipType; set => scholarshipType = value; }
        public InstitutionEnum AcademicInstitution { get => academicInstitution; set => academicInstitution = value; }
        public string Password { get => password; set => password = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public Position Position { get => position; set => position = value; }
        public List<VolunteerRequest> VolunteerRequest { get => volunteerRequest; set => volunteerRequest = value; }
        public List<Cadet> Cadet { get => cadet; set => cadet = value; }
        public List<TrainingActivity> TrainingActivity { get => trainingActivity; set => trainingActivity = value; }

        public void create_Volunteer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Volunteer @FirstName , @LastName , @ID, @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber , @Email, @BirthDate, @ScholarshipType, @AcademicInstitution, @Password, @Employee, @Position";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.volunteerId);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@ScholarshipType", this.scholarshipType.ToString());
            c.Parameters.AddWithValue("@AcademicInstitution", this.academicInstitution.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Employee", this.employee);
            c.Parameters.AddWithValue("@Position", this.position);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Volunteer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_Volunteer @FirstName , @LastName , @ID, @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber , @Email, @BirthDate, @ScholarshipType, @AcademicInstitution, @Password, @Employee, @Position";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.volunteerId);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@ScholarshipType", this.scholarshipType.ToString());
            c.Parameters.AddWithValue("@AcademicInstitution", this.academicInstitution.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Employee", this.employee);
            c.Parameters.AddWithValue("@Position", this.position);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void delete_Volunteer()
        {
            Program.Volunteers.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Volunteer @ID";
            c.Parameters.AddWithValue("ID", this.volunteerId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
