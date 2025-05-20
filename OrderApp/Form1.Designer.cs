namespace OrderApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            UsernameTxt = new TextBox();
            PassTxt = new TextBox();
            labelPass = new Label();
            labelUser = new Label();
            buttonLgn = new Button();
            buttonRgster = new Button();
            imageList1 = new ImageList(components);
            ClsBtn = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ClsBtn).BeginInit();
            SuspendLayout();
            // 
            // UsernameTxt
            // 
            UsernameTxt.Location = new Point(167, 108);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(172, 23);
            UsernameTxt.TabIndex = 0;
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(167, 155);
            PassTxt.Name = "PassTxt";
            PassTxt.Size = new Size(172, 23);
            PassTxt.TabIndex = 1;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.BackColor = Color.SandyBrown;
            labelPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            labelPass.ForeColor = Color.Black;
            labelPass.Location = new Point(31, 155);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(91, 25);
            labelPass.TabIndex = 4;
            labelPass.Text = "Password";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.SandyBrown;
            labelUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(31, 108);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(105, 25);
            labelUser.TabIndex = 5;
            labelUser.Text = "User Name";
            // 
            // buttonLgn
            // 
            buttonLgn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            buttonLgn.ForeColor = Color.Green;
            buttonLgn.Location = new Point(263, 231);
            buttonLgn.Name = "buttonLgn";
            buttonLgn.Size = new Size(76, 34);
            buttonLgn.TabIndex = 6;
            buttonLgn.Text = "Login";
            buttonLgn.UseVisualStyleBackColor = true;
            buttonLgn.Click += buttonLgn_Click;
            // 
            // buttonRgster
            // 
            buttonRgster.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            buttonRgster.ForeColor = Color.Red;
            buttonRgster.Location = new Point(167, 231);
            buttonRgster.Name = "buttonRgster";
            buttonRgster.Size = new Size(72, 34);
            buttonRgster.TabIndex = 9;
            buttonRgster.Text = "Register";
            buttonRgster.UseVisualStyleBackColor = true;
            buttonRgster.Click += buttonRgster_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // ClsBtn
            // 
            ClsBtn.Image = (Image)resources.GetObject("ClsBtn.Image");
            ClsBtn.Location = new Point(373, 12);
            ClsBtn.Name = "ClsBtn";
            ClsBtn.Size = new Size(38, 25);
            ClsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ClsBtn.TabIndex = 12;
            ClsBtn.TabStop = false;
            ClsBtn.Click += ClsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(167, 12);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 19;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(423, 311);
            Controls.Add(label1);
            Controls.Add(ClsBtn);
            Controls.Add(buttonRgster);
            Controls.Add(buttonLgn);
            Controls.Add(labelUser);
            Controls.Add(labelPass);
            Controls.Add(PassTxt);
            Controls.Add(UsernameTxt);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)ClsBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTxt;
        private TextBox PassTxt;
        private Label labelPass;
        private Label labelUser;
        private Button buttonLgn;
        private Button buttonRgster;
        private ImageList imageList1;
        private PictureBox ClsBtn;
        private Label label1;
    }
}
