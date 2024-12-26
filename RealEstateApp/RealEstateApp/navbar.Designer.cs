namespace RealEstateApp
{
    partial class navbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(navbar));
            label1 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            MenuItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            MenuItemAdverts = new System.Windows.Forms.ToolStripMenuItem();
            MenuItemFavorites = new System.Windows.Forms.ToolStripMenuItem();
            linkLblCreateAd = new System.Windows.Forms.LinkLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(17, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(269, 39);
            label1.TabIndex = 0;
            label1.Text = "Swe Real Estate";
            label1.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuItemProfile, MenuItemAdverts, MenuItemFavorites });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(212, 106);
            // 
            // MenuItemProfile
            // 
            MenuItemProfile.Name = "MenuItemProfile";
            MenuItemProfile.Size = new System.Drawing.Size(211, 34);
            MenuItemProfile.Text = "Profile";
            MenuItemProfile.Click += MenuItemProfile_Click;
            // 
            // MenuItemAdverts
            // 
            MenuItemAdverts.Name = "MenuItemAdverts";
            MenuItemAdverts.Size = new System.Drawing.Size(211, 34);
            MenuItemAdverts.Text = "Own Adverts";
            MenuItemAdverts.Click += MenuItemAdverts_Click;
            // 
            // MenuItemFavorites
            // 
            MenuItemFavorites.Name = "MenuItemFavorites";
            MenuItemFavorites.Size = new System.Drawing.Size(211, 34);
            MenuItemFavorites.Text = "Favorites";
            MenuItemFavorites.Click += MenuItemFavorites_Click;
            // 
            // linkLblCreateAd
            // 
            linkLblCreateAd.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            linkLblCreateAd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            linkLblCreateAd.AutoSize = true;
            linkLblCreateAd.BackColor = System.Drawing.Color.Transparent;
            linkLblCreateAd.DisabledLinkColor = System.Drawing.Color.White;
            linkLblCreateAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            linkLblCreateAd.ForeColor = System.Drawing.Color.WhiteSmoke;
            linkLblCreateAd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLblCreateAd.LinkColor = System.Drawing.Color.WhiteSmoke;
            linkLblCreateAd.Location = new System.Drawing.Point(37, 27);
            linkLblCreateAd.Name = "linkLblCreateAd";
            linkLblCreateAd.Size = new System.Drawing.Size(126, 29);
            linkLblCreateAd.TabIndex = 4;
            linkLblCreateAd.TabStop = true;
            linkLblCreateAd.Text = "Create Ad";
            linkLblCreateAd.LinkClicked += linkLblCreateAd_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(188, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(45, 45);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(289, 80);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkLblCreateAd);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(1244, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(256, 80);
            panel2.TabIndex = 6;
            // 
            // navbar
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(142, 163, 166);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "navbar";
            Size = new System.Drawing.Size(1500, 80);
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProfile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdverts;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFavorites;
        private System.Windows.Forms.LinkLabel linkLblCreateAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
