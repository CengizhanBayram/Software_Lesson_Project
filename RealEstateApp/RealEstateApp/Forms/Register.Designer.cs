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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lblFullName = new System.Windows.Forms.Label();
            textBoxFullName = new System.Windows.Forms.TextBox();
            textBoxEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            textBoxPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            lblConfirmPassword = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            linkLblToLogin = new System.Windows.Forms.LinkLabel();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            errorProvider2 = new System.Windows.Forms.ErrorProvider(components);
            errorProvider3 = new System.Windows.Forms.ErrorProvider(components);
            errorProvider4 = new System.Windows.Forms.ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            lblFullName.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblFullName.Location = new System.Drawing.Point(44, 44);
            lblFullName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(100, 22);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new System.Drawing.Point(48, 68);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new System.Drawing.Size(346, 32);
            textBoxFullName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new System.Drawing.Point(48, 153);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(346, 32);
            textBoxEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblEmail.Location = new System.Drawing.Point(44, 129);
            lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(59, 22);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(48, 242);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(346, 32);
            textBoxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblPassword.Location = new System.Drawing.Point(44, 218);
            lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(97, 22);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new System.Drawing.Point(48, 338);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new System.Drawing.Size(346, 32);
            textBoxConfirmPassword.TabIndex = 8;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            lblConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblConfirmPassword.Location = new System.Drawing.Point(44, 314);
            lblConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(172, 22);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(161, 433);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(129, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLblToLogin
            // 
            linkLblToLogin.ActiveLinkColor = System.Drawing.Color.Red;
            linkLblToLogin.AutoSize = true;
            linkLblToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            linkLblToLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            linkLblToLogin.LinkColor = System.Drawing.Color.Red;
            linkLblToLogin.Location = new System.Drawing.Point(45, 551);
            linkLblToLogin.Name = "linkLblToLogin";
            linkLblToLogin.Size = new System.Drawing.Size(408, 22);
            linkLblToLogin.TabIndex = 9;
            linkLblToLogin.TabStop = true;
            linkLblToLogin.Text = "If you already have an account click here to log in.";
            linkLblToLogin.LinkClicked += linkLblToLogin_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 753);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Controls.Add(lblFullName);
            panel2.Controls.Add(textBoxFullName);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(linkLblToLogin);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(textBoxConfirmPassword);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblConfirmPassword);
            panel2.Location = new System.Drawing.Point(571, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(463, 601);
            panel2.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // Register
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.LinkLabel linkLblToLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Panel panel2;
    }
}