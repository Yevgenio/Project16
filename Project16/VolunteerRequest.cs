using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class VolunteerRequest
    {
        private string firstName;
        private string lastName;
        private string candidateId;
        private GenderEnum gender;
        private DateTime birthDate;
        private MaritalEnum maritalStatus;
        private string email;
        private string phoneNumber;
        private string cellphoneNumber;
        private InstitutionEnum academicInstitution;
        private VolunteerPlaceEnum volunteeringPlacePreference;
        private bool reliabilityStatement;
        private string recruitmentAssignment;
        private int grade;
        public Volunteer volunteer;
        public List<Employee> employee;

        public VolunteerRequest(string fName, string lName, string ID, GenderEnum g, DateTime birth, MaritalEnum m, string e,
            string phone, string cellPhone, InstitutionEnum i, VolunteerPlaceEnum vp, bool reliability, string recruitment, int gr, Volunteer v,
            bool is_new)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.candidateId = ID;
            this.gender = g;
            this.birthDate = birth;
            this.maritalStatus = m;
            this.email = e;
            this.phoneNumber = phone;
            this.cellphoneNumber = cellPhone;
            this.academicInstitution = i;
            this.volunteeringPlacePreference = vp;
            this.reliabilityStatement = reliability;
            this.recruitmentAssignment = recruitment;
            this.grade = gr;
            this.volunteer = v;
            this.employee = new List<Employee>();
            if (is_new)
            {
                this.create_Request();
                Program.VolunteerRequests.Add(this);
            }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string CandidateID { get => candidateId; set => candidateId = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public MaritalEnum MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string CellphoneNumber { get => cellphoneNumber; set => cellphoneNumber = value; }
        public InstitutionEnum AcademicInstitution { get => academicInstitution; set => academicInstitution = value; }
        public VolunteerPlaceEnum VolunteeringPlacePreference { get => volunteeringPlacePreference; set => volunteeringPlacePreference = value; }
        public bool ReliabilityStatement { get => reliabilityStatement; set => reliabilityStatement = value; }
        public string RecruitmentAssignment { get => recruitmentAssignment; set => recruitmentAssignment = value; }
        public int Grade { get => grade; set => grade = value; }
        public Volunteer Volunteer { get => volunteer; set => volunteer = value; }
        public List<Employee> Employee { get => employee; set => employee = value; }

        public void create_Request()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_VolunteerRequest @FirstName , @LastName , @ID, @Gender, @BirthDate, @MaritalStatus, @Email, @PhoneNumber, @CellphoneNumber, @AcademicInstitution, @VolunteeringPlacePreference, @ReliabilityStatement, @RecruitmentAssignment, @Grade, @Volunteer";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.candidateId);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@MaritalStatus", this.maritalStatus.ToString());
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@CellphoneNumber", this.cellphoneNumber);
            c.Parameters.AddWithValue("@AcademicInstitution", this.academicInstitution.ToString());
            c.Parameters.AddWithValue("@VolunteeringPlacePreference", this.volunteeringPlacePreference.ToString());
            c.Parameters.AddWithValue("@ReliabilityStatement", this.reliabilityStatement);
            c.Parameters.AddWithValue("@RecruitmentAssignment", this.recruitmentAssignment);
            c.Parameters.AddWithValue("@Grade", this.grade);
            c.Parameters.AddWithValue("@Volunteer", this.volunteer);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void add_Recruitment_Assignment()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_ADD_Recuitment_Assignment @CandidateID , @RecruitmentAssignment";
            c.Parameters.AddWithValue("@CandidateID", this.candidateId);
            c.Parameters.AddWithValue("@RecruitmentAssignment", this.recruitmentAssignment);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void check_Recruitment_Assignment()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Check_Recruitment_Assignment @CandidateID , @Grade";
            c.Parameters.AddWithValue("@CandidateID", this.candidateId);
            c.Parameters.AddWithValue(" @Grade", this.grade);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
