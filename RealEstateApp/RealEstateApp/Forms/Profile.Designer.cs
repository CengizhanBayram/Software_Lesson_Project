namespace RealEstateApp.Forms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            txtCreate = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            navbar1 = new navbar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(52, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 26);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            label2.Location = new System.Drawing.Point(52, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 26);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            label3.Location = new System.Drawing.Point(52, 174);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 26);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtPassword.Location = new System.Drawing.Point(57, 203);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            txtPassword.Size = new System.Drawing.Size(314, 29);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtUsername.Location = new System.Drawing.Point(57, 44);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(314, 29);
            txtUsername.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtEmail.Location = new System.Drawing.Point(57, 124);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(314, 29);
            txtEmail.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2000008F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            btnUpdate.Location = new System.Drawing.Point(234, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(137, 39);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            label4.Location = new System.Drawing.Point(54, 250);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(231, 26);
            label4.TabIndex = 10;
            label4.Text = "Account Creation Date";
            // 
            // txtCreate
            // 
            txtCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            txtCreate.Location = new System.Drawing.Point(57, 279);
            txtCreate.Multiline = true;
            txtCreate.Name = "txtCreate";
            txtCreate.ReadOnly = true;
            txtCreate.Size = new System.Drawing.Size(314, 29);
            txtCreate.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Location = new System.Drawing.Point(57, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(137, 37);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(navbar1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 80);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(panel3);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1482, 673);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel3.BackColor = System.Drawing.Color.Transparent;
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtCreate);
            panel3.Location = new System.Drawing.Point(556, 96);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(420, 434);
            panel3.TabIndex = 16;
            // 
            // navbar1
            // 
            navbar1.BackColor = System.Drawing.Color.FromArgb(142, 163, 166);
            navbar1.BackgroundImage = (System.Drawing.Image)resources.GetObject("navbar1.BackgroundImage");
            navbar1.Dock = System.Windows.Forms.DockStyle.Fill;
            navbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            navbar1.Location = new System.Drawing.Point(0, 0);
            navbar1.Margin = new System.Windows.Forms.Padding(5);
            navbar1.Name = "navbar1";
            navbar1.Size = new System.Drawing.Size(1482, 80);
            navbar1.TabIndex = 0;
            // 
            // Profile
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private navbar navbar1;
    }
}