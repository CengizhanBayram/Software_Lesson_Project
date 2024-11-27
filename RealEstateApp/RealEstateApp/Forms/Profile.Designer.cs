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
            this.navbar1 = new RealEstateApp.navbar();
            this.SuspendLayout();
            // 
            // navbar1
            // 
            this.navbar1.BackColor = System.Drawing.Color.Silver;
            this.navbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navbar1.Location = new System.Drawing.Point(-11, -2);
            this.navbar1.Margin = new System.Windows.Forms.Padding(5);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(1920, 60);
            this.navbar1.TabIndex = 0;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 773);
            this.Controls.Add(this.navbar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);

        }

        #endregion

        private navbar navbar1;
    }
}