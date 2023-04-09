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
    public partial class SignUp : Form
    {
        public readonly string _connectionString;
        public SignUp()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (fullName.Length < 5 || username.Length < 5 || password.Length < 5)
            {
                MessageBox.Show("Full Name, Username and Password must be at least 5 symbol");
            }
            else
            {
                if (TryAddUser(fullName, username, password))
                {
                    this.Hide();
                    MessageBox.Show("You are successfully signed up !\nPlease login now.");
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong.. Please try again..");
                }
            }
            
        }

        private bool TryAddUser(string fullName, string username, string password)
        {
            bool hasRows = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usr_sp_AddUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Fullname", fullName);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int rows = command.ExecuteNonQuery();
                    hasRows = rows != 0;
                }
            }
            return hasRows;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
