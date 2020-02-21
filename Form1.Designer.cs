namespace Assignment5
{
    partial class teamBuilder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teamBuilder));
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.mealListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookingButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.locationNameLabel = new System.Windows.Forms.Label();
            this.mealLabel = new System.Windows.Forms.Label();
            this.totalEventPriceLabel = new System.Windows.Forms.Label();
            this.totalEventPriceTextBox = new System.Windows.Forms.TextBox();
            this.mealTextBox = new System.Windows.Forms.TextBox();
            this.locationNameTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.detailsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.confirmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventheader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.oderDetailsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // eventListBox
            // 
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 20;
            this.eventListBox.Items.AddRange(new object[] {
            "Murder Mystery Weekend      \t2\t600",
            "CSI Weekend                        \t3\t1000",
            "The Great Outdoors               \t4\t1500",
            "The Chase                             \t6\t1800",
            "Digital Refresh                       \t2\t599",
            "Action Photography               \t5\t999",
            "Team Ryder Cup                   \t3\t619",
            "Abseiling                                \t2\t499",
            "War Games                           \t6\t1999",
            "Find Wally                             \t5\t799"});
            this.eventListBox.Location = new System.Drawing.Point(22, 157);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(428, 204);
            this.eventListBox.TabIndex = 2;
            this.toolTip5.SetToolTip(this.eventListBox, "Please select an event.");
            this.eventListBox.Click += new System.EventHandler(this.eventListBox_Click);
            this.eventListBox.SelectedIndexChanged += new System.EventHandler(this.eventListBox_SelectedIndexChanged);
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 20;
            this.locationListBox.Items.AddRange(new object[] {
            "Cork             \t250",
            "Dublin          \t165",
            "Galway         \t225",
            "Belmullet      \t305",
            "Belfast          \t95"});
            this.locationListBox.Location = new System.Drawing.Point(500, 157);
            this.locationListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(236, 104);
            this.locationListBox.TabIndex = 1;
            this.toolTip6.SetToolTip(this.locationListBox, "Please select an event selection.");
            this.locationListBox.Click += new System.EventHandler(this.locationListBox_Click);
            this.locationListBox.SelectedIndexChanged += new System.EventHandler(this.locationListBox_SelectedIndexChanged);
            // 
            // mealListBox
            // 
            this.mealListBox.FormattingEnabled = true;
            this.mealListBox.ItemHeight = 20;
            this.mealListBox.Items.AddRange(new object[] {
            "Full",
            "Half",
            "Breakfast",
            "None"});
            this.mealListBox.Location = new System.Drawing.Point(500, 332);
            this.mealListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mealListBox.Name = "mealListBox";
            this.mealListBox.Size = new System.Drawing.Size(91, 84);
            this.mealListBox.TabIndex = 2;
            this.toolTip7.SetToolTip(this.mealListBox, "Please select meal type (Optional)");
            this.mealListBox.Click += new System.EventHandler(this.mealListBox_Click);
            this.mealListBox.SelectedIndexChanged += new System.EventHandler(this.mealListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookingButton);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.quantityLabel);
            this.groupBox1.Controls.Add(this.eventNameLabel);
            this.groupBox1.Controls.Add(this.locationNameLabel);
            this.groupBox1.Controls.Add(this.mealLabel);
            this.groupBox1.Controls.Add(this.totalEventPriceLabel);
            this.groupBox1.Controls.Add(this.totalEventPriceTextBox);
            this.groupBox1.Controls.Add(this.mealTextBox);
            this.groupBox1.Controls.Add(this.locationNameTextBox);
            this.groupBox1.Controls.Add(this.eventNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(783, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(410, 392);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // bookingButton
            // 
            this.bookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingButton.Location = new System.Drawing.Point(182, 348);
            this.bookingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookingButton.Name = "bookingButton";
            this.bookingButton.Size = new System.Drawing.Size(198, 35);
            this.bookingButton.TabIndex = 10;
            this.bookingButton.Text = "&Add to Booking";
            this.toolTip4.SetToolTip(this.bookingButton, "This button will add the event to a cart.");
            this.bookingButton.UseVisualStyleBackColor = true;
            this.bookingButton.Click += new System.EventHandler(this.bookingButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(182, 48);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(196, 26);
            this.quantityTextBox.TabIndex = 9;
            this.toolTip9.SetToolTip(this.quantityTextBox, "Please enter number of places you wish to book.");
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(9, 52);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(150, 35);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "No of Places";
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(9, 115);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(150, 35);
            this.eventNameLabel.TabIndex = 7;
            this.eventNameLabel.Text = "Event";
            // 
            // locationNameLabel
            // 
            this.locationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationNameLabel.Location = new System.Drawing.Point(9, 175);
            this.locationNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationNameLabel.Name = "locationNameLabel";
            this.locationNameLabel.Size = new System.Drawing.Size(150, 35);
            this.locationNameLabel.TabIndex = 6;
            this.locationNameLabel.Text = "Location";
            // 
            // mealLabel
            // 
            this.mealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLabel.Location = new System.Drawing.Point(9, 232);
            this.mealLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(150, 35);
            this.mealLabel.TabIndex = 5;
            this.mealLabel.Text = "Meal";
            // 
            // totalEventPriceLabel
            // 
            this.totalEventPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEventPriceLabel.Location = new System.Drawing.Point(9, 292);
            this.totalEventPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalEventPriceLabel.Name = "totalEventPriceLabel";
            this.totalEventPriceLabel.Size = new System.Drawing.Size(164, 35);
            this.totalEventPriceLabel.TabIndex = 4;
            this.totalEventPriceLabel.Text = "Total Event Price";
            // 
            // totalEventPriceTextBox
            // 
            this.totalEventPriceTextBox.Location = new System.Drawing.Point(182, 288);
            this.totalEventPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalEventPriceTextBox.Name = "totalEventPriceTextBox";
            this.totalEventPriceTextBox.ReadOnly = true;
            this.totalEventPriceTextBox.Size = new System.Drawing.Size(196, 26);
            this.totalEventPriceTextBox.TabIndex = 3;
            // 
            // mealTextBox
            // 
            this.mealTextBox.Location = new System.Drawing.Point(182, 228);
            this.mealTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mealTextBox.Name = "mealTextBox";
            this.mealTextBox.ReadOnly = true;
            this.mealTextBox.Size = new System.Drawing.Size(196, 26);
            this.mealTextBox.TabIndex = 2;
            // 
            // locationNameTextBox
            // 
            this.locationNameTextBox.Location = new System.Drawing.Point(182, 171);
            this.locationNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationNameTextBox.Name = "locationNameTextBox";
            this.locationNameTextBox.ReadOnly = true;
            this.locationNameTextBox.Size = new System.Drawing.Size(196, 26);
            this.locationNameTextBox.TabIndex = 1;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(182, 111);
            this.eventNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.ReadOnly = true;
            this.eventNameTextBox.Size = new System.Drawing.Size(196, 26);
            this.eventNameTextBox.TabIndex = 0;
            // 
            // detailsListView
            // 
            this.detailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.detailsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsListView.Location = new System.Drawing.Point(22, 523);
            this.detailsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailsListView.Name = "detailsListView";
            this.detailsListView.Size = new System.Drawing.Size(810, 179);
            this.detailsListView.TabIndex = 4;
            this.toolTip8.SetToolTip(this.detailsListView, "Purchase cart");
            this.detailsListView.UseCompatibleStateImageBehavior = false;
            this.detailsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Meal";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No of Places";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Price";
            this.columnHeader5.Width = 125;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(843, 669);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 35);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "&Confirm";
            this.toolTip3.SetToolTip(this.confirmButton, "This button will confirm the bookings");
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1080, 669);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "&Exit";
            this.toolTip2.SetToolTip(this.exitButton, "This button will close the application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(1080, 603);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 35);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearButton, "This button will clear all selections and inputs provided.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(302, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "TeamBuilder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventheader
            // 
            this.eventheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventheader.Location = new System.Drawing.Point(18, 122);
            this.eventheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventheader.Name = "eventheader";
            this.eventheader.Size = new System.Drawing.Size(462, 29);
            this.eventheader.TabIndex = 4;
            this.eventheader.Text = "Event                        Days     Registration Fees";
            this.eventheader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Location     Lodging Fees";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Meal Type ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Assignment5.Properties.Resources.Capture2;
            this.pictureBox1.Location = new System.Drawing.Point(345, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Assignment5.Properties.Resources.Capture2;
            this.pictureBox2.Location = new System.Drawing.Point(756, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // oderDetailsLabel
            // 
            this.oderDetailsLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oderDetailsLabel.Location = new System.Drawing.Point(22, 469);
            this.oderDetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oderDetailsLabel.Name = "oderDetailsLabel";
            this.oderDetailsLabel.Size = new System.Drawing.Size(206, 35);
            this.oderDetailsLabel.TabIndex = 16;
            this.oderDetailsLabel.Text = "Order Details";
            // 
            // teamBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 732);
            this.Controls.Add(this.oderDetailsLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventheader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.detailsListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mealListBox);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.eventListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "teamBuilder";
            this.Text = "TeamBuilder Ltd";
            this.Load += new System.EventHandler(this.teamBuilder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.ListBox mealListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label locationNameLabel;
        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.Label totalEventPriceLabel;
        private System.Windows.Forms.TextBox totalEventPriceTextBox;
        private System.Windows.Forms.TextBox mealTextBox;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button bookingButton;
        private System.Windows.Forms.ListView detailsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eventheader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label oderDetailsLabel;
    }
}

