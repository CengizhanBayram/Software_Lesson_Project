namespace RealEstateApp.Forms
{
    partial class OwnAds
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
            dataGridViewAds = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAds).BeginInit();
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
            // dataGridViewAds
            // 
            dataGridViewAds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dataGridViewAds.Location = new System.Drawing.Point(1, 57);
            dataGridViewAds.Name = "dataGridViewAds";
            dataGridViewAds.RowHeadersWidth = 40;
            dataGridViewAds.Size = new System.Drawing.Size(1505, 492);
            dataGridViewAds.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            button1.Location = new System.Drawing.Point(110, 566);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(402, 113);
            button1.TabIndex = 2;
            button1.Text = "Update Ad";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            button2.Location = new System.Drawing.Point(668, 566);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(324, 113);
            button2.TabIndex = 3;
            button2.Text = "Delete Ad";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Column1
            // 
            Column1.FillWeight = 500F;
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 50;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // OwnAds
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1764, 706);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewAds);
            Controls.Add(navbar1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "OwnAds";
            Text = "OwnAds";
            Load += OwnAds_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAds).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private navbar navbar1;
        private System.Windows.Forms.DataGridView dataGridViewAds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}