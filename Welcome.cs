using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurClass
{
    public partial class Welcome : Form
    {
        public readonly string _connectionString;
        public Welcome()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string cmdText = $"SELECT Fullname FROM Users\r\nWHERE Username = '{Login.username}' AND Password = '{Login.password}'";
                using (SqlCommand command = new SqlCommand(cmdText, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            lblWelcome.Text = $"Welcome {name}";
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.Show();
        }

        private void btnSeeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeeStudentInfo seeStudentInfo = new SeeStudentInfo();
            seeStudentInfo.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
