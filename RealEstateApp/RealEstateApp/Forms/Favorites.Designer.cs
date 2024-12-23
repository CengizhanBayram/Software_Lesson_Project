using System;
using System.Windows.Forms;

namespace RealEstateApp.Forms
{
    partial class Favorites
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
            panel1 = new Panel();
            flowLayoutPanelFavorites = new FlowLayoutPanel();
            panel3 = new Panel();
            navbar1 = new navbar();
            panelFaves = new Panel();
            panel2 = new Panel();
            flowLayoutPanelFaves = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanelFavorites);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(navbar1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 80);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanelFavorites
            // 
            flowLayoutPanelFavorites.BackColor = System.Drawing.Color.DarkGray;
            flowLayoutPanelFavorites.Location = new System.Drawing.Point(0, 86);
            flowLayoutPanelFavorites.Name = "flowLayoutPanelFavorites";
            flowLayoutPanelFavorites.Size = new System.Drawing.Size(1482, 751);
            flowLayoutPanelFavorites.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new System.Drawing.Point(134, 86);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(250, 125);
            panel3.TabIndex = 2;
            // 
            // navbar1
            // 
            navbar1.BackColor = System.Drawing.Color.Silver;
            navbar1.Dock = DockStyle.Fill;
            navbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            navbar1.Location = new System.Drawing.Point(0, 0);
            navbar1.Margin = new Padding(5);
            navbar1.Name = "navbar1";
            navbar1.Size = new System.Drawing.Size(1482, 80);
            navbar1.TabIndex = 0;
            // 
            // panelFaves
            // 
            panelFaves.AutoScroll = true;
            panelFaves.AutoSize = true;
            panelFaves.BorderStyle = BorderStyle.FixedSingle;
            panelFaves.Dock = DockStyle.Top;
            panelFaves.Location = new System.Drawing.Point(0, 0);
            panelFaves.Name = "panelFaves";
            panelFaves.Size = new System.Drawing.Size(1482, 2);
            panelFaves.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            panel2.Controls.Add(flowLayoutPanelFaves);
            panel2.Controls.Add(panelFaves);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1482, 753);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanelFaves
            // 
            flowLayoutPanelFaves.AutoScroll = true;
            flowLayoutPanelFaves.BackColor = System.Drawing.Color.Violet;
            flowLayoutPanelFaves.Location = new System.Drawing.Point(69, 103);
            flowLayoutPanelFaves.Name = "flowLayoutPanelFaves";
            flowLayoutPanelFaves.Size = new System.Drawing.Size(1252, 670);
            flowLayoutPanelFaves.TabIndex = 1;
            // 
            // Favorites
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new Padding(0);
            Name = "Favorites";
            Text = "Favorites";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void flowLayoutPanelFaves_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private navbar navbar1;
        private FlowLayoutPanel flowLayoutPanelFavorites;
        private Panel panel3;
        private Panel panelFaves;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelFaves;
    }
}