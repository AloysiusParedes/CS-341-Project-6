namespace apared5hw6
{
    partial class ctaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctaForm));
            this.loadFileButton = new System.Windows.Forms.Button();
            this.stationsListBox = new System.Windows.Forms.ListBox();
            this.totalRidershipLabel = new System.Windows.Forms.Label();
            this.averageRidershipLabel = new System.Windows.Forms.Label();
            this.percentRidershipLabel = new System.Windows.Forms.Label();
            this.stopsLabel = new System.Windows.Forms.Label();
            this.weekdayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.sundayHolidayLabel = new System.Windows.Forms.Label();
            this.handicapLabel = new System.Windows.Forms.Label();
            this.directionOfTravelLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.linesLabel = new System.Windows.Forms.Label();
            this.stopsListBox = new System.Windows.Forms.ListBox();
            this.stationsLabel = new System.Windows.Forms.Label();
            this.totalRidershipTextBox = new System.Windows.Forms.TextBox();
            this.averageRidershipTextBox = new System.Windows.Forms.TextBox();
            this.percentRidershipTextBox = new System.Windows.Forms.TextBox();
            this.weekdayTextBox = new System.Windows.Forms.TextBox();
            this.saturdayTextBox = new System.Windows.Forms.TextBox();
            this.sundayHolidayTextBox = new System.Windows.Forms.TextBox();
            this.linesListBox = new System.Windows.Forms.ListBox();
            this.handicapTextBox = new System.Windows.Forms.TextBox();
            this.directionOfTravelTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.top10Button = new System.Windows.Forms.Button();
            this.numberOfStationsLabel = new System.Windows.Forms.Label();
            this.handicapPictureBox = new System.Windows.Forms.PictureBox();
            this.compassPictureBox = new System.Windows.Forms.PictureBox();
            this.ctaLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numStationsTextBox = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.handicapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compassPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctaLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileButton.Location = new System.Drawing.Point(518, 717);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(243, 162);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // stationsListBox
            // 
            this.stationsListBox.FormattingEnabled = true;
            this.stationsListBox.HorizontalScrollbar = true;
            this.stationsListBox.ItemHeight = 25;
            this.stationsListBox.Location = new System.Drawing.Point(12, 31);
            this.stationsListBox.Name = "stationsListBox";
            this.stationsListBox.Size = new System.Drawing.Size(464, 1004);
            this.stationsListBox.TabIndex = 1;
            this.stationsListBox.SelectedIndexChanged += new System.EventHandler(this.stationsListBox_SelectedIndexChanged);
            // 
            // totalRidershipLabel
            // 
            this.totalRidershipLabel.AutoSize = true;
            this.totalRidershipLabel.Location = new System.Drawing.Point(513, 153);
            this.totalRidershipLabel.Name = "totalRidershipLabel";
            this.totalRidershipLabel.Size = new System.Drawing.Size(163, 25);
            this.totalRidershipLabel.TabIndex = 2;
            this.totalRidershipLabel.Text = "Total Ridership:";
            // 
            // averageRidershipLabel
            // 
            this.averageRidershipLabel.AutoSize = true;
            this.averageRidershipLabel.Location = new System.Drawing.Point(513, 253);
            this.averageRidershipLabel.Name = "averageRidershipLabel";
            this.averageRidershipLabel.Size = new System.Drawing.Size(195, 25);
            this.averageRidershipLabel.TabIndex = 3;
            this.averageRidershipLabel.Text = "Average Ridership:";
            // 
            // percentRidershipLabel
            // 
            this.percentRidershipLabel.AutoSize = true;
            this.percentRidershipLabel.Location = new System.Drawing.Point(513, 352);
            this.percentRidershipLabel.Name = "percentRidershipLabel";
            this.percentRidershipLabel.Size = new System.Drawing.Size(189, 25);
            this.percentRidershipLabel.TabIndex = 4;
            this.percentRidershipLabel.Text = "Percent Ridership:";
            // 
            // stopsLabel
            // 
            this.stopsLabel.AutoSize = true;
            this.stopsLabel.Location = new System.Drawing.Point(513, 453);
            this.stopsLabel.Name = "stopsLabel";
            this.stopsLabel.Size = new System.Drawing.Size(207, 25);
            this.stopsLabel.TabIndex = 5;
            this.stopsLabel.Text = "Stops at this station:";
            // 
            // weekdayLabel
            // 
            this.weekdayLabel.AutoSize = true;
            this.weekdayLabel.Location = new System.Drawing.Point(1079, 153);
            this.weekdayLabel.Name = "weekdayLabel";
            this.weekdayLabel.Size = new System.Drawing.Size(108, 25);
            this.weekdayLabel.TabIndex = 6;
            this.weekdayLabel.Text = "Weekday:";
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Location = new System.Drawing.Point(1079, 253);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(104, 25);
            this.saturdayLabel.TabIndex = 7;
            this.saturdayLabel.Text = "Saturday:";
            // 
            // sundayHolidayLabel
            // 
            this.sundayHolidayLabel.AutoSize = true;
            this.sundayHolidayLabel.Location = new System.Drawing.Point(1079, 352);
            this.sundayHolidayLabel.Name = "sundayHolidayLabel";
            this.sundayHolidayLabel.Size = new System.Drawing.Size(169, 25);
            this.sundayHolidayLabel.TabIndex = 8;
            this.sundayHolidayLabel.Text = "Sunday/Holiday:";
            // 
            // handicapLabel
            // 
            this.handicapLabel.AutoSize = true;
            this.handicapLabel.Location = new System.Drawing.Point(1079, 453);
            this.handicapLabel.Name = "handicapLabel";
            this.handicapLabel.Size = new System.Drawing.Size(240, 25);
            this.handicapLabel.TabIndex = 9;
            this.handicapLabel.Text = "Handicap Accessibility: ";
            // 
            // directionOfTravelLabel
            // 
            this.directionOfTravelLabel.AutoSize = true;
            this.directionOfTravelLabel.Location = new System.Drawing.Point(1079, 597);
            this.directionOfTravelLabel.Name = "directionOfTravelLabel";
            this.directionOfTravelLabel.Size = new System.Drawing.Size(192, 25);
            this.directionOfTravelLabel.TabIndex = 10;
            this.directionOfTravelLabel.Text = "Direction of travel: ";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(1078, 741);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(100, 25);
            this.locationLabel.TabIndex = 11;
            this.locationLabel.Text = "Location:";
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Location = new System.Drawing.Point(1079, 803);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(70, 25);
            this.linesLabel.TabIndex = 12;
            this.linesLabel.Text = "Lines:";
            // 
            // stopsListBox
            // 
            this.stopsListBox.FormattingEnabled = true;
            this.stopsListBox.ItemHeight = 25;
            this.stopsListBox.Location = new System.Drawing.Point(518, 481);
            this.stopsListBox.Name = "stopsListBox";
            this.stopsListBox.Size = new System.Drawing.Size(528, 229);
            this.stopsListBox.TabIndex = 13;
            this.stopsListBox.SelectedIndexChanged += new System.EventHandler(this.stopsListBox_SelectedIndexChanged);
            // 
            // stationsLabel
            // 
            this.stationsLabel.AutoSize = true;
            this.stationsLabel.Location = new System.Drawing.Point(12, 3);
            this.stationsLabel.Name = "stationsLabel";
            this.stationsLabel.Size = new System.Drawing.Size(96, 25);
            this.stationsLabel.TabIndex = 14;
            this.stationsLabel.Text = "Stations:";
            // 
            // totalRidershipTextBox
            // 
            this.totalRidershipTextBox.Location = new System.Drawing.Point(518, 182);
            this.totalRidershipTextBox.Name = "totalRidershipTextBox";
            this.totalRidershipTextBox.ReadOnly = true;
            this.totalRidershipTextBox.Size = new System.Drawing.Size(528, 31);
            this.totalRidershipTextBox.TabIndex = 15;
            this.totalRidershipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // averageRidershipTextBox
            // 
            this.averageRidershipTextBox.Location = new System.Drawing.Point(517, 281);
            this.averageRidershipTextBox.Name = "averageRidershipTextBox";
            this.averageRidershipTextBox.ReadOnly = true;
            this.averageRidershipTextBox.Size = new System.Drawing.Size(529, 31);
            this.averageRidershipTextBox.TabIndex = 16;
            this.averageRidershipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // percentRidershipTextBox
            // 
            this.percentRidershipTextBox.Location = new System.Drawing.Point(518, 380);
            this.percentRidershipTextBox.Name = "percentRidershipTextBox";
            this.percentRidershipTextBox.ReadOnly = true;
            this.percentRidershipTextBox.Size = new System.Drawing.Size(528, 31);
            this.percentRidershipTextBox.TabIndex = 17;
            this.percentRidershipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weekdayTextBox
            // 
            this.weekdayTextBox.Location = new System.Drawing.Point(1083, 181);
            this.weekdayTextBox.Name = "weekdayTextBox";
            this.weekdayTextBox.ReadOnly = true;
            this.weekdayTextBox.Size = new System.Drawing.Size(480, 31);
            this.weekdayTextBox.TabIndex = 18;
            this.weekdayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saturdayTextBox
            // 
            this.saturdayTextBox.Location = new System.Drawing.Point(1083, 281);
            this.saturdayTextBox.Name = "saturdayTextBox";
            this.saturdayTextBox.ReadOnly = true;
            this.saturdayTextBox.Size = new System.Drawing.Size(480, 31);
            this.saturdayTextBox.TabIndex = 19;
            this.saturdayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sundayHolidayTextBox
            // 
            this.sundayHolidayTextBox.Location = new System.Drawing.Point(1083, 378);
            this.sundayHolidayTextBox.Name = "sundayHolidayTextBox";
            this.sundayHolidayTextBox.ReadOnly = true;
            this.sundayHolidayTextBox.Size = new System.Drawing.Size(480, 31);
            this.sundayHolidayTextBox.TabIndex = 20;
            this.sundayHolidayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // linesListBox
            // 
            this.linesListBox.FormattingEnabled = true;
            this.linesListBox.ItemHeight = 25;
            this.linesListBox.Location = new System.Drawing.Point(1083, 831);
            this.linesListBox.Name = "linesListBox";
            this.linesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.linesListBox.Size = new System.Drawing.Size(480, 204);
            this.linesListBox.TabIndex = 21;
            // 
            // handicapTextBox
            // 
            this.handicapTextBox.Location = new System.Drawing.Point(1254, 482);
            this.handicapTextBox.Name = "handicapTextBox";
            this.handicapTextBox.ReadOnly = true;
            this.handicapTextBox.Size = new System.Drawing.Size(309, 31);
            this.handicapTextBox.TabIndex = 22;
            this.handicapTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // directionOfTravelTextBox
            // 
            this.directionOfTravelTextBox.Location = new System.Drawing.Point(1254, 637);
            this.directionOfTravelTextBox.Name = "directionOfTravelTextBox";
            this.directionOfTravelTextBox.ReadOnly = true;
            this.directionOfTravelTextBox.Size = new System.Drawing.Size(308, 31);
            this.directionOfTravelTextBox.TabIndex = 23;
            this.directionOfTravelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(1084, 769);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(480, 31);
            this.locationTextBox.TabIndex = 24;
            this.locationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // top10Button
            // 
            this.top10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top10Button.Location = new System.Drawing.Point(518, 885);
            this.top10Button.Name = "top10Button";
            this.top10Button.Size = new System.Drawing.Size(243, 150);
            this.top10Button.TabIndex = 25;
            this.top10Button.Text = "Top 10";
            this.top10Button.UseVisualStyleBackColor = true;
            this.top10Button.Click += new System.EventHandler(this.top10Button_Click);
            // 
            // numberOfStationsLabel
            // 
            this.numberOfStationsLabel.AutoSize = true;
            this.numberOfStationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfStationsLabel.Location = new System.Drawing.Point(510, 91);
            this.numberOfStationsLabel.Name = "numberOfStationsLabel";
            this.numberOfStationsLabel.Size = new System.Drawing.Size(350, 42);
            this.numberOfStationsLabel.TabIndex = 26;
            this.numberOfStationsLabel.Text = "Number of stations: ";
            // 
            // handicapPictureBox
            // 
            this.handicapPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("handicapPictureBox.BackgroundImage")));
            this.handicapPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.handicapPictureBox.Location = new System.Drawing.Point(1083, 481);
            this.handicapPictureBox.Name = "handicapPictureBox";
            this.handicapPictureBox.Size = new System.Drawing.Size(165, 113);
            this.handicapPictureBox.TabIndex = 27;
            this.handicapPictureBox.TabStop = false;
            // 
            // compassPictureBox
            // 
            this.compassPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("compassPictureBox.BackgroundImage")));
            this.compassPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compassPictureBox.Location = new System.Drawing.Point(1083, 625);
            this.compassPictureBox.Name = "compassPictureBox";
            this.compassPictureBox.Size = new System.Drawing.Size(165, 113);
            this.compassPictureBox.TabIndex = 28;
            this.compassPictureBox.TabStop = false;
            // 
            // ctaLogoPictureBox
            // 
            this.ctaLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctaLogoPictureBox.BackgroundImage")));
            this.ctaLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctaLogoPictureBox.Location = new System.Drawing.Point(1383, 12);
            this.ctaLogoPictureBox.Name = "ctaLogoPictureBox";
            this.ctaLogoPictureBox.Size = new System.Drawing.Size(180, 140);
            this.ctaLogoPictureBox.TabIndex = 29;
            this.ctaLogoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(507, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(832, 59);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.Text = "Chicago Transit Authority Analysis";
            // 
            // numStationsTextBox
            // 
            this.numStationsTextBox.Location = new System.Drawing.Point(867, 103);
            this.numStationsTextBox.Name = "numStationsTextBox";
            this.numStationsTextBox.ReadOnly = true;
            this.numStationsTextBox.Size = new System.Drawing.Size(179, 31);
            this.numStationsTextBox.TabIndex = 31;
            this.numStationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(803, 716);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(243, 162);
            this.Reset.TabIndex = 32;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(762, 885);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(284, 179);
            this.instructionsLabel.TabIndex = 33;
            this.instructionsLabel.Text = "Load File: Load all stations\r\n\r\nTop 10: Load top ten stations in terms of ridersh" +
    "ip\r\n\r\nReset: Clears all information";
            // 
            // ctaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1575, 1033);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.numStationsTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ctaLogoPictureBox);
            this.Controls.Add(this.compassPictureBox);
            this.Controls.Add(this.handicapPictureBox);
            this.Controls.Add(this.numberOfStationsLabel);
            this.Controls.Add(this.top10Button);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.directionOfTravelTextBox);
            this.Controls.Add(this.handicapTextBox);
            this.Controls.Add(this.linesListBox);
            this.Controls.Add(this.sundayHolidayTextBox);
            this.Controls.Add(this.saturdayTextBox);
            this.Controls.Add(this.weekdayTextBox);
            this.Controls.Add(this.percentRidershipTextBox);
            this.Controls.Add(this.averageRidershipTextBox);
            this.Controls.Add(this.totalRidershipTextBox);
            this.Controls.Add(this.stationsLabel);
            this.Controls.Add(this.stopsListBox);
            this.Controls.Add(this.linesLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.directionOfTravelLabel);
            this.Controls.Add(this.handicapLabel);
            this.Controls.Add(this.sundayHolidayLabel);
            this.Controls.Add(this.saturdayLabel);
            this.Controls.Add(this.weekdayLabel);
            this.Controls.Add(this.stopsLabel);
            this.Controls.Add(this.percentRidershipLabel);
            this.Controls.Add(this.averageRidershipLabel);
            this.Controls.Add(this.totalRidershipLabel);
            this.Controls.Add(this.stationsListBox);
            this.Controls.Add(this.loadFileButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(1601, 1104);
            this.MinimumSize = new System.Drawing.Size(1601, 1104);
            this.Name = "ctaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CTA Ridership Analysis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.handicapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compassPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctaLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.ListBox stationsListBox;
        private System.Windows.Forms.Label totalRidershipLabel;
        private System.Windows.Forms.Label averageRidershipLabel;
        private System.Windows.Forms.Label percentRidershipLabel;
        private System.Windows.Forms.Label stopsLabel;
        private System.Windows.Forms.Label weekdayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label sundayHolidayLabel;
        private System.Windows.Forms.Label handicapLabel;
        private System.Windows.Forms.Label directionOfTravelLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label linesLabel;
        private System.Windows.Forms.ListBox stopsListBox;
        private System.Windows.Forms.Label stationsLabel;
        private System.Windows.Forms.TextBox totalRidershipTextBox;
        private System.Windows.Forms.TextBox averageRidershipTextBox;
        private System.Windows.Forms.TextBox percentRidershipTextBox;
        private System.Windows.Forms.TextBox weekdayTextBox;
        private System.Windows.Forms.TextBox saturdayTextBox;
        private System.Windows.Forms.TextBox sundayHolidayTextBox;
        private System.Windows.Forms.ListBox linesListBox;
        private System.Windows.Forms.TextBox handicapTextBox;
        private System.Windows.Forms.TextBox directionOfTravelTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button top10Button;
        private System.Windows.Forms.Label numberOfStationsLabel;
        private System.Windows.Forms.PictureBox handicapPictureBox;
        private System.Windows.Forms.PictureBox compassPictureBox;
        private System.Windows.Forms.PictureBox ctaLogoPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox numStationsTextBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

