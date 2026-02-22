namespace AppointmentUI
{
    partial class UserLogin
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
            BtnLogin = new Button();
            groupBox1 = new GroupBox();
            BtnExit = new Button();
            TxtbPassword = new TextBox();
            gsdgdg = new Label();
            TxtbUserName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(211, 246);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(215, 61);
            BtnLogin.TabIndex = 11;
            BtnLogin.Text = "Log In";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnExit);
            groupBox1.Controls.Add(TxtbPassword);
            groupBox1.Controls.Add(gsdgdg);
            groupBox1.Controls.Add(TxtbUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnLogin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Credentials";
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(211, 313);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(215, 61);
            BtnExit.TabIndex = 16;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // TxtbPassword
            // 
            TxtbPassword.Location = new Point(211, 155);
            TxtbPassword.Name = "TxtbPassword";
            TxtbPassword.PasswordChar = '*';
            TxtbPassword.PlaceholderText = "Enter your password";
            TxtbPassword.Size = new Size(325, 34);
            TxtbPassword.TabIndex = 15;
            // 
            // gsdgdg
            // 
            gsdgdg.AutoSize = true;
            gsdgdg.Location = new Point(93, 158);
            gsdgdg.Name = "gsdgdg";
            gsdgdg.Size = new Size(98, 28);
            gsdgdg.TabIndex = 14;
            gsdgdg.Text = "Password:";
            // 
            // TxtbUserName
            // 
            TxtbUserName.Location = new Point(211, 99);
            TxtbUserName.Name = "TxtbUserName";
            TxtbUserName.PlaceholderText = "Enter your user's name";
            TxtbUserName.Size = new Size(325, 34);
            TxtbUserName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 102);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 12;
            label1.Text = "User Name:";
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 423);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "UserLogin";
            Text = "User Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLogin;
        private GroupBox groupBox1;
        private TextBox TxtbPassword;
        private Label gsdgdg;
        private TextBox TxtbUserName;
        private Label label1;
        private Button BtnExit;
    }
}