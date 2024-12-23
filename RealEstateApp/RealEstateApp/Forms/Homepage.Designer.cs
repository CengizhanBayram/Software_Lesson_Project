namespace RealEstateApp.Forms
{
    partial class Homepage
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
            panel1 = new System.Windows.Forms.Panel();
            navbar1 = new navbar();
            panel3 = new System.Windows.Forms.Panel();
            flowLayoutPanelAds = new System.Windows.Forms.FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(navbar1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 80);
            panel1.TabIndex = 0;
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
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            panel3.Dock = System.Windows.Forms.DockStyle.Left;
            panel3.Location = new System.Drawing.Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(289, 673);
            panel3.TabIndex = 2;
            // 
            // flowLayoutPanelAds
            // 
            flowLayoutPanelAds.AllowDrop = true;
            flowLayoutPanelAds.AutoScroll = true;
            flowLayoutPanelAds.BackColor = System.Drawing.Color.DarkGray;
            flowLayoutPanelAds.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanelAds.Location = new System.Drawing.Point(289, 80);
            flowLayoutPanelAds.Name = "flowLayoutPanelAds";
            flowLayoutPanelAds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            flowLayoutPanelAds.Size = new System.Drawing.Size(1193, 673);
            flowLayoutPanelAds.TabIndex = 2;
            // 
            // Homepage
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(flowLayoutPanelAds);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private navbar navbar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAds;
    }
}