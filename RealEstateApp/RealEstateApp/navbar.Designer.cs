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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdverts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLblCreateAd = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Swe Real Estate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProfile,
            this.MenuItemAdverts,
            this.MenuItemFavorites});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 106);
            // 
            // MenuItemProfile
            // 
            this.MenuItemProfile.Name = "MenuItemProfile";
            this.MenuItemProfile.Size = new System.Drawing.Size(211, 34);
            this.MenuItemProfile.Text = "Profile";
            this.MenuItemProfile.Click += new System.EventHandler(this.MenuItemProfile_Click);
            // 
            // MenuItemAdverts
            // 
            this.MenuItemAdverts.Name = "MenuItemAdverts";
            this.MenuItemAdverts.Size = new System.Drawing.Size(211, 34);
            this.MenuItemAdverts.Text = "Own Adverts";
            this.MenuItemAdverts.Click += new System.EventHandler(this.MenuItemAdverts_Click);
            // 
            // MenuItemFavorites
            // 
            this.MenuItemFavorites.Name = "MenuItemFavorites";
            this.MenuItemFavorites.Size = new System.Drawing.Size(211, 34);
            this.MenuItemFavorites.Text = "Favorites";
            this.MenuItemFavorites.Click += new System.EventHandler(this.MenuItemFavorites_Click);
            // 
            // linkLblCreateAd
            // 
            this.linkLblCreateAd.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLblCreateAd.AutoSize = true;
            this.linkLblCreateAd.BackColor = System.Drawing.Color.Silver;
            this.linkLblCreateAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblCreateAd.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLblCreateAd.LinkColor = System.Drawing.Color.Black;
            this.linkLblCreateAd.Location = new System.Drawing.Point(1312, 18);
            this.linkLblCreateAd.Name = "linkLblCreateAd";
            this.linkLblCreateAd.Size = new System.Drawing.Size(126, 29);
            this.linkLblCreateAd.TabIndex = 4;
            this.linkLblCreateAd.TabStop = true;
            this.linkLblCreateAd.Text = "Create Ad";
            this.linkLblCreateAd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCreateAd_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::RealEstateApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(1453, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // navbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.linkLblCreateAd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "navbar";
            this.Size = new System.Drawing.Size(1920, 60);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
