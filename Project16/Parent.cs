using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project16
{
    public class Parent
    {
        private string firstName;
        private string lastName;
        private string parentId;
        private GenderEnum gender;
        private string addressCity;
        private string addressStreet;
        private string addressHouseNumber;
        private string phoneNumber;
        private DateTime birthDate;
        private string email;
        private string password;
        public List<Cadet> cadet;

        public Parent(string fName, string lName, string ID, GenderEnum g, string city, string street,
          string houseNumber, string phone, DateTime birth, string e, string ps, bool is_new)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.parentId = ID;
            this.gender = g;
            this.addressCity = city;
            this.addressStreet = street;
            this.addressHouseNumber = houseNumber;
            this.phoneNumber = phone;
            this.birthDate = birth;
            this.email = e;
            this.password = ps;
            this.cadet = new List<Cadet>();
            if (is_new)
            {
                this.create_Parent();
                Program.Parents.Add(this);
            }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string ParentID { get => parentId; set => parentId = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public string AddressCity { get => addressCity; set => addressCity = value; }
        public string AddressStreet { get => addressStreet; set => addressStreet = value; }
        public string AddressHouseNumber { get => addressHouseNumber; set => addressHouseNumber = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public List<Cadet> Cadet { get => cadet; set => cadet = value; }

        public void create_Parent()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_Parent @FirstName , @LastName , @ID, @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber, @BirthDate, @Email, @Password";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.parentId);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@Password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_Parent()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_update_Parent @FirstName , @LastName , @ID, @Gender, @AddressCity, @AddressStreet, @AddressHouseNumber,  @PhoneNumber, @BirthDate, @Email, @Password";
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@ID", this.parentId);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@AddressCity", this.addressCity);
            c.Parameters.AddWithValue("@AddressStreet", this.addressStreet);
            c.Parameters.AddWithValue("@AddressHouseNumber", this.addressHouseNumber);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@Password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void delete_Parent()
        {
            Program.Parents.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_Parent @ID";
            c.Parameters.AddWithValue("@ID", this.parentId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
