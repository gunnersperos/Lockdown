namespace Lockdown
{
    partial class frmSetSchedule
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.cboProfiles = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.cboRepeat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.LogoPanel.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Impact", 16F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnSave.Location = new System.Drawing.Point(338, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Impact", 16F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnCancel.Location = new System.Drawing.Point(210, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Impact", 14F);
            this.lblStartDate.Location = new System.Drawing.Point(213, 84);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(93, 23);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Impact", 14F);
            this.lblProfile.Location = new System.Drawing.Point(213, 37);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(67, 23);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Profile:";
            // 
            // LogoImgBox
            // 
            this.LogoImgBox.Image = global::Lockdown.Properties.Resources.TestLogo_Cheeseman__1_;
            this.LogoImgBox.Location = new System.Drawing.Point(12, 0);
            this.LogoImgBox.Name = "LogoImgBox";
            this.LogoImgBox.Size = new System.Drawing.Size(180, 440);
            this.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImgBox.TabIndex = 0;
            this.LogoImgBox.TabStop = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoImgBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 29);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 411);
            this.LogoPanel.TabIndex = 6;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblBack.Location = new System.Drawing.Point(0, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(20, 20);
            this.lblBack.TabIndex = 3;
            this.lblBack.Text = "◁";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblMinimize.Location = new System.Drawing.Point(693, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(16, 20);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "–";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblExit.Location = new System.Drawing.Point(709, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblBack);
            this.FormControlPanel.Controls.Add(this.lblMinimize);
            this.FormControlPanel.Controls.Add(this.lblExit);
            this.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControlPanel.Location = new System.Drawing.Point(0, 0);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(730, 29);
            this.FormControlPanel.TabIndex = 7;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.cboRepeat);
            this.ContentPanel.Controls.Add(this.lblRepeat);
            this.ContentPanel.Controls.Add(this.lblEndTime);
            this.ContentPanel.Controls.Add(this.timeEnd);
            this.ContentPanel.Controls.Add(this.lblStartTime);
            this.ContentPanel.Controls.Add(this.timeStart);
            this.ContentPanel.Controls.Add(this.dateTimePicker2);
            this.ContentPanel.Controls.Add(this.lblEndDate);
            this.ContentPanel.Controls.Add(this.dateStart);
            this.ContentPanel.Controls.Add(this.cboProfiles);
            this.ContentPanel.Controls.Add(this.btnSave);
            this.ContentPanel.Controls.Add(this.btnCancel);
            this.ContentPanel.Controls.Add(this.lblStartDate);
            this.ContentPanel.Controls.Add(this.lblProfile);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(730, 440);
            this.ContentPanel.TabIndex = 8;
            // 
            // cboProfiles
            // 
            this.cboProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cboProfiles.Font = new System.Drawing.Font("Impact", 8.25F);
            this.cboProfiles.FormattingEnabled = true;
            this.cboProfiles.Location = new System.Drawing.Point(286, 35);
            this.cboProfiles.Name = "cboProfiles";
            this.cboProfiles.Size = new System.Drawing.Size(147, 23);
            this.cboProfiles.TabIndex = 11;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(312, 86);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(197, 20);
            this.dateStart.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(312, 135);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Impact", 14F);
            this.lblEndDate.Location = new System.Drawing.Point(213, 133);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(82, 23);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "End Date:";
            // 
            // timeStart
            // 
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(312, 183);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(86, 20);
            this.timeStart.TabIndex = 15;
            this.timeStart.Value = new System.DateTime(2020, 10, 22, 13, 9, 0, 0);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Impact", 14F);
            this.lblStartTime.Location = new System.Drawing.Point(213, 180);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(95, 23);
            this.lblStartTime.TabIndex = 16;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Impact", 14F);
            this.lblEndTime.Location = new System.Drawing.Point(213, 221);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(84, 23);
            this.lblEndTime.TabIndex = 18;
            this.lblEndTime.Text = "End Time:";
            // 
            // timeEnd
            // 
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(312, 224);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(86, 20);
            this.timeEnd.TabIndex = 17;
            this.timeEnd.Value = new System.DateTime(2020, 10, 22, 13, 9, 0, 0);
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Font = new System.Drawing.Font("Impact", 14F);
            this.lblRepeat.Location = new System.Drawing.Point(213, 264);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(70, 23);
            this.lblRepeat.TabIndex = 19;
            this.lblRepeat.Text = "Repeat:";
            // 
            // cboRepeat
            // 
            this.cboRepeat.FormattingEnabled = true;
            this.cboRepeat.Location = new System.Drawing.Point(312, 265);
            this.cboRepeat.Name = "cboRepeat";
            this.cboRepeat.Size = new System.Drawing.Size(121, 21);
            this.cboRepeat.TabIndex = 20;
            // 
            // frmSetSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.FormControlPanel);
            this.Controls.Add(this.ContentPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            this.FormControlPanel.ResumeLayout(false);
            this.FormControlPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.ComboBox cboRepeat;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.ComboBox cboProfiles;
    }
}