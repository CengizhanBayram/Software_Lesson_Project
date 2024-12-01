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
            label1 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            MenuItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            MenuItemAdverts = new System.Windows.Forms.ToolStripMenuItem();
            MenuItemFavorites = new System.Windows.Forms.ToolStripMenuItem();
            linkLblCreateAd = new System.Windows.Forms.LinkLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Silver;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label1.Location = new System.Drawing.Point(24, 18);
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
            linkLblCreateAd.ActiveLinkColor = System.Drawing.Color.Black;
            linkLblCreateAd.AutoSize = true;
            linkLblCreateAd.BackColor = System.Drawing.Color.Silver;
            linkLblCreateAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            linkLblCreateAd.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            linkLblCreateAd.LinkColor = System.Drawing.Color.Black;
            linkLblCreateAd.Location = new System.Drawing.Point(1257, 23);
            linkLblCreateAd.Name = "linkLblCreateAd";
            linkLblCreateAd.Size = new System.Drawing.Size(126, 29);
            linkLblCreateAd.TabIndex = 4;
            linkLblCreateAd.TabStop = true;
            linkLblCreateAd.Text = "Create Ad";
            linkLblCreateAd.LinkClicked += linkLblCreateAd_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Silver;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new System.Drawing.Point(1424, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(45, 45);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // navbar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            Controls.Add(linkLblCreateAd);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "navbar";
            Size = new System.Drawing.Size(1782, 60);
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProfile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdverts;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFavorites;
        private System.Windows.Forms.LinkLabel linkLblCreateAd;
    }
}
