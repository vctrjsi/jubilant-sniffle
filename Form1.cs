using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\window 8\documents\visual studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (loginWindow.loggedIn == false)
            {
                Hide();
                loginWindow ss = new loginWindow();
                ss.Show();
                
            }
            else
            {
                Show();
            }
            

            


            StudentDetailsTable.Items.Clear();

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentDetails ORDER BY StudentID ASC", con);

                SqlDataReader datareader = cmd.ExecuteReader();

                while (datareader.Read())
                {
                    ListViewItem item = new ListViewItem(datareader["StudentID"].ToString());
                    item.SubItems.Add(datareader["FirstName"].ToString());
                    item.SubItems.Add(datareader["LastName"].ToString());
                    item.SubItems.Add(datareader["DateofBirth"].ToString());
                    item.SubItems.Add(datareader["Allergies"].ToString());
                    item.SubItems.Add(datareader["MedicalNotes"].ToString());
                    item.SubItems.Add(datareader["ParentID"].ToString());

                    StudentDetailsTable.Items.Add(item);
                }

                con.Close();

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK);
                Application.ExitThread();
            }

            ParentDetailsTable.Items.Clear();

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ParentDetails ORDER BY ParentID ASC", con);

                SqlDataReader datareader = cmd.ExecuteReader();

                while (datareader.Read())
                {
                    ListViewItem item = new ListViewItem(datareader["ParentID"].ToString());
                    item.SubItems.Add(datareader["FirstName"].ToString());
                    item.SubItems.Add(datareader["LastName"].ToString());
                    item.SubItems.Add(datareader["ContactDetail1"].ToString());
                    item.SubItems.Add(datareader["ContactDetail2"].ToString());
                    item.SubItems.Add(datareader["EmergencyContact"].ToString());
                   

                    ParentDetailsTable.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK);
                Application.ExitThread();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void StudentDetailsTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
