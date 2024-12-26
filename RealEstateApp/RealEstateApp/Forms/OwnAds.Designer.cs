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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnAds));
            dataGridViewAds = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            navbar1 = new navbar();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAds).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAds
            // 
            dataGridViewAds.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            dataGridViewAds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewAds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dataGridViewAds.Location = new System.Drawing.Point(105, 31);
            dataGridViewAds.Name = "dataGridViewAds";
            dataGridViewAds.RowHeadersWidth = 40;
            dataGridViewAds.Size = new System.Drawing.Size(1232, 498);
            dataGridViewAds.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.FillWeight = 500F;
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 50;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 1190;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            button1.Location = new System.Drawing.Point(1168, 563);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(169, 45);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            button2.ForeColor = System.Drawing.Color.Red;
            button2.Location = new System.Drawing.Point(981, 563);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(155, 45);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(navbar1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 80);
            panel1.TabIndex = 4;
            // 
            // navbar1
            // 
            navbar1.BackColor = System.Drawing.Color.Silver;
            navbar1.Dock = System.Windows.Forms.DockStyle.Fill;
            navbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            navbar1.Location = new System.Drawing.Point(0, 0);
            navbar1.Margin = new System.Windows.Forms.Padding(5);
            navbar1.Name = "navbar1";
            navbar1.Size = new System.Drawing.Size(1482, 80);
            navbar1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dataGridViewAds);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1482, 673);
            panel2.TabIndex = 5;
            // 
            // OwnAds
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "OwnAds";
            Text = "OwnAds";
            Load += OwnAds_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAds).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.Panel panel1;
        private navbar navbar1;
        private System.Windows.Forms.Panel panel2;
    }
}