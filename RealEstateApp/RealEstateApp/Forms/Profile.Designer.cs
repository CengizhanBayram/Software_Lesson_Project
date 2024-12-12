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
            navbar1 = new navbar();
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
            SuspendLayout();
            // 
            // navbar1
            // 
            navbar1.BackColor = System.Drawing.Color.Silver;
            navbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            navbar1.Location = new System.Drawing.Point(-11, -2);
            navbar1.Margin = new System.Windows.Forms.Padding(5);
            navbar1.Name = "navbar1";
            navbar1.Size = new System.Drawing.Size(1920, 60);
            navbar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(524, 164);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 22);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(524, 243);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 22);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(524, 309);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 22);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(757, 309);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            txtPassword.Size = new System.Drawing.Size(258, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(757, 163);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(258, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(757, 236);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(258, 23);
            txtEmail.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            btnUpdate.Location = new System.Drawing.Point(757, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(261, 85);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(524, 393);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(191, 22);
            label4.TabIndex = 10;
            label4.Text = "Account Creation Date";
            // 
            // txtCreate
            // 
            txtCreate.Location = new System.Drawing.Point(757, 390);
            txtCreate.Multiline = true;
            txtCreate.Name = "txtCreate";
            txtCreate.ReadOnly = true;
            txtCreate.Size = new System.Drawing.Size(258, 23);
            txtCreate.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(757, 569);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(261, 39);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Account";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1764, 707);
            Controls.Add(btnDelete);
            Controls.Add(txtCreate);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(navbar1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private navbar navbar1;
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
    }
}