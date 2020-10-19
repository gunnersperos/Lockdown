namespace Lockdown
{
    partial class frmAddReminder
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
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.lblAddReminder = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboRepeat = new System.Windows.Forms.ComboBox();
            this.cboHowOften = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.lblHowOften = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.FormControlPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblAddReminder);
            this.FormControlPanel.Controls.Add(this.lblBack);
            this.FormControlPanel.Controls.Add(this.lblMinimize);
            this.FormControlPanel.Controls.Add(this.lblExit);
            this.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControlPanel.Location = new System.Drawing.Point(200, 0);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(530, 29);
            this.FormControlPanel.TabIndex = 4;
            // 
            // lblAddReminder
            // 
            this.lblAddReminder.AutoSize = true;
            this.lblAddReminder.Font = new System.Drawing.Font("Impact", 14F);
            this.lblAddReminder.Location = new System.Drawing.Point(211, 2);
            this.lblAddReminder.Name = "lblAddReminder";
            this.lblAddReminder.Size = new System.Drawing.Size(119, 23);
            this.lblAddReminder.TabIndex = 0;
            this.lblAddReminder.Text = "Add Reminder";
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
            this.lblMinimize.Location = new System.Drawing.Point(493, 0);
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
            this.lblExit.Location = new System.Drawing.Point(509, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoImgBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 440);
            this.LogoPanel.TabIndex = 3;
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
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.btnSave);
            this.ContentPanel.Controls.Add(this.btnCancel);
            this.ContentPanel.Controls.Add(this.cboType);
            this.ContentPanel.Controls.Add(this.cboRepeat);
            this.ContentPanel.Controls.Add(this.cboHowOften);
            this.ContentPanel.Controls.Add(this.txtName);
            this.ContentPanel.Controls.Add(this.lblType);
            this.ContentPanel.Controls.Add(this.lblRepeat);
            this.ContentPanel.Controls.Add(this.lblHowOften);
            this.ContentPanel.Controls.Add(this.lblName);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(730, 440);
            this.ContentPanel.TabIndex = 5;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cboType.Font = new System.Drawing.Font("Impact", 8.25F);
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(358, 222);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(105, 23);
            this.cboType.TabIndex = 8;
            // 
            // cboRepeat
            // 
            this.cboRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cboRepeat.Font = new System.Drawing.Font("Impact", 8.25F);
            this.cboRepeat.FormattingEnabled = true;
            this.cboRepeat.Location = new System.Drawing.Point(550, 127);
            this.cboRepeat.Name = "cboRepeat";
            this.cboRepeat.Size = new System.Drawing.Size(147, 23);
            this.cboRepeat.TabIndex = 7;
            // 
            // cboHowOften
            // 
            this.cboHowOften.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cboHowOften.Font = new System.Drawing.Font("Impact", 8.25F);
            this.cboHowOften.FormattingEnabled = true;
            this.cboHowOften.Location = new System.Drawing.Point(316, 125);
            this.cboHowOften.Name = "cboHowOften";
            this.cboHowOften.Size = new System.Drawing.Size(147, 23);
            this.cboHowOften.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtName.Font = new System.Drawing.Font("Impact", 8.25F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.txtName.Location = new System.Drawing.Point(278, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 21);
            this.txtName.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Impact", 14F);
            this.lblType.Location = new System.Drawing.Point(206, 219);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(132, 23);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Reminder Type:";
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Font = new System.Drawing.Font("Impact", 14F);
            this.lblRepeat.Location = new System.Drawing.Point(469, 122);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(70, 23);
            this.lblRepeat.TabIndex = 3;
            this.lblRepeat.Text = "Repeat:";
            // 
            // lblHowOften
            // 
            this.lblHowOften.AutoSize = true;
            this.lblHowOften.Font = new System.Drawing.Font("Impact", 14F);
            this.lblHowOften.Location = new System.Drawing.Point(206, 122);
            this.lblHowOften.Name = "lblHowOften";
            this.lblHowOften.Size = new System.Drawing.Size(93, 23);
            this.lblHowOften.TabIndex = 2;
            this.lblHowOften.Text = "How Often:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Impact", 14F);
            this.lblName.Location = new System.Drawing.Point(206, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // frmAddReminder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.FormControlPanel);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.ContentPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddReminder";
            this.Text = "frmAddReminder";
            this.FormControlPanel.ResumeLayout(false);
            this.FormControlPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Label lblAddReminder;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboRepeat;
        private System.Windows.Forms.ComboBox cboHowOften;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblHowOften;
        private System.Windows.Forms.Label lblName;
    }
}