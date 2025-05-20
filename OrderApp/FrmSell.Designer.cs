namespace OrderApp
{
    partial class FrmSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSell));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            AddTraBTN = new Button();
            label5 = new Label();
            quanBox = new TextBox();
            priceTxt = new Label();
            pcBox = new TextBox();
            DescTXT = new Label();
            descBox = new TextBox();
            ClsBtn = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClsBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.Location = new Point(213, 365);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 23;
            label2.Text = "ADD A SELL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(213, 21);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 22;
            label1.Text = "LAST SELLS";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(616, 271);
            dataGridView1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.Controls.Add(AddTraBTN);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(quanBox);
            panel2.Controls.Add(priceTxt);
            panel2.Controls.Add(pcBox);
            panel2.Controls.Add(DescTXT);
            panel2.Controls.Add(descBox);
            panel2.Location = new Point(12, 407);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 152);
            panel2.TabIndex = 21;
            // 
            // AddTraBTN
            // 
            AddTraBTN.BackColor = Color.YellowGreen;
            AddTraBTN.FlatStyle = FlatStyle.Popup;
            AddTraBTN.Location = new Point(411, 102);
            AddTraBTN.Name = "AddTraBTN";
            AddTraBTN.Size = new Size(101, 22);
            AddTraBTN.TabIndex = 6;
            AddTraBTN.Text = "Buy Product";
            AddTraBTN.UseVisualStyleBackColor = false;
            AddTraBTN.Click += AddTraBTN_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label5.Location = new Point(304, 43);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "Quantity";
            // 
            // quanBox
            // 
            quanBox.BackColor = Color.LemonChiffon;
            quanBox.Location = new Point(388, 43);
            quanBox.Multiline = true;
            quanBox.Name = "quanBox";
            quanBox.Size = new Size(124, 20);
            quanBox.TabIndex = 4;
            // 
            // priceTxt
            // 
            priceTxt.AutoSize = true;
            priceTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            priceTxt.Location = new Point(20, 91);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(41, 20);
            priceTxt.TabIndex = 3;
            priceTxt.Text = "Price";
            // 
            // pcBox
            // 
            pcBox.BackColor = Color.LemonChiffon;
            pcBox.Location = new Point(125, 91);
            pcBox.Multiline = true;
            pcBox.Name = "pcBox";
            pcBox.Size = new Size(124, 20);
            pcBox.TabIndex = 2;
            // 
            // DescTXT
            // 
            DescTXT.AutoSize = true;
            DescTXT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            DescTXT.Location = new Point(20, 43);
            DescTXT.Name = "DescTXT";
            DescTXT.Size = new Size(85, 20);
            DescTXT.TabIndex = 1;
            DescTXT.Text = "Description";
            // 
            // descBox
            // 
            descBox.BackColor = Color.LemonChiffon;
            descBox.Location = new Point(125, 43);
            descBox.Multiline = true;
            descBox.Name = "descBox";
            descBox.Size = new Size(124, 20);
            descBox.TabIndex = 0;
            // 
            // ClsBtn
            // 
            ClsBtn.Image = (Image)resources.GetObject("ClsBtn.Image");
            ClsBtn.Location = new Point(608, 3);
            ClsBtn.Name = "ClsBtn";
            ClsBtn.Size = new Size(38, 25);
            ClsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ClsBtn.TabIndex = 20;
            ClsBtn.TabStop = false;
            ClsBtn.Click += ClsBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(562, 380);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go To Orders";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmSell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(647, 562);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(ClsBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSell";
            Text = "FrmSell";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClsBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button AddTraBTN;
        private Label label5;
        private TextBox quanBox;
        private Label priceTxt;
        private TextBox pcBox;
        private Label DescTXT;
        private TextBox descBox;
        private PictureBox ClsBtn;
        private LinkLabel linkLabel1;
    }
}