namespace RealEstateApp.Forms
{
    partial class Login
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
            btnLogin = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            linkLblToRegister = new System.Windows.Forms.LinkLabel();
            panel1 = new System.Windows.Forms.Panel();
            btnTemp = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(166, 220);
            btnLogin.Margin = new System.Windows.Forms.Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(122, 49);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(102, 77);
            txtEmail.Margin = new System.Windows.Forms.Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(245, 32);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(102, 154);
            txtPassword.Margin = new System.Windows.Forms.Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(245, 32);
            txtPassword.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblEmail.Location = new System.Drawing.Point(98, 52);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(51, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblPassword.Location = new System.Drawing.Point(98, 129);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(83, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // linkLblToRegister
            // 
            linkLblToRegister.AutoSize = true;
            linkLblToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            linkLblToRegister.Location = new System.Drawing.Point(47, 312);
            linkLblToRegister.Name = "linkLblToRegister";
            linkLblToRegister.Size = new System.Drawing.Size(379, 20);
            linkLblToRegister.TabIndex = 5;
            linkLblToRegister.TabStop = true;
            linkLblToRegister.Text = "If you don't have an account click here to register.";
            linkLblToRegister.LinkClicked += linkLblToRegister_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(linkLblToRegister);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new System.Drawing.Point(339, 70);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(503, 408);
            panel1.TabIndex = 6;
            // 
            // btnTemp
            // 
            btnTemp.Location = new System.Drawing.Point(1681, 224);
            btnTemp.Name = "btnTemp";
            btnTemp.Size = new System.Drawing.Size(196, 41);
            btnTemp.TabIndex = 7;
            btnTemp.Text = "Go HomePage";
            btnTemp.UseVisualStyleBackColor = true;
            btnTemp.Click += btnTemp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1764, 706);
            Controls.Add(btnTemp);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel linkLblToRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemp;
    }
}