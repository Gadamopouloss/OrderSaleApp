using System.Xml.Linq;
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
using System.Windows.Forms.VisualStyles;

namespace OrderApp
{
    public partial class Form1 : Form
    {
        public string connString;
        public int user { get; set; } 


        public Form1()
        {
            InitializeComponent();

        }






        private void ClsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRgster_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.StartPosition = FormStartPosition.CenterParent;

            register.Show();
        }


        private void buttonLgn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text.Trim();
            string password = PassTxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Συμπληρώστε όλα τα πεδία!");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=OrderApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT ID FROM Users WHERE Username = @username AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);
                            this.Hide();

                            FrmMain main = new FrmMain(userId);
                            main.StartPosition = FormStartPosition.CenterParent;
                            main.Show();


                        }
                        else
                        {
                            MessageBox.Show("? Λάθος στοιχεία!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Σφάλμα: " + ex.Message);
                }
            }
        }

    }
}
