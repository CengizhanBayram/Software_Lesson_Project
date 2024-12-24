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
            components = new System.ComponentModel.Container();
            panel2 = new System.Windows.Forms.Panel();
            maskedTextBoxSquareMeters = new System.Windows.Forms.MaskedTextBox();
            maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            btnSaveAdvert = new System.Windows.Forms.Button();
            lblElevator = new System.Windows.Forms.Label();
            comboBoxFloorNo = new System.Windows.Forms.ComboBox();
            comboBoxElevator = new System.Windows.Forms.ComboBox();
            textBoxTitle = new System.Windows.Forms.TextBox();
            comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            lblPhotos = new System.Windows.Forms.Label();
            lblFloorNo = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblRoomNumber = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            lblLocation = new System.Windows.Forms.Label();
            flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            comboBoxLocation = new System.Windows.Forms.ComboBox();
            lblSquareMeters = new System.Windows.Forms.Label();
            btnUploadPhoto = new System.Windows.Forms.Button();
            lblPrice = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            navbar1 = new navbar();
            panel7 = new System.Windows.Forms.Panel();
            errorProviderTitle = new System.Windows.Forms.ErrorProvider(components);
            errorProviderDescription = new System.Windows.Forms.ErrorProvider(components);
            errorProviderPrice = new System.Windows.Forms.ErrorProvider(components);
            errorProviderSquareMeter = new System.Windows.Forms.ErrorProvider(components);
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSquareMeter).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel2.Controls.Add(maskedTextBoxSquareMeters);
            panel2.Controls.Add(maskedTextBoxPrice);
            panel2.Controls.Add(btnSaveAdvert);
            panel2.Controls.Add(lblElevator);
            panel2.Controls.Add(comboBoxFloorNo);
            panel2.Controls.Add(comboBoxElevator);
            panel2.Controls.Add(textBoxTitle);
            panel2.Controls.Add(comboBoxRoomNumber);
            panel2.Controls.Add(lblPhotos);
            panel2.Controls.Add(lblFloorNo);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(lblRoomNumber);
            panel2.Controls.Add(lblDescription);
            panel2.Controls.Add(richTextBoxDescription);
            panel2.Controls.Add(lblLocation);
            panel2.Controls.Add(flowLayoutPanelPhotos);
            panel2.Controls.Add(comboBoxLocation);
            panel2.Controls.Add(lblSquareMeters);
            panel2.Controls.Add(btnUploadPhoto);
            panel2.Controls.Add(lblPrice);
            panel2.Location = new System.Drawing.Point(264, 27);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(881, 1404);
            panel2.TabIndex = 13;
            // 
            // maskedTextBoxSquareMeters
            // 
            maskedTextBoxSquareMeters.Location = new System.Drawing.Point(29, 734);
            maskedTextBoxSquareMeters.Mask = "00000";
            maskedTextBoxSquareMeters.Name = "maskedTextBoxSquareMeters";
            maskedTextBoxSquareMeters.Size = new System.Drawing.Size(825, 32);
            maskedTextBoxSquareMeters.TabIndex = 20;
            maskedTextBoxSquareMeters.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPrice
            // 
            maskedTextBoxPrice.Location = new System.Drawing.Point(29, 641);
            maskedTextBoxPrice.Mask = "0000000000";
            maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            maskedTextBoxPrice.Size = new System.Drawing.Size(825, 32);
            maskedTextBoxPrice.TabIndex = 19;
            maskedTextBoxPrice.ValidatingType = typeof(int);
            // 
            // btnSaveAdvert
            // 
            btnSaveAdvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnSaveAdvert.Location = new System.Drawing.Point(720, 1222);
            btnSaveAdvert.Name = "btnSaveAdvert";
            btnSaveAdvert.Size = new System.Drawing.Size(135, 36);
            btnSaveAdvert.TabIndex = 12;
            btnSaveAdvert.Text = "Save";
            btnSaveAdvert.UseVisualStyleBackColor = true;
            btnSaveAdvert.Click += btnSaveAdvert_Click;
            // 
            // lblElevator
            // 
            lblElevator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblElevator.AutoSize = true;
            lblElevator.Location = new System.Drawing.Point(30, 1109);
            lblElevator.Name = "lblElevator";
            lblElevator.Size = new System.Drawing.Size(92, 26);
            lblElevator.TabIndex = 10;
            lblElevator.Text = "Elevator";
            // 
            // comboBoxFloorNo
            // 
            comboBoxFloorNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFloorNo.FormattingEnabled = true;
            comboBoxFloorNo.Location = new System.Drawing.Point(29, 1034);
            comboBoxFloorNo.Name = "comboBoxFloorNo";
            comboBoxFloorNo.Size = new System.Drawing.Size(826, 34);
            comboBoxFloorNo.TabIndex = 18;
            // 
            // comboBoxElevator
            // 
            comboBoxElevator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxElevator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxElevator.FormattingEnabled = true;
            comboBoxElevator.Location = new System.Drawing.Point(30, 1138);
            comboBoxElevator.Name = "comboBoxElevator";
            comboBoxElevator.Size = new System.Drawing.Size(825, 34);
            comboBoxElevator.TabIndex = 11;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxTitle.Location = new System.Drawing.Point(30, 365);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new System.Drawing.Size(825, 32);
            textBoxTitle.TabIndex = 1;
            // 
            // comboBoxRoomNumber
            // 
            comboBoxRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxRoomNumber.FormattingEnabled = true;
            comboBoxRoomNumber.Location = new System.Drawing.Point(29, 932);
            comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            comboBoxRoomNumber.Size = new System.Drawing.Size(826, 34);
            comboBoxRoomNumber.TabIndex = 17;
            // 
            // lblPhotos
            // 
            lblPhotos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblPhotos.AutoSize = true;
            lblPhotos.Location = new System.Drawing.Point(30, 12);
            lblPhotos.Name = "lblPhotos";
            lblPhotos.Size = new System.Drawing.Size(80, 26);
            lblPhotos.TabIndex = 0;
            lblPhotos.Text = "Photos";
            // 
            // lblFloorNo
            // 
            lblFloorNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblFloorNo.AutoSize = true;
            lblFloorNo.Location = new System.Drawing.Point(29, 1004);
            lblFloorNo.Name = "lblFloorNo";
            lblFloorNo.Size = new System.Drawing.Size(145, 26);
            lblFloorNo.TabIndex = 16;
            lblFloorNo.Text = "Floor Number";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(30, 336);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(52, 26);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new System.Drawing.Point(29, 904);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new System.Drawing.Size(155, 26);
            lblRoomNumber.TabIndex = 14;
            lblRoomNumber.Text = "Room Number";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(30, 438);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(121, 26);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            richTextBoxDescription.Location = new System.Drawing.Point(30, 467);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new System.Drawing.Size(825, 107);
            richTextBoxDescription.TabIndex = 7;
            richTextBoxDescription.Text = "";
            // 
            // lblLocation
            // 
            lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblLocation.AutoSize = true;
            lblLocation.Location = new System.Drawing.Point(29, 803);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new System.Drawing.Size(94, 26);
            lblLocation.TabIndex = 10;
            lblLocation.Text = "Location";
            // 
            // flowLayoutPanelPhotos
            // 
            flowLayoutPanelPhotos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            flowLayoutPanelPhotos.Location = new System.Drawing.Point(30, 41);
            flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
            flowLayoutPanelPhotos.Size = new System.Drawing.Size(825, 235);
            flowLayoutPanelPhotos.TabIndex = 2;
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Location = new System.Drawing.Point(29, 832);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new System.Drawing.Size(826, 34);
            comboBoxLocation.TabIndex = 11;
            // 
            // lblSquareMeters
            // 
            lblSquareMeters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblSquareMeters.AutoSize = true;
            lblSquareMeters.Location = new System.Drawing.Point(30, 705);
            lblSquareMeters.Name = "lblSquareMeters";
            lblSquareMeters.Size = new System.Drawing.Size(154, 26);
            lblSquareMeters.TabIndex = 12;
            lblSquareMeters.Text = "Square Meters";
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btnUploadPhoto.Location = new System.Drawing.Point(699, 286);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new System.Drawing.Size(156, 40);
            btnUploadPhoto.TabIndex = 4;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(29, 612);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(106, 26);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price (TL)";
            // 
            // panel6
            // 
            panel6.Controls.Add(navbar1);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(1482, 80);
            panel6.TabIndex = 2;
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
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.Controls.Add(panel2);
            panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            panel7.Location = new System.Drawing.Point(0, 80);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(1482, 673);
            panel7.TabIndex = 3;
            // 
            // errorProviderTitle
            // 
            errorProviderTitle.ContainerControl = this;
            // 
            // errorProviderDescription
            // 
            errorProviderDescription.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            errorProviderPrice.ContainerControl = this;
            // 
            // errorProviderSquareMeter
            // 
            errorProviderSquareMeter.ContainerControl = this;
            // 
            // CreateAd
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "CreateAd";
            Text = "CreateAd";
            Load += CreateAd_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProviderTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSquareMeter).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblPhotos;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSquareMeters;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label lblFloorNo;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.ComboBox comboBoxFloorNo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSaveAdvert;
        private System.Windows.Forms.Label lblElevator;
        private System.Windows.Forms.ComboBox comboBoxElevator;
        private navbar navbar1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSquareMeters;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
        private System.Windows.Forms.ErrorProvider errorProviderTitle;
        private System.Windows.Forms.ErrorProvider errorProviderDescription;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
        private System.Windows.Forms.ErrorProvider errorProviderSquareMeter;
    }
}