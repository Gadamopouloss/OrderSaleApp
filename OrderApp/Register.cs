using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }



        private void ClsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLgn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.Show();


        }

        private void buttonRgster_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text.Trim();
            string password = PassTxt.Text.Trim();
            string email = mailTxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            string connString = "Data Source=192.168.200.12;Initial Catalog=OrderApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Account created successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
