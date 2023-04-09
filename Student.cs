using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OurClass
{
    public partial class Student : Form
    {
        public readonly string _connectionString;
        public Student()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                string cmdText = "SELECT * FROM University";
                using (SqlCommand command = new SqlCommand(cmdText, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            University university = new University()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)

                            };
                            comboUniversity.Items.Add(university);
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usr_sp_CreateStudent", connection))
                    {
                        var university = (University)comboUniversity.SelectedItem;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                        command.Parameters.AddWithValue("@Grade", txtGrade.Text);
                        command.Parameters.AddWithValue("@UniversityID", university.Id);
                        var rowAffect = command.ExecuteNonQuery();
                        if (rowAffect != 0)
                        {
                            MessageBox.Show("Student Successfully Created !\nYou are redirecting to the choose lessons page");
                            this.Close();
                            Lessons lessons = new Lessons();
                            lessons.Show();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong :( Please exit and try again");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in the blanks");
            }
        }

        private void comboUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
