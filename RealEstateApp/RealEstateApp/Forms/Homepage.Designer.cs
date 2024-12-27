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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            panel1 = new System.Windows.Forms.Panel();
            navbar2 = new navbar();
            flowLayoutPanelAds = new System.Windows.Forms.FlowLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            buttonSearchFilter = new System.Windows.Forms.Button();
            comboBoxElevator = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            comboBoxFloor = new System.Windows.Forms.ComboBox();
            labelFloorNumber = new System.Windows.Forms.Label();
            comboBoxRoom = new System.Windows.Forms.ComboBox();
            labelRoomNumber = new System.Windows.Forms.Label();
            textBoxSquareMeterMin = new System.Windows.Forms.TextBox();
            labelSquareMeterFilter = new System.Windows.Forms.Label();
            comboBoxLocationFilter = new System.Windows.Forms.ComboBox();
            textBoxPriceMax = new System.Windows.Forms.TextBox();
            textBoxPriceMin = new System.Windows.Forms.TextBox();
            labelPriceFilter = new System.Windows.Forms.Label();
            labelLocationFilter = new System.Windows.Forms.Label();
            buttonSearchTitle = new System.Windows.Forms.Button();
            textBoxSearchTitle = new System.Windows.Forms.TextBox();
            textBoxSquareMeterMax = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(navbar2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 80);
            panel1.TabIndex = 0;
            // 
            // navbar2
            // 
            navbar2.BackColor = System.Drawing.Color.FromArgb(0, 41, 85);
            navbar2.BackgroundImage = (System.Drawing.Image)resources.GetObject("navbar2.BackgroundImage");
            navbar2.Dock = System.Windows.Forms.DockStyle.Fill;
            navbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            navbar2.Location = new System.Drawing.Point(0, 0);
            navbar2.Margin = new System.Windows.Forms.Padding(5);
            navbar2.Name = "navbar2";
            navbar2.Size = new System.Drawing.Size(1482, 80);
            navbar2.TabIndex = 0;
            // 
            // flowLayoutPanelAds
            // 
            flowLayoutPanelAds.AllowDrop = true;
            flowLayoutPanelAds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            flowLayoutPanelAds.AutoScroll = true;
            flowLayoutPanelAds.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanelAds.Location = new System.Drawing.Point(259, 51);
            flowLayoutPanelAds.Name = "flowLayoutPanelAds";
            flowLayoutPanelAds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            flowLayoutPanelAds.Size = new System.Drawing.Size(1197, 610);
            flowLayoutPanelAds.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(0, 41, 85);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(buttonSearchTitle);
            panel2.Controls.Add(textBoxSearchTitle);
            panel2.Controls.Add(flowLayoutPanelAds);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1482, 673);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel3.Controls.Add(textBoxSquareMeterMax);
            panel3.Controls.Add(buttonSearchFilter);
            panel3.Controls.Add(comboBoxElevator);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(comboBoxFloor);
            panel3.Controls.Add(labelFloorNumber);
            panel3.Controls.Add(comboBoxRoom);
            panel3.Controls.Add(labelRoomNumber);
            panel3.Controls.Add(textBoxSquareMeterMin);
            panel3.Controls.Add(labelSquareMeterFilter);
            panel3.Controls.Add(comboBoxLocationFilter);
            panel3.Controls.Add(textBoxPriceMax);
            panel3.Controls.Add(textBoxPriceMin);
            panel3.Controls.Add(labelPriceFilter);
            panel3.Controls.Add(labelLocationFilter);
            panel3.Location = new System.Drawing.Point(10, 51);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(232, 610);
            panel3.TabIndex = 5;
            // 
            // buttonSearchFilter
            // 
            buttonSearchFilter.Location = new System.Drawing.Point(45, 519);
            buttonSearchFilter.Name = "buttonSearchFilter";
            buttonSearchFilter.Size = new System.Drawing.Size(123, 34);
            buttonSearchFilter.TabIndex = 14;
            buttonSearchFilter.Text = "Search";
            buttonSearchFilter.UseVisualStyleBackColor = true;
            buttonSearchFilter.Click += buttonSearchFilter_Click;
            // 
            // comboBoxElevator
            // 
            comboBoxElevator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxElevator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxElevator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            comboBoxElevator.FormattingEnabled = true;
            comboBoxElevator.Location = new System.Drawing.Point(12, 460);
            comboBoxElevator.Name = "comboBoxElevator";
            comboBoxElevator.Size = new System.Drawing.Size(206, 30);
            comboBoxElevator.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(8, 433);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 24);
            label1.TabIndex = 12;
            label1.Text = "Elevator";
            // 
            // comboBoxFloor
            // 
            comboBoxFloor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            comboBoxFloor.FormattingEnabled = true;
            comboBoxFloor.Location = new System.Drawing.Point(12, 377);
            comboBoxFloor.Name = "comboBoxFloor";
            comboBoxFloor.Size = new System.Drawing.Size(206, 30);
            comboBoxFloor.TabIndex = 11;
            // 
            // labelFloorNumber
            // 
            labelFloorNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelFloorNumber.AutoSize = true;
            labelFloorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelFloorNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            labelFloorNumber.Location = new System.Drawing.Point(8, 350);
            labelFloorNumber.Name = "labelFloorNumber";
            labelFloorNumber.Size = new System.Drawing.Size(128, 24);
            labelFloorNumber.TabIndex = 10;
            labelFloorNumber.Text = "Floor Number";
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new System.Drawing.Point(12, 291);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new System.Drawing.Size(206, 30);
            comboBoxRoom.TabIndex = 9;
            // 
            // labelRoomNumber
            // 
            labelRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelRoomNumber.AutoSize = true;
            labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelRoomNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            labelRoomNumber.Location = new System.Drawing.Point(8, 264);
            labelRoomNumber.Name = "labelRoomNumber";
            labelRoomNumber.Size = new System.Drawing.Size(135, 24);
            labelRoomNumber.TabIndex = 8;
            labelRoomNumber.Text = "Room Number";
            // 
            // textBoxSquareMeterMin
            // 
            textBoxSquareMeterMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxSquareMeterMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBoxSquareMeterMin.Location = new System.Drawing.Point(12, 127);
            textBoxSquareMeterMin.Name = "textBoxSquareMeterMin";
            textBoxSquareMeterMin.Size = new System.Drawing.Size(97, 28);
            textBoxSquareMeterMin.TabIndex = 7;
            // 
            // labelSquareMeterFilter
            // 
            labelSquareMeterFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelSquareMeterFilter.AutoSize = true;
            labelSquareMeterFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelSquareMeterFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            labelSquareMeterFilter.Location = new System.Drawing.Point(10, 100);
            labelSquareMeterFilter.Name = "labelSquareMeterFilter";
            labelSquareMeterFilter.Size = new System.Drawing.Size(124, 24);
            labelSquareMeterFilter.TabIndex = 6;
            labelSquareMeterFilter.Text = "Square Meter";
            // 
            // comboBoxLocationFilter
            // 
            comboBoxLocationFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            comboBoxLocationFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLocationFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            comboBoxLocationFilter.FormattingEnabled = true;
            comboBoxLocationFilter.Location = new System.Drawing.Point(12, 206);
            comboBoxLocationFilter.Name = "comboBoxLocationFilter";
            comboBoxLocationFilter.Size = new System.Drawing.Size(206, 30);
            comboBoxLocationFilter.TabIndex = 5;
            // 
            // textBoxPriceMax
            // 
            textBoxPriceMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBoxPriceMax.Location = new System.Drawing.Point(121, 41);
            textBoxPriceMax.Name = "textBoxPriceMax";
            textBoxPriceMax.Size = new System.Drawing.Size(97, 28);
            textBoxPriceMax.TabIndex = 4;
            // 
            // textBoxPriceMin
            // 
            textBoxPriceMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBoxPriceMin.Location = new System.Drawing.Point(12, 41);
            textBoxPriceMin.Name = "textBoxPriceMin";
            textBoxPriceMin.Size = new System.Drawing.Size(97, 28);
            textBoxPriceMin.TabIndex = 3;
            // 
            // labelPriceFilter
            // 
            labelPriceFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelPriceFilter.AutoSize = true;
            labelPriceFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelPriceFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            labelPriceFilter.Location = new System.Drawing.Point(10, 14);
            labelPriceFilter.Name = "labelPriceFilter";
            labelPriceFilter.Size = new System.Drawing.Size(53, 24);
            labelPriceFilter.TabIndex = 2;
            labelPriceFilter.Text = "Price";
            // 
            // labelLocationFilter
            // 
            labelLocationFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelLocationFilter.AutoSize = true;
            labelLocationFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelLocationFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            labelLocationFilter.Location = new System.Drawing.Point(8, 179);
            labelLocationFilter.Name = "labelLocationFilter";
            labelLocationFilter.Size = new System.Drawing.Size(81, 24);
            labelLocationFilter.TabIndex = 0;
            labelLocationFilter.Text = "Location";
            // 
            // buttonSearchTitle
            // 
            buttonSearchTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            buttonSearchTitle.BackColor = System.Drawing.Color.Transparent;
            buttonSearchTitle.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonSearchTitle.BackgroundImage");
            buttonSearchTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonSearchTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            buttonSearchTitle.Location = new System.Drawing.Point(1001, 11);
            buttonSearchTitle.Name = "buttonSearchTitle";
            buttonSearchTitle.Size = new System.Drawing.Size(38, 32);
            buttonSearchTitle.TabIndex = 4;
            buttonSearchTitle.UseVisualStyleBackColor = false;
            buttonSearchTitle.Click += buttonSearchTitle_Click;
            // 
            // textBoxSearchTitle
            // 
            textBoxSearchTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBoxSearchTitle.Location = new System.Drawing.Point(542, 12);
            textBoxSearchTitle.Name = "textBoxSearchTitle";
            textBoxSearchTitle.Size = new System.Drawing.Size(453, 36);
            textBoxSearchTitle.TabIndex = 3;
            // 
            // textBoxSquareMeterMax
            // 
            textBoxSquareMeterMax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBoxSquareMeterMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBoxSquareMeterMax.Location = new System.Drawing.Point(121, 127);
            textBoxSquareMeterMax.Name = "textBoxSquareMeterMax";
            textBoxSquareMeterMax.Size = new System.Drawing.Size(97, 28);
            textBoxSquareMeterMax.TabIndex = 15;
            // 
            // Homepage
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1482, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private navbar navbar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAds;
        private System.Windows.Forms.Panel panel2;
        private navbar navbar2;
        private System.Windows.Forms.Button buttonSearchTitle;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLocationFilter;
        private System.Windows.Forms.TextBox textBoxPriceMin;
        private System.Windows.Forms.Label labelPriceFilter;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.ComboBox comboBoxLocationFilter;
        private System.Windows.Forms.Label labelSquareMeterFilter;
        private System.Windows.Forms.TextBox textBoxSquareMeterMin;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.ComboBox comboBoxFloor;
        private System.Windows.Forms.Label labelFloorNumber;
        private System.Windows.Forms.ComboBox comboBoxElevator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchFilter;
        private System.Windows.Forms.TextBox textBoxSquareMeterMax;
    }
}