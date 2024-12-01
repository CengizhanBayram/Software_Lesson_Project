namespace RealEstateApp.Forms
{
    partial class CreateAd
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
            panel5 = new System.Windows.Forms.Panel();
            btnSaveAdvert = new System.Windows.Forms.Button();
            lblElevator = new System.Windows.Forms.Label();
            comboBoxElevator = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            lblPhotos = new System.Windows.Forms.Label();
            flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            btnUploadPhoto = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            textBoxTitle = new System.Windows.Forms.TextBox();
            lblTitle = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            lblPrice = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            comboBoxFloorNo = new System.Windows.Forms.ComboBox();
            comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            lblFloorNo = new System.Windows.Forms.Label();
            lblRoomNumber = new System.Windows.Forms.Label();
            textBoxSquareMeters = new System.Windows.Forms.TextBox();
            lblLocation = new System.Windows.Forms.Label();
            comboBoxLocation = new System.Windows.Forms.ComboBox();
            lblSquareMeters = new System.Windows.Forms.Label();
            navbar1 = new navbar();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1494, 623);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSaveAdvert);
            panel5.Controls.Add(lblElevator);
            panel5.Controls.Add(comboBoxElevator);
            panel5.Location = new System.Drawing.Point(119, 1104);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1096, 235);
            panel5.TabIndex = 17;
            // 
            // btnSaveAdvert
            // 
            btnSaveAdvert.Location = new System.Drawing.Point(902, 112);
            btnSaveAdvert.Name = "btnSaveAdvert";
            btnSaveAdvert.Size = new System.Drawing.Size(135, 36);
            btnSaveAdvert.TabIndex = 12;
            btnSaveAdvert.Text = "Save";
            btnSaveAdvert.UseVisualStyleBackColor = true;
            btnSaveAdvert.Click += btnSaveAdvert_Click;
            // 
            // lblElevator
            // 
            lblElevator.AutoSize = true;
            lblElevator.Location = new System.Drawing.Point(199, 9);
            lblElevator.Name = "lblElevator";
            lblElevator.Size = new System.Drawing.Size(92, 26);
            lblElevator.TabIndex = 10;
            lblElevator.Text = "Elevator";
            // 
            // comboBoxElevator
            // 
            comboBoxElevator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxElevator.FormattingEnabled = true;
            comboBoxElevator.Location = new System.Drawing.Point(199, 38);
            comboBoxElevator.Name = "comboBoxElevator";
            comboBoxElevator.Size = new System.Drawing.Size(838, 34);
            comboBoxElevator.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPhotos);
            panel2.Controls.Add(flowLayoutPanelPhotos);
            panel2.Controls.Add(btnUploadPhoto);
            panel2.Location = new System.Drawing.Point(119, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1096, 335);
            panel2.TabIndex = 13;
            // 
            // lblPhotos
            // 
            lblPhotos.AutoSize = true;
            lblPhotos.Location = new System.Drawing.Point(200, 14);
            lblPhotos.Name = "lblPhotos";
            lblPhotos.Size = new System.Drawing.Size(80, 26);
            lblPhotos.TabIndex = 0;
            lblPhotos.Text = "Photos";
            // 
            // flowLayoutPanelPhotos
            // 
            flowLayoutPanelPhotos.Location = new System.Drawing.Point(200, 43);
            flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
            flowLayoutPanelPhotos.Size = new System.Drawing.Size(825, 235);
            flowLayoutPanelPhotos.TabIndex = 2;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new System.Drawing.Point(869, 288);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new System.Drawing.Size(156, 40);
            btnUploadPhoto.TabIndex = 4;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxTitle);
            panel4.Controls.Add(lblTitle);
            panel4.Controls.Add(lblDescription);
            panel4.Controls.Add(richTextBoxDescription);
            panel4.Controls.Add(textBoxPrice);
            panel4.Controls.Add(lblPrice);
            panel4.Location = new System.Drawing.Point(119, 341);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1096, 349);
            panel4.TabIndex = 15;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new System.Drawing.Point(200, 38);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new System.Drawing.Size(838, 32);
            textBoxTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(200, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(52, 26);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(200, 111);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(121, 26);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new System.Drawing.Point(200, 140);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new System.Drawing.Size(838, 107);
            richTextBoxDescription.TabIndex = 7;
            richTextBoxDescription.Text = "";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(199, 314);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(838, 32);
            textBoxPrice.TabIndex = 8;
            textBoxPrice.TextChanged += textBox1_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(199, 285);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(106, 26);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price (TL)";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBoxFloorNo);
            panel3.Controls.Add(comboBoxRoomNumber);
            panel3.Controls.Add(lblFloorNo);
            panel3.Controls.Add(lblRoomNumber);
            panel3.Controls.Add(textBoxSquareMeters);
            panel3.Controls.Add(lblLocation);
            panel3.Controls.Add(comboBoxLocation);
            panel3.Controls.Add(lblSquareMeters);
            panel3.Location = new System.Drawing.Point(119, 696);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1096, 402);
            panel3.TabIndex = 14;
            // 
            // comboBoxFloorNo
            // 
            comboBoxFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFloorNo.FormattingEnabled = true;
            comboBoxFloorNo.Location = new System.Drawing.Point(199, 356);
            comboBoxFloorNo.Name = "comboBoxFloorNo";
            comboBoxFloorNo.Size = new System.Drawing.Size(838, 34);
            comboBoxFloorNo.TabIndex = 18;
            // 
            // comboBoxRoomNumber
            // 
            comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxRoomNumber.FormattingEnabled = true;
            comboBoxRoomNumber.Location = new System.Drawing.Point(199, 254);
            comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            comboBoxRoomNumber.Size = new System.Drawing.Size(839, 34);
            comboBoxRoomNumber.TabIndex = 17;
            // 
            // lblFloorNo
            // 
            lblFloorNo.AutoSize = true;
            lblFloorNo.Location = new System.Drawing.Point(199, 327);
            lblFloorNo.Name = "lblFloorNo";
            lblFloorNo.Size = new System.Drawing.Size(145, 26);
            lblFloorNo.TabIndex = 16;
            lblFloorNo.Text = "Floor Number";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new System.Drawing.Point(199, 227);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new System.Drawing.Size(155, 26);
            lblRoomNumber.TabIndex = 14;
            lblRoomNumber.Text = "Room Number";
            // 
            // textBoxSquareMeters
            // 
            textBoxSquareMeters.Location = new System.Drawing.Point(200, 56);
            textBoxSquareMeters.Name = "textBoxSquareMeters";
            textBoxSquareMeters.Size = new System.Drawing.Size(838, 32);
            textBoxSquareMeters.TabIndex = 10;
            textBoxSquareMeters.TextChanged += textBoxSquareMeters_TextChanged;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new System.Drawing.Point(199, 125);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new System.Drawing.Size(94, 26);
            lblLocation.TabIndex = 10;
            lblLocation.Text = "Location";
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Location = new System.Drawing.Point(199, 154);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new System.Drawing.Size(839, 34);
            comboBoxLocation.TabIndex = 11;
            // 
            // lblSquareMeters
            // 
            lblSquareMeters.AutoSize = true;
            lblSquareMeters.Location = new System.Drawing.Point(200, 27);
            lblSquareMeters.Name = "lblSquareMeters";
            lblSquareMeters.Size = new System.Drawing.Size(154, 26);
            lblSquareMeters.TabIndex = 12;
            lblSquareMeters.Text = "Square Meters";
            // 
            // navbar1
            // 
            navbar1.BackColor = System.Drawing.Color.Silver;
            navbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            navbar1.Location = new System.Drawing.Point(0, 0);
            navbar1.Margin = new System.Windows.Forms.Padding(5);
            navbar1.Name = "navbar1";
            navbar1.Size = new System.Drawing.Size(2228, 75);
            navbar1.TabIndex = 2;
            // 
            // CreateAd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1494, 706);
            Controls.Add(navbar1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "CreateAd";
            Text = "CreateAd";
            Load += CreateAd_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPhotos;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSquareMeters;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private navbar navbar1;
        private System.Windows.Forms.TextBox textBoxSquareMeters;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblElevator;
        private System.Windows.Forms.ComboBox comboBoxElevator;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label lblFloorNo;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.ComboBox comboBoxFloorNo;
        private System.Windows.Forms.Button btnSaveAdvert;
    }
}