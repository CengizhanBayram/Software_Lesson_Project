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
            components = new System.ComponentModel.Container();
            btnTemp = new System.Windows.Forms.Button();
            errorProviderEmail = new System.Windows.Forms.ErrorProvider(components);
            errorProviderPassword = new System.Windows.Forms.ErrorProvider(components);
            panel2 = new System.Windows.Forms.Panel();
            textBoxPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lblEmail = new System.Windows.Forms.Label();
            linkLblToRegister = new System.Windows.Forms.LinkLabel();
            lblPassword = new System.Windows.Forms.Label();
            textBoxEmail = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTemp
            // 
            btnTemp.Location = new System.Drawing.Point(1681, 224);
            btnTemp.Name = "btnTemp";
            btnTemp.Size = new System.Drawing.Size(196, 41);
            btnTemp.TabIndex = 7;
            btnTemp.Text = "Go HomePage";
            btnTemp.UseVisualStyleBackColor = true;
            // 
            // errorProviderEmail
            // 
            errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            errorProviderPassword.ContainerControl = this;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(linkLblToRegister);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(textBoxEmail);
            panel2.Location = new System.Drawing.Point(566, 192);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(402, 368);
            panel2.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxPassword.Location = new System.Drawing.Point(34, 121);
            textBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new System.Drawing.Size(344, 32);
            textBoxPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnLogin.Location = new System.Drawing.Point(136, 208);
            btnLogin.Margin = new System.Windows.Forms.Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(122, 49);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblEmail.Location = new System.Drawing.Point(30, 19);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(51, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // linkLblToRegister
            // 
            linkLblToRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            linkLblToRegister.AutoSize = true;
            linkLblToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            linkLblToRegister.Location = new System.Drawing.Point(14, 314);
            linkLblToRegister.Name = "linkLblToRegister";
            linkLblToRegister.Size = new System.Drawing.Size(379, 20);
            linkLblToRegister.TabIndex = 5;
            linkLblToRegister.TabStop = true;
            linkLblToRegister.Text = "If you don't have an account click here to register.";
            linkLblToRegister.LinkClicked += linkLblToRegister_LinkClicked;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            lblPassword.Location = new System.Drawing.Point(30, 96);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(83, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxEmail.Location = new System.Drawing.Point(34, 44);
            textBoxEmail.Margin = new System.Windows.Forms.Padding(5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(344, 32);
            textBoxEmail.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 753);
            panel1.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(btnTemp);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.LinkLabel linkLblToRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel1;
    }
}