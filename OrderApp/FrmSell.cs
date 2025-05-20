using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class FrmSell : Form
    {
        private int userId;

        public FrmSell(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += FrmSell_Load;
        }

        private void FrmSell_Load(object sender, EventArgs e)
        {
            LoadSalesToGrid();
        }

        private void LoadSalesToGrid()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=OrderApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = "SELECT * FROM SellProd WHERE User_ID = @userId";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Σφάλμα: " + ex.Message);
                }
            }
        }



        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain(userId);
            main.StartPosition = FormStartPosition.CenterParent;
            main.Show();
        }

        private void ClsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTraBTN_Click(object sender, EventArgs e)
        {
            string description = descBox.Text.Trim();
            string priceText = pcBox.Text.Trim();
            string quantityText = quanBox.Text.Trim();

            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(quantityText))
            {
                MessageBox.Show("❌ Συμπλήρωσε όλα τα πεδία.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price) || !int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("🔢 Τιμή και Ποσότητα πρέπει να είναι αριθμοί.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=OrderApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO SellProd (Description, Price, Quantity, User_ID) VALUES (@Description, @Price, @Quantity, @UserId)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadSalesToGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Σφάλμα: " + ex.Message);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain(userId);
            main.StartPosition = FormStartPosition.CenterParent;
            main.Show();
        }
    }
}
