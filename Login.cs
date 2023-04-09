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
    public partial class Login : Form
    {
        public readonly string _connectionString;
        public static string username;
        public static string password;
        public Login()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (TryLogin(username,password))
            {
                this.Hide();
                Welcome welcome = new Welcome();
                welcome.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }
        private bool TryLogin(string username, string password)
        {
            bool hasRow = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("usr_Sp_TryLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@usrName", username);
                    command.Parameters.AddWithValue("@Pass", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        hasRow = reader.HasRows;
                    }
                }
            }
            return hasRow;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

    }
}
