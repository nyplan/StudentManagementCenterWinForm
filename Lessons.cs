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
    public partial class Lessons : Form
    {
        public readonly string _connection;
        public Lessons()
        {
            InitializeComponent();
            _connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
        private void Lessons_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();
                string cmdText = "SELECT * FROM Lesson";
                using (SqlCommand command = new SqlCommand(cmdText, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lesson lesson = new Lesson()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            };
                            comboLesson.Items.Add(lesson);
                        }
                    }
                }
            }
        }

        private void comboLesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblLessons_Click(object sender, EventArgs e)
        {

        }
        private void btnAddLessons_Click(object sender, EventArgs e)
        {
            var lesson = (Lesson)comboLesson.SelectedItem;
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                int lastStudentIndex = 0;
                using (SqlCommand command = new SqlCommand("SELECT * From Student", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lastStudentIndex = reader.GetInt32(0);
                        }
                    }
                  
                }
                try
                {
                    using (SqlCommand command = new SqlCommand("usr_sp_AddLesson", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", lastStudentIndex);
                        command.Parameters.AddWithValue("@LessonID", lesson.Id);
                        var rowAffect = command.ExecuteNonQuery();
                        if (rowAffect != 0)
                        {
                            MessageBox.Show("Lesson Successfully Added !");
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please select any lesson to add");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Student student = new Student();
            student.Show();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
