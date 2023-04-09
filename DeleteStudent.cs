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
    public partial class DeleteStudent : Form
    {
        public readonly string _connection;
        public DeleteStudent()
        {
            InitializeComponent();
            _connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connection))
                {
                    connection.Open();
                    var student = (StudentList)comboStudents.SelectedItem;
                    string cmdText = $"DELETE Student_Lesson\r\nWHERE StudentID = {student.Id}";
                    string cmdText1 = $"DELETE Student\r\nWHERE ID = {student.Id}";
                    using (SqlCommand command = new SqlCommand(cmdText, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command1 = new SqlCommand(cmdText1, connection))
                    {
                        int rowAffect = command1.ExecuteNonQuery();
                        MessageBox.Show(rowAffect != 0 ? "Student successfully deleted !" : "There is no student with this name");
                        this.Hide();
                        var deleteStudent = new DeleteStudent();
                        //deleteStudent.Closed += (s, args) => this.Close();
                        deleteStudent.Show();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please select any student to remove");
            }
        }

        private void loadStudents()
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                string cmdText = "SELECT * FROM Student";
                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            StudentList studentList = new StudentList()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            };
                            comboStudents.Items.Add(studentList);
                        }
                    }
                }
            }
        }

        private void comboStudents_SelectedIndexChanged(object sender, EventArgs e)
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
