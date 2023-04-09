using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OurClass
{
    public partial class SeeStudentInfo : Form
    {
        public readonly string _connection;
        public SeeStudentInfo()
        {
            InitializeComponent();
            _connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            dgvStudents.BringToFront();
            comboSelectStudent.BringToFront();
            dgvStudentsLessons.BringToFront();
        }

        private void SeeStudentInfo_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = "SELECT StudentName, Grade, Name as 'University'\r\nFROM Student\r\nJOIN University\r\nON Student.UniversityID = University.ID";
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sqlConnection))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dgvStudents.DataSource = data;
                }
            }
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
                            comboSelectStudent.Items.Add(studentList);
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var student = (StudentList)comboSelectStudent.SelectedItem;
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = $"SELECT LessonName\r\nFROM Student\r\nJOIN Student_Lesson\r\nON Student_Lesson.StudentID = Student.ID\r\nJOIN Lesson\r\nON Student_Lesson.LessonID = Lesson.ID\r\nWHERE Student.ID = {student.Id};";
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmdText, sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvStudentsLessons.DataSource = dataTable;
                }
            }
        }

        private void dgvStudentsLessons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
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
