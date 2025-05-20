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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OrderApp
{
    public partial class FrmMain : Form
    {
        private int userId;

        public FrmMain(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += FrmMain_Load;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadUsersToGrid();
        }



        private void LoadUsersToGrid()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=OrderApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = "SELECT * FROM BuyProd WHERE User_ID = @userId";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", userId); // περνάμε το πραγματικό ID

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterParent;
            form1.Show();
        }

        private void ClsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTraBTN_Click(object sender, EventArgs e)
        {
            string description = descBox.Text.Trim();
            string price = PcBox.Text.Trim();
            string quantity = QuanBox.Text.Trim();

            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
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
                    string query = "INSERT INTO BuyProd (Description, Price, Quantity, User_ID) VALUES (@Description, @Price, @Quantity, @UserId)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@UserId", userId); // περνάμε το πραγματικό ID
                        cmd.ExecuteNonQuery();
                    }


                    LoadUsersToGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmSell sell = new FrmSell(userId);
            sell.StartPosition = FormStartPosition.CenterParent;
            sell.Show();
        }

    }
}


