namespace RealEstateApp.Forms
{
    partial class AdDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdDetails));
            navbar1 = new navbar();
            panel1 = new System.Windows.Forms.Panel();
            panelAdDetails = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            textBoxDescription = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            labelDbFloorNo = new System.Windows.Forms.Label();
            labelDbPrice = new System.Windows.Forms.Label();
            labelLocation = new System.Windows.Forms.Label();
            labelDbSquareMeters = new System.Windows.Forms.Label();
            labelDbElevator = new System.Windows.Forms.Label();
            labelDbLocation = new System.Windows.Forms.Label();
            labelDbRoomCount = new System.Windows.Forms.Label();
            labelRooms = new System.Windows.Forms.Label();
            labelM2 = new System.Windows.Forms.Label();
            labelFloorNo = new System.Windows.Forms.Label();
            labelElevator = new System.Windows.Forms.Label();
            labelPrice = new System.Windows.Forms.Label();
            buttonBack = new System.Windows.Forms.Button();
            buttonFave = new System.Windows.Forms.Button();
            flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            labelTitle = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panelAdDetails.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // navbar1
            // 
            navbar1.BackColor = System.Drawing.Color.Silver;
            navbar1.BackgroundImage = (System.Drawing.Image)resources.GetObject("navbar1.BackgroundImage");
            navbar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            navbar1.Dock = System.Windows.Forms.DockStyle.Top;
            navbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            navbar1.Location = new System.Drawing.Point(0, 0);
            navbar1.Margin = new System.Windows.Forms.Padding(5);
            navbar1.Name = "navbar1";
            navbar1.Size = new System.Drawing.Size(1482, 100);
            navbar1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelAdDetails);
            panel1.Controls.Add(navbar1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 753);
            panel1.TabIndex = 1;
            // 
            // panelAdDetails
            // 
            panelAdDetails.AutoScroll = true;
            panelAdDetails.BackColor = System.Drawing.Color.FromArgb(0, 41, 85);
            panelAdDetails.Controls.Add(panel2);
            panelAdDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            panelAdDetails.Location = new System.Drawing.Point(0, 100);
            panelAdDetails.Name = "panelAdDetails";
            panelAdDetails.Size = new System.Drawing.Size(1482, 653);
            panelAdDetails.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.Controls.Add(textBoxDescription);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(buttonBack);
            panel2.Controls.Add(buttonFave);
            panel2.Controls.Add(flowLayoutPanelPhotos);
            panel2.Controls.Add(labelTitle);
            panel2.Location = new System.Drawing.Point(25, 21);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1365, 586);
            panel2.TabIndex = 17;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBoxDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            textBoxDescription.Location = new System.Drawing.Point(834, 81);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxDescription.Size = new System.Drawing.Size(513, 206);
            textBoxDescription.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Control;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(labelDbFloorNo);
            panel3.Controls.Add(labelDbPrice);
            panel3.Controls.Add(labelLocation);
            panel3.Controls.Add(labelDbSquareMeters);
            panel3.Controls.Add(labelDbElevator);
            panel3.Controls.Add(labelDbLocation);
            panel3.Controls.Add(labelDbRoomCount);
            panel3.Controls.Add(labelRooms);
            panel3.Controls.Add(labelM2);
            panel3.Controls.Add(labelFloorNo);
            panel3.Controls.Add(labelElevator);
            panel3.Controls.Add(labelPrice);
            panel3.Location = new System.Drawing.Point(834, 293);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(513, 282);
            panel3.TabIndex = 19;
            // 
            // labelDbFloorNo
            // 
            labelDbFloorNo.BackColor = System.Drawing.Color.Transparent;
            labelDbFloorNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            labelDbFloorNo.ForeColor = System.Drawing.Color.Black;
            labelDbFloorNo.Location = new System.Drawing.Point(330, 193);
            labelDbFloorNo.Name = "labelDbFloorNo";
            labelDbFloorNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelDbFloorNo.Size = new System.Drawing.Size(120, 23);
            labelDbFloorNo.TabIndex = 13;
            labelDbFloorNo.Text = "label8";
            labelDbFloorNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDbPrice
            // 
            labelDbPrice.BackColor = System.Drawing.Color.Transparent;
            labelDbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            labelDbPrice.ForeColor = System.Drawing.Color.Black;
            labelDbPrice.Location = new System.Drawing.Point(330, 17);
            labelDbPrice.Name = "labelDbPrice";
            labelDbPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelDbPrice.Size = new System.Drawing.Size(120, 23);
            labelDbPrice.TabIndex = 9;
            labelDbPrice.Text = "label6";
            labelDbPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            labelLocation.ForeColor = System.Drawing.Color.Black;
            labelLocation.Location = new System.Drawing.Point(44, 101);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new System.Drawing.Size(85, 25);
            labelLocation.TabIndex = 8;
            labelLocation.Text = "Location";
            // 
            // labelDbSquareMeters
            // 
            labelDbSquareMeters.BackColor = System.Drawing.Color.Transparent;
            labelDbSquareMeters.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            labelDbSquareMeters.ForeColor = System.Drawing.Color.Black;
            labelDbSquareMeters.Location = new System.Drawing.Point(330, 60);
            labelDbSquareMeters.Name = "labelDbSquareMeters";
            labelDbSquareMeters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelDbSquareMeters.Size = new System.Drawing.Size(120, 23);
            labelDbSquareMeters.TabIndex = 10;
            labelDbSquareMeters.Text = "label7";
            labelDbSquareMeters.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDbElevator
            // 
            labelDbElevator.BackColor = System.Drawing.Color.Transparent;
            labelDbElevator.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            labelDbElevator.ForeColor = System.Drawing.Color.Black;
            labelDbElevator.Location = new System.Drawing.Point(330, 238);
            labelDbElevator.Name = "labelDbElevator";
            labelDbElevator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelDbElevator.Size = new System.Drawing.Size(120, 23);
            labelDbElevator.TabIndex = 16;
            labelDbElevator.Text = "label2";
            labelDbElevator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDbLocation
            // 
            labelDbLocation.BackColor = System.Drawing.Color.Transparent;
            labelDbLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            labelDbLocation.ForeColor = System.Drawing.Color.Black;
            labelDbLocation.Location = new System.Drawing.Point(330, 103);
            labelDbLocation.Name = "labelDbLocation";
            labelDbLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelDbLocation.Size = new System.Drawing.Size(121, 23);
            labelDbLocation.TabIndex = 7;
            labelDbLocation.Text = "label4";
            labelDbLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDbRoomCount
            // 
            labelDbRoomCount.BackColor = System.Drawing.Color.Transparent;
            labelDbRoomCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            labelDbRoomCount.ForeColor = System.Drawing.Color.Black;
            labelDbRoomCount.Location = new System.Drawing.Point(330, 150);
            labelDbRoomCount.Name = "labelDbRoomCount";
            labelDbRoomCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelDbRoomCount.Size = new System.Drawing.Size(120, 23);
            labelDbRoomCount.TabIndex = 15;
            labelDbRoomCount.Text = "label3";
            labelDbRoomCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelRooms
            // 
            labelRooms.AutoSize = true;
            labelRooms.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            labelRooms.ForeColor = System.Drawing.Color.Black;
            labelRooms.Location = new System.Drawing.Point(47, 150);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new System.Drawing.Size(118, 25);
            labelRooms.TabIndex = 11;
            labelRooms.Text = "Room Count";
            // 
            // labelM2
            // 
            labelM2.AutoSize = true;
            labelM2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            labelM2.ForeColor = System.Drawing.Color.Black;
            labelM2.Location = new System.Drawing.Point(47, 58);
            labelM2.Name = "labelM2";
            labelM2.Size = new System.Drawing.Size(130, 25);
            labelM2.TabIndex = 6;
            labelM2.Text = "SquareMeters";
            // 
            // labelFloorNo
            // 
            labelFloorNo.AutoSize = true;
            labelFloorNo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            labelFloorNo.ForeColor = System.Drawing.Color.Black;
            labelFloorNo.Location = new System.Drawing.Point(47, 193);
            labelFloorNo.Name = "labelFloorNo";
            labelFloorNo.Size = new System.Drawing.Size(129, 25);
            labelFloorNo.TabIndex = 14;
            labelFloorNo.Text = "Floor Number";
            // 
            // labelElevator
            // 
            labelElevator.AutoSize = true;
            labelElevator.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            labelElevator.ForeColor = System.Drawing.Color.Black;
            labelElevator.Location = new System.Drawing.Point(47, 238);
            labelElevator.Name = "labelElevator";
            labelElevator.Size = new System.Drawing.Size(82, 25);
            labelElevator.TabIndex = 12;
            labelElevator.Text = "Elevator";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            labelPrice.ForeColor = System.Drawing.Color.Black;
            labelPrice.Location = new System.Drawing.Point(47, 17);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(54, 25);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Price";
            // 
            // buttonBack
            // 
            buttonBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            buttonBack.Location = new System.Drawing.Point(1248, 21);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(99, 44);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonFave
            // 
            buttonFave.BackColor = System.Drawing.Color.Transparent;
            buttonFave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            buttonFave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonFave.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonFave.ForeColor = System.Drawing.Color.WhiteSmoke;
            buttonFave.Location = new System.Drawing.Point(1165, 23);
            buttonFave.Name = "buttonFave";
            buttonFave.Size = new System.Drawing.Size(54, 42);
            buttonFave.TabIndex = 18;
            buttonFave.UseVisualStyleBackColor = false;
            buttonFave.Click += buttonFave_Click;
            // 
            // flowLayoutPanelPhotos
            // 
            flowLayoutPanelPhotos.AutoScroll = true;
            flowLayoutPanelPhotos.BackColor = System.Drawing.Color.FromArgb(0, 41, 85);
            flowLayoutPanelPhotos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelPhotos.Location = new System.Drawing.Point(52, 81);
            flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
            flowLayoutPanelPhotos.Size = new System.Drawing.Size(750, 494);
            flowLayoutPanelPhotos.TabIndex = 17;
            flowLayoutPanelPhotos.WrapContents = false;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = System.Drawing.Color.Transparent;
            labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            labelTitle.Location = new System.Drawing.Point(52, 23);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(745, 55);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "TITLE";
            // 
            // AdDetails
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Name = "AdDetails";
            Text = "AdDetails";
            panel1.ResumeLayout(false);
            panelAdDetails.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private navbar navbar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAdDetails;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDbElevator;
        private System.Windows.Forms.Label labelDbRoomCount;
        private System.Windows.Forms.Label labelFloorNo;
        private System.Windows.Forms.Label labelDbFloorNo;
        private System.Windows.Forms.Label labelElevator;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelDbSquareMeters;
        private System.Windows.Forms.Label labelDbPrice;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDbLocation;
        private System.Windows.Forms.Label labelM2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.Button buttonFave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}