namespace OrderApp
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            buttonRgster = new Button();
            labelMail = new Label();
            mailTxt = new TextBox();
            buttonLgn = new Button();
            labelUser = new Label();
            labelPass = new Label();
            PassTxt = new TextBox();
            UsernameTxt = new TextBox();
            label1 = new Label();
            ClsBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ClsBtn).BeginInit();
            SuspendLayout();
            // 
            // buttonRgster
            // 
            buttonRgster.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            buttonRgster.ForeColor = Color.Red;
            buttonRgster.Location = new Point(208, 253);
            buttonRgster.Name = "buttonRgster";
            buttonRgster.Size = new Size(128, 34);
            buttonRgster.TabIndex = 17;
            buttonRgster.Text = "Create Account";
            buttonRgster.UseVisualStyleBackColor = true;
            buttonRgster.Click += buttonRgster_Click;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.BackColor = Color.SandyBrown;
            labelMail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            labelMail.ForeColor = Color.Black;
            labelMail.Location = new Point(28, 191);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(66, 25);
            labelMail.TabIndex = 16;
            labelMail.Text = "E-mail";
            // 
            // mailTxt
            // 
            mailTxt.Location = new Point(164, 196);
            mailTxt.Name = "mailTxt";
            mailTxt.Size = new Size(172, 23);
            mailTxt.TabIndex = 15;
            // 
            // buttonLgn
            // 
            buttonLgn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            buttonLgn.ForeColor = Color.Green;
            buttonLgn.Location = new Point(109, 253);
            buttonLgn.Name = "buttonLgn";
            buttonLgn.Size = new Size(76, 34);
            buttonLgn.TabIndex = 14;
            buttonLgn.Text = "Login";
            buttonLgn.UseVisualStyleBackColor = true;
            buttonLgn.Click += buttonLgn_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.SandyBrown;
            labelUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(28, 99);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(105, 25);
            labelUser.TabIndex = 13;
            labelUser.Text = "User Name";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.BackColor = Color.SandyBrown;
            labelPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            labelPass.ForeColor = Color.Black;
            labelPass.Location = new Point(28, 146);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(91, 25);
            labelPass.TabIndex = 12;
            labelPass.Text = "Password";
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(164, 146);
            PassTxt.Name = "PassTxt";
            PassTxt.Size = new Size(172, 23);
            PassTxt.TabIndex = 11;
            // 
            // UsernameTxt
            // 
            UsernameTxt.Location = new Point(164, 99);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(172, 23);
            UsernameTxt.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(164, 20);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 18;
            label1.Text = "REGISTER";
            // 
            // ClsBtn
            // 
            ClsBtn.Image = (Image)resources.GetObject("ClsBtn.Image");
            ClsBtn.Location = new Point(411, 20);
            ClsBtn.Name = "ClsBtn";
            ClsBtn.Size = new Size(38, 25);
            ClsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ClsBtn.TabIndex = 19;
            ClsBtn.TabStop = false;
            ClsBtn.Click += ClsBtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(461, 341);
            Controls.Add(ClsBtn);
            Controls.Add(label1);
            Controls.Add(buttonRgster);
            Controls.Add(labelMail);
            Controls.Add(mailTxt);
            Controls.Add(buttonLgn);
            Controls.Add(labelUser);
            Controls.Add(labelPass);
            Controls.Add(PassTxt);
            Controls.Add(UsernameTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)ClsBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRgster;
        private Label labelMail;
        private TextBox mailTxt;
        private Button buttonLgn;
        private Label labelUser;
        private Label labelPass;
        private TextBox PassTxt;
        private TextBox UsernameTxt;
        private Label label1;
        private PictureBox ClsBtn;
    }
}