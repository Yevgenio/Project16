using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16
{
    public partial class SignIn : Form
    {
        Boolean isExists = false;
        string name = "";

        public SignIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string id = InsertIDTable.Text;
            string password = InsertPasswordTable.Text;
            //בדיקת חריגות הקשורות בת.ז
            if ((id == "") || (id.Length != 9))
            {
                MessageBox.Show("You must enter valid ID");
            }
            //בדיקת חריגות הקשורות בסיסמה
            if (password == "")
            {
                MessageBox.Show("You must enter password");
            }
            //כניסה למערכת לפי סוג משתמש
            else
            {
                //בדיקה האם מדובר בעובד
                foreach (Employee em in Program.Employees)
                {
                    if ((em.EmployeeID == id) && (em.Password == password))
                    {
                        isExists = true;
                        name = em.FirstName;
                    }
                }
                if (isExists == true)
                {
                    EmployeeScreen empScreen = new EmployeeScreen();
                    empScreen.Show();
                    this.Hide();
                    MessageBox.Show("Hello " + name);
                }
                //בדיקה האם מדובר במתנדב
                else
                {
                    foreach (Volunteer vo in Program.Volunteers)
                    {
                        if ((vo.VolunteerID == id) && (vo.Password == password))
                        {
                            isExists = true;
                            name = vo.FirstName;
                        }
                    }
                    if (isExists == true)
                    {
                        //EmployeeScreen empScreen = new EmployeeScreen();
                        //empScreen.Show();
                        this.Hide();
                        MessageBox.Show("Hello " + name);
                    }
                    //בדיקה האם מדובר בהורה
                    else
                    {
                        foreach (Parent pa in Program.Parents)
                        {
                            if ((pa.ParentID == id) && (pa.Password == password))
                            {
                                isExists = true;
                                name = pa.FirstName;
                            }
                        }
                        if (isExists == true)
                        {
                            ParentScreen parScreen = new ParentScreen();
                            parScreen.Show();
                            this.Hide();
                            MessageBox.Show("Hello " + name);
                        }
                        //בדיקה האם מדובר בחניך
                        else
                        {
                            foreach (Cadet ca in Program.Cadets)
                            {
                                if ((ca.CadetID == id) && (ca.Password == password))
                                {
                                    isExists = true;
                                    name = ca.FirstName;
                                }
                            }
                            if (isExists == true)
                            {
                                //EmployeeScreen empScreen = new EmployeeScreen();
                                //empScreen.Show();
                                this.Hide();
                                MessageBox.Show("Hello " + name);
                            }
                        }
                    }
                }
                //במידה ופרטי המשתמש לא רשומים במערכת תישלח הודעת שגיאה
                if (isExists == false)
                {
                    MessageBox.Show("Please verify that the inserted details are correct");
                }
            }
        }

        private void InsertIDTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertPasswordTable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
