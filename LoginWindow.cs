using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication2
{
    public partial class loginWindow : Form
    {

        public static string connectionString;
        public static bool loggedIn;

        public loginWindow()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            loggedIn = false;
        }

        private void CancelLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {

           

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM LoginDetails WHERE Username = @username AND Password = @password", connection);
                cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);

                using (SqlDataReader login = cmd.ExecuteReader())
                {
                    if (login.HasRows)
                    {

                        loggedIn = true;
                        this.Hide();
                        Form1 ss = new Form1();
                        ss.ShowDialog();
                    }
                }

                connection.Close();
            }

            catch (SqlException ex)
            {

            }

        }
    }
}
