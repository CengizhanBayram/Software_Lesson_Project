namespace RealEstateApp.Forms
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
            lblFullName = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            linkLblToLogin = new System.Windows.Forms.LinkLabel();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblFullName.Location = new System.Drawing.Point(122, 11);
            lblFullName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(85, 20);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(126, 34);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(220, 32);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(126, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(220, 32);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblEmail.Location = new System.Drawing.Point(122, 78);
            lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(51, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(126, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(220, 32);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblPassword.Location = new System.Drawing.Point(122, 150);
            lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(83, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(126, 247);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new System.Drawing.Size(220, 32);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblConfirmPassword.Location = new System.Drawing.Point(122, 224);
            lblConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(147, 20);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(175, 324);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(129, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLblToLogin
            // 
            linkLblToLogin.AutoSize = true;
            linkLblToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            linkLblToLogin.Location = new System.Drawing.Point(74, 384);
            linkLblToLogin.Name = "linkLblToLogin";
            linkLblToLogin.Size = new System.Drawing.Size(380, 20);
            linkLblToLogin.TabIndex = 9;
            linkLblToLogin.TabStop = true;
            linkLblToLogin.Text = "If you already have an account click here to log in.";
            linkLblToLogin.LinkClicked += linkLblToLogin_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(linkLblToLogin);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblConfirmPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new System.Drawing.Point(640, 183);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(476, 415);
            panel1.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1764, 706);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.LinkLabel linkLblToLogin;
        private System.Windows.Forms.Panel panel1;
    }
}