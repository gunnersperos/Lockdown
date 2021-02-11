namespace Lockdown
{
    partial class frmTabbed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabbed));
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tablessControl = new Lockdown.TablessControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReminders = new System.Windows.Forms.Button();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.tabProfiles = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLocked = new System.Windows.Forms.Panel();
            this.btnStopProfile = new System.Windows.Forms.Button();
            this.pictureLockDown = new System.Windows.Forms.PictureBox();
            this.lblProfileLocked = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btnStartProfile = new System.Windows.Forms.Button();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.cbProfiles = new System.Windows.Forms.ComboBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.BlockedWebPanel = new System.Windows.Forms.Panel();
            this.listBlockedWebsites = new System.Windows.Forms.ListBox();
            this.btnUnblockWebsite = new System.Windows.Forms.Button();
            this.btnAddBlockedWebsite = new System.Windows.Forms.Button();
            this.BlockedAppPanel = new System.Windows.Forms.Panel();
            this.listBlockedApps = new System.Windows.Forms.ListBox();
            this.btnUnblockApp = new System.Windows.Forms.Button();
            this.btnAddBlockedApp = new System.Windows.Forms.Button();
            this.tabAddProfile = new System.Windows.Forms.TabPage();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.txtNewProfile = new System.Windows.Forms.TextBox();
            this.btnCancelCreateProfile = new System.Windows.Forms.Button();
            this.lblNewProfile = new System.Windows.Forms.Label();
            this.tabReminders = new System.Windows.Forms.TabPage();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.lblDefaultReminders = new System.Windows.Forms.Label();
            this.lblMyReminders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clbDefaultReminders = new System.Windows.Forms.CheckedListBox();
            this.lblAddReminder = new System.Windows.Forms.Label();
            this.clbMyReminders = new System.Windows.Forms.CheckedListBox();
            this.tabAddReminder = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboHowOften = new System.Windows.Forms.ComboBox();
            this.txtNewReminderName = new System.Windows.Forms.TextBox();
            this.lblHowOften = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.ofdAddApp = new System.Windows.Forms.OpenFileDialog();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.panelMain.SuspendLayout();
            this.tablessControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.tabProfiles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLockDown)).BeginInit();
            this.panelProfile.SuspendLayout();
            this.BlockedWebPanel.SuspendLayout();
            this.BlockedAppPanel.SuspendLayout();
            this.tabAddProfile.SuspendLayout();
            this.tabReminders.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabAddReminder.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.NotifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoImgBox
            // 
            this.LogoImgBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoImgBox.Image")));
            this.LogoImgBox.Location = new System.Drawing.Point(12, -1);
            this.LogoImgBox.Name = "LogoImgBox";
            this.LogoImgBox.Size = new System.Drawing.Size(180, 440);
            this.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImgBox.TabIndex = 1;
            this.LogoImgBox.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tablessControl);
            this.panelMain.Controls.Add(this.FormControlPanel);
            this.panelMain.Location = new System.Drawing.Point(199, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(528, 440);
            this.panelMain.TabIndex = 3;
            // 
            // tablessControl
            // 
            this.tablessControl.Controls.Add(this.tabMain);
            this.tablessControl.Controls.Add(this.tabProfiles);
            this.tablessControl.Controls.Add(this.tabAddProfile);
            this.tablessControl.Controls.Add(this.tabReminders);
            this.tablessControl.Controls.Add(this.tabAddReminder);
            this.tablessControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tablessControl.Location = new System.Drawing.Point(4, 23);
            this.tablessControl.Name = "tablessControl";
            this.tablessControl.SelectedIndex = 0;
            this.tablessControl.Size = new System.Drawing.Size(524, 414);
            this.tablessControl.TabIndex = 5;
            this.tablessControl.SelectedIndexChanged += new System.EventHandler(this.tablessControl_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.tabMain.Controls.Add(this.NavigationPanel);
            this.tabMain.Location = new System.Drawing.Point(4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(516, 405);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "tabPage1";
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.btnSettings);
            this.NavigationPanel.Controls.Add(this.btnReminders);
            this.NavigationPanel.Controls.Add(this.btnScheduler);
            this.NavigationPanel.Controls.Add(this.btnProfiles);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPanel.Location = new System.Drawing.Point(3, 3);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(510, 399);
            this.NavigationPanel.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Impact", 22F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnSettings.Location = new System.Drawing.Point(6, 294);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(516, 103);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnReminders
            // 
            this.btnReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnReminders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReminders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnReminders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnReminders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnReminders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReminders.Font = new System.Drawing.Font("Impact", 22F);
            this.btnReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnReminders.Location = new System.Drawing.Point(6, 198);
            this.btnReminders.Name = "btnReminders";
            this.btnReminders.Size = new System.Drawing.Size(516, 103);
            this.btnReminders.TabIndex = 3;
            this.btnReminders.Text = "Reminders";
            this.btnReminders.UseVisualStyleBackColor = false;
            this.btnReminders.Click += new System.EventHandler(this.btnReminders_Click);
            // 
            // btnScheduler
            // 
            this.btnScheduler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnScheduler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScheduler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnScheduler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnScheduler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduler.Font = new System.Drawing.Font("Impact", 22F);
            this.btnScheduler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnScheduler.Location = new System.Drawing.Point(6, 102);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(516, 103);
            this.btnScheduler.TabIndex = 2;
            this.btnScheduler.Text = "Scheduler";
            this.btnScheduler.UseVisualStyleBackColor = false;
            // 
            // btnProfiles
            // 
            this.btnProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnProfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnProfiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnProfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.Font = new System.Drawing.Font("Impact", 22F);
            this.btnProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnProfiles.Location = new System.Drawing.Point(6, 6);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(516, 103);
            this.btnProfiles.TabIndex = 0;
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.UseVisualStyleBackColor = false;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // tabProfiles
            // 
            this.tabProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.tabProfiles.Controls.Add(this.panelLocked);
            this.tabProfiles.Controls.Add(this.panel1);
            this.tabProfiles.Location = new System.Drawing.Point(4, 5);
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiles.Size = new System.Drawing.Size(516, 405);
            this.tabProfiles.TabIndex = 1;
            this.tabProfiles.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStartProfile);
            this.panel1.Controls.Add(this.panelProfile);
            this.panel1.Controls.Add(this.BlockedWebPanel);
            this.panel1.Controls.Add(this.BlockedAppPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 399);
            this.panel1.TabIndex = 6;
            // 
            // panelLocked
            // 
            this.panelLocked.Controls.Add(this.btnStopProfile);
            this.panelLocked.Controls.Add(this.pictureLockDown);
            this.panelLocked.Controls.Add(this.lblProfileLocked);
            this.panelLocked.Location = new System.Drawing.Point(3, 89);
            this.panelLocked.Name = "panelLocked";
            this.panelLocked.Size = new System.Drawing.Size(510, 316);
            this.panelLocked.TabIndex = 6;
            this.panelLocked.Visible = false;
            // 
            // btnStopProfile
            // 
            this.btnStopProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnStopProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnStopProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnStopProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnStopProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopProfile.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnStopProfile.Location = new System.Drawing.Point(215, 264);
            this.btnStopProfile.Name = "btnStopProfile";
            this.btnStopProfile.Size = new System.Drawing.Size(88, 32);
            this.btnStopProfile.TabIndex = 8;
            this.btnStopProfile.Text = "Stop Profile";
            this.btnStopProfile.UseVisualStyleBackColor = false;
            this.btnStopProfile.Visible = false;
            this.btnStopProfile.Click += new System.EventHandler(this.btnStopProfile_Click);
            // 
            // pictureLockDown
            // 
            this.pictureLockDown.Image = global::Lockdown.Properties.Resources.Lock_Down_Arrow_cropped;
            this.pictureLockDown.Location = new System.Drawing.Point(161, 81);
            this.pictureLockDown.Name = "pictureLockDown";
            this.pictureLockDown.Size = new System.Drawing.Size(187, 178);
            this.pictureLockDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLockDown.TabIndex = 1;
            this.pictureLockDown.TabStop = false;
            // 
            // lblProfileLocked
            // 
            this.lblProfileLocked.AutoSize = true;
            this.lblProfileLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileLocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblProfileLocked.Location = new System.Drawing.Point(65, 32);
            this.lblProfileLocked.Name = "lblProfileLocked";
            this.lblProfileLocked.Size = new System.Drawing.Size(383, 46);
            this.lblProfileLocked.TabIndex = 0;
            this.lblProfileLocked.Text = "Profile on Lockdown";
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.btnNewProfile);
            this.panelProfile.Controls.Add(this.cbProfiles);
            this.panelProfile.Controls.Add(this.lblProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(510, 94);
            this.panelProfile.TabIndex = 5;
            // 
            // btnStartProfile
            // 
            this.btnStartProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnStartProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnStartProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnStartProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnStartProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartProfile.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnStartProfile.Location = new System.Drawing.Point(130, 83);
            this.btnStartProfile.Name = "btnStartProfile";
            this.btnStartProfile.Size = new System.Drawing.Size(88, 32);
            this.btnStartProfile.TabIndex = 6;
            this.btnStartProfile.Text = "Start Profile";
            this.btnStartProfile.UseVisualStyleBackColor = false;
            this.btnStartProfile.Visible = false;
            this.btnStartProfile.Click += new System.EventHandler(this.btnStartProfile_Click);
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnNewProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnNewProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnNewProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProfile.Font = new System.Drawing.Font("Impact", 22F);
            this.btnNewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnNewProfile.Location = new System.Drawing.Point(461, 27);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(35, 50);
            this.btnNewProfile.TabIndex = 8;
            this.btnNewProfile.Text = "+";
            this.btnNewProfile.UseVisualStyleBackColor = false;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // cbProfiles
            // 
            this.cbProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.cbProfiles.DropDownHeight = 200;
            this.cbProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cbProfiles.FormattingEnabled = true;
            this.cbProfiles.IntegralHeight = false;
            this.cbProfiles.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3"});
            this.cbProfiles.Location = new System.Drawing.Point(130, 27);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Size = new System.Drawing.Size(318, 50);
            this.cbProfiles.TabIndex = 7;
            this.cbProfiles.SelectedIndexChanged += new System.EventHandler(this.cbProfiles_SelectedIndexChanged);
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblProfile.Location = new System.Drawing.Point(-4, 27);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(128, 45);
            this.lblProfile.TabIndex = 6;
            this.lblProfile.Text = "Profile:";
            // 
            // BlockedWebPanel
            // 
            this.BlockedWebPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockedWebPanel.Controls.Add(this.listBlockedWebsites);
            this.BlockedWebPanel.Controls.Add(this.btnUnblockWebsite);
            this.BlockedWebPanel.Controls.Add(this.btnAddBlockedWebsite);
            this.BlockedWebPanel.Location = new System.Drawing.Point(246, 129);
            this.BlockedWebPanel.Name = "BlockedWebPanel";
            this.BlockedWebPanel.Size = new System.Drawing.Size(260, 267);
            this.BlockedWebPanel.TabIndex = 5;
            this.BlockedWebPanel.Visible = false;
            // 
            // listBlockedWebsites
            // 
            this.listBlockedWebsites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.listBlockedWebsites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBlockedWebsites.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBlockedWebsites.Font = new System.Drawing.Font("Impact", 10F);
            this.listBlockedWebsites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.listBlockedWebsites.FormattingEnabled = true;
            this.listBlockedWebsites.ItemHeight = 17;
            this.listBlockedWebsites.Location = new System.Drawing.Point(0, 0);
            this.listBlockedWebsites.Name = "listBlockedWebsites";
            this.listBlockedWebsites.Size = new System.Drawing.Size(260, 189);
            this.listBlockedWebsites.TabIndex = 1;
            // 
            // btnUnblockWebsite
            // 
            this.btnUnblockWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnUnblockWebsite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUnblockWebsite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnUnblockWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnUnblockWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnUnblockWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnblockWebsite.Font = new System.Drawing.Font("Impact", 10F);
            this.btnUnblockWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnUnblockWebsite.Location = new System.Drawing.Point(0, 209);
            this.btnUnblockWebsite.Name = "btnUnblockWebsite";
            this.btnUnblockWebsite.Size = new System.Drawing.Size(260, 29);
            this.btnUnblockWebsite.TabIndex = 3;
            this.btnUnblockWebsite.Text = "Unblock Website";
            this.btnUnblockWebsite.UseVisualStyleBackColor = false;
            this.btnUnblockWebsite.Click += new System.EventHandler(this.btnUnblockWebsite_Click);
            // 
            // btnAddBlockedWebsite
            // 
            this.btnAddBlockedWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnAddBlockedWebsite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBlockedWebsite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnAddBlockedWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnAddBlockedWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnAddBlockedWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBlockedWebsite.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBlockedWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnAddBlockedWebsite.Location = new System.Drawing.Point(0, 238);
            this.btnAddBlockedWebsite.Name = "btnAddBlockedWebsite";
            this.btnAddBlockedWebsite.Size = new System.Drawing.Size(260, 29);
            this.btnAddBlockedWebsite.TabIndex = 2;
            this.btnAddBlockedWebsite.Text = "Block Website";
            this.btnAddBlockedWebsite.UseVisualStyleBackColor = false;
            this.btnAddBlockedWebsite.Click += new System.EventHandler(this.btnAddBlockedWebsite_Click);
            // 
            // BlockedAppPanel
            // 
            this.BlockedAppPanel.Controls.Add(this.listBlockedApps);
            this.BlockedAppPanel.Controls.Add(this.btnUnblockApp);
            this.BlockedAppPanel.Controls.Add(this.btnAddBlockedApp);
            this.BlockedAppPanel.Location = new System.Drawing.Point(0, 129);
            this.BlockedAppPanel.Name = "BlockedAppPanel";
            this.BlockedAppPanel.Size = new System.Drawing.Size(260, 267);
            this.BlockedAppPanel.TabIndex = 4;
            this.BlockedAppPanel.Visible = false;
            // 
            // listBlockedApps
            // 
            this.listBlockedApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.listBlockedApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBlockedApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBlockedApps.Font = new System.Drawing.Font("Impact", 10F);
            this.listBlockedApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.listBlockedApps.FormattingEnabled = true;
            this.listBlockedApps.ItemHeight = 17;
            this.listBlockedApps.Location = new System.Drawing.Point(0, 0);
            this.listBlockedApps.Name = "listBlockedApps";
            this.listBlockedApps.Size = new System.Drawing.Size(260, 189);
            this.listBlockedApps.TabIndex = 1;
            // 
            // btnUnblockApp
            // 
            this.btnUnblockApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnUnblockApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUnblockApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnUnblockApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnUnblockApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnUnblockApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnblockApp.Font = new System.Drawing.Font("Impact", 10F);
            this.btnUnblockApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnUnblockApp.Location = new System.Drawing.Point(0, 209);
            this.btnUnblockApp.Name = "btnUnblockApp";
            this.btnUnblockApp.Size = new System.Drawing.Size(260, 29);
            this.btnUnblockApp.TabIndex = 2;
            this.btnUnblockApp.Text = "Unblock App";
            this.btnUnblockApp.UseVisualStyleBackColor = false;
            this.btnUnblockApp.Click += new System.EventHandler(this.btnUnblockApp_Click);
            // 
            // btnAddBlockedApp
            // 
            this.btnAddBlockedApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnAddBlockedApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBlockedApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnAddBlockedApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnAddBlockedApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnAddBlockedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBlockedApp.Font = new System.Drawing.Font("Impact", 10F);
            this.btnAddBlockedApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnAddBlockedApp.Location = new System.Drawing.Point(0, 238);
            this.btnAddBlockedApp.Name = "btnAddBlockedApp";
            this.btnAddBlockedApp.Size = new System.Drawing.Size(260, 29);
            this.btnAddBlockedApp.TabIndex = 3;
            this.btnAddBlockedApp.Text = "Block App";
            this.btnAddBlockedApp.UseVisualStyleBackColor = false;
            this.btnAddBlockedApp.Click += new System.EventHandler(this.btnAddBlockedApp_Click);
            // 
            // tabAddProfile
            // 
            this.tabAddProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.tabAddProfile.Controls.Add(this.btnCreateProfile);
            this.tabAddProfile.Controls.Add(this.txtNewProfile);
            this.tabAddProfile.Controls.Add(this.btnCancelCreateProfile);
            this.tabAddProfile.Controls.Add(this.lblNewProfile);
            this.tabAddProfile.Location = new System.Drawing.Point(4, 5);
            this.tabAddProfile.Name = "tabAddProfile";
            this.tabAddProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProfile.Size = new System.Drawing.Size(516, 405);
            this.tabAddProfile.TabIndex = 2;
            this.tabAddProfile.Text = "tabPage1";
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnCreateProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnCreateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnCreateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProfile.Font = new System.Drawing.Font("Impact", 22F);
            this.btnCreateProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnCreateProfile.Location = new System.Drawing.Point(397, 220);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(35, 42);
            this.btnCreateProfile.TabIndex = 17;
            this.btnCreateProfile.Text = "✓";
            this.btnCreateProfile.UseVisualStyleBackColor = false;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // txtNewProfile
            // 
            this.txtNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtNewProfile.Location = new System.Drawing.Point(114, 170);
            this.txtNewProfile.Name = "txtNewProfile";
            this.txtNewProfile.Size = new System.Drawing.Size(318, 44);
            this.txtNewProfile.TabIndex = 16;
            // 
            // btnCancelCreateProfile
            // 
            this.btnCancelCreateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnCancelCreateProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.btnCancelCreateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnCancelCreateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.btnCancelCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCreateProfile.Font = new System.Drawing.Font("Impact", 22F);
            this.btnCancelCreateProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnCancelCreateProfile.Location = new System.Drawing.Point(356, 220);
            this.btnCancelCreateProfile.Name = "btnCancelCreateProfile";
            this.btnCancelCreateProfile.Size = new System.Drawing.Size(35, 42);
            this.btnCancelCreateProfile.TabIndex = 15;
            this.btnCancelCreateProfile.Text = "X";
            this.btnCancelCreateProfile.UseVisualStyleBackColor = false;
            this.btnCancelCreateProfile.Click += new System.EventHandler(this.btnCancelCreateProfile_Click);
            // 
            // lblNewProfile
            // 
            this.lblNewProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewProfile.AutoSize = true;
            this.lblNewProfile.Font = new System.Drawing.Font("Impact", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblNewProfile.Location = new System.Drawing.Point(207, 53);
            this.lblNewProfile.Name = "lblNewProfile";
            this.lblNewProfile.Size = new System.Drawing.Size(124, 88);
            this.lblNewProfile.TabIndex = 14;
            this.lblNewProfile.Text = "New\nProfile:";
            // 
            // tabReminders
            // 
            this.tabReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.tabReminders.Controls.Add(this.ContentPanel);
            this.tabReminders.Location = new System.Drawing.Point(4, 5);
            this.tabReminders.Name = "tabReminders";
            this.tabReminders.Padding = new System.Windows.Forms.Padding(3);
            this.tabReminders.Size = new System.Drawing.Size(516, 405);
            this.tabReminders.TabIndex = 3;
            this.tabReminders.Text = "Reminders";
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.lblDefaultReminders);
            this.ContentPanel.Controls.Add(this.lblMyReminders);
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(3, 3);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(510, 399);
            this.ContentPanel.TabIndex = 3;
            // 
            // lblDefaultReminders
            // 
            this.lblDefaultReminders.AutoSize = true;
            this.lblDefaultReminders.Font = new System.Drawing.Font("Impact", 16F);
            this.lblDefaultReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblDefaultReminders.Location = new System.Drawing.Point(40, 3);
            this.lblDefaultReminders.Name = "lblDefaultReminders";
            this.lblDefaultReminders.Size = new System.Drawing.Size(179, 27);
            this.lblDefaultReminders.TabIndex = 4;
            this.lblDefaultReminders.Text = "Default Reminders";
            // 
            // lblMyReminders
            // 
            this.lblMyReminders.AutoSize = true;
            this.lblMyReminders.Font = new System.Drawing.Font("Impact", 16F);
            this.lblMyReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblMyReminders.Location = new System.Drawing.Point(330, 3);
            this.lblMyReminders.Name = "lblMyReminders";
            this.lblMyReminders.Size = new System.Drawing.Size(140, 27);
            this.lblMyReminders.TabIndex = 3;
            this.lblMyReminders.Text = "My Reminders";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clbDefaultReminders);
            this.panel2.Controls.Add(this.lblAddReminder);
            this.panel2.Controls.Add(this.clbMyReminders);
            this.panel2.Location = new System.Drawing.Point(6, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 366);
            this.panel2.TabIndex = 1;
            // 
            // clbDefaultReminders
            // 
            this.clbDefaultReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.clbDefaultReminders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbDefaultReminders.CheckOnClick = true;
            this.clbDefaultReminders.Font = new System.Drawing.Font("Impact", 10F);
            this.clbDefaultReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.clbDefaultReminders.FormattingEnabled = true;
            this.clbDefaultReminders.Location = new System.Drawing.Point(3, 3);
            this.clbDefaultReminders.Name = "clbDefaultReminders";
            this.clbDefaultReminders.Size = new System.Drawing.Size(243, 268);
            this.clbDefaultReminders.TabIndex = 3;
            // 
            // lblAddReminder
            // 
            this.lblAddReminder.AutoSize = true;
            this.lblAddReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.lblAddReminder.Location = new System.Drawing.Point(482, 242);
            this.lblAddReminder.Name = "lblAddReminder";
            this.lblAddReminder.Size = new System.Drawing.Size(25, 26);
            this.lblAddReminder.TabIndex = 2;
            this.lblAddReminder.Text = "+";
            this.lblAddReminder.Click += new System.EventHandler(this.lblAddReminder_Click);
            // 
            // clbMyReminders
            // 
            this.clbMyReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.clbMyReminders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbMyReminders.CheckOnClick = true;
            this.clbMyReminders.Font = new System.Drawing.Font("Impact", 10F);
            this.clbMyReminders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.clbMyReminders.FormattingEnabled = true;
            this.clbMyReminders.Location = new System.Drawing.Point(269, 3);
            this.clbMyReminders.Name = "clbMyReminders";
            this.clbMyReminders.Size = new System.Drawing.Size(243, 268);
            this.clbMyReminders.TabIndex = 1;
            this.clbMyReminders.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMyReminders_ItemCheck);
            this.clbMyReminders.Click += new System.EventHandler(this.clbMyReminders_Click);
            this.clbMyReminders.SelectedIndexChanged += new System.EventHandler(this.clbMyReminders_SelectedIndexChanged);
            // 
            // tabAddReminder
            // 
            this.tabAddReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.tabAddReminder.Controls.Add(this.btnSave);
            this.tabAddReminder.Controls.Add(this.btnCancel);
            this.tabAddReminder.Controls.Add(this.cboHowOften);
            this.tabAddReminder.Controls.Add(this.txtNewReminderName);
            this.tabAddReminder.Controls.Add(this.lblHowOften);
            this.tabAddReminder.Controls.Add(this.lblName);
            this.tabAddReminder.Location = new System.Drawing.Point(4, 5);
            this.tabAddReminder.Name = "tabAddReminder";
            this.tabAddReminder.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddReminder.Size = new System.Drawing.Size(516, 405);
            this.tabAddReminder.TabIndex = 4;
            this.tabAddReminder.Text = "AddReminder";
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
            this.btnSave.Location = new System.Drawing.Point(260, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 41);
            this.btnSave.TabIndex = 16;
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
            this.btnCancel.Location = new System.Drawing.Point(132, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 41);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboHowOften
            // 
            this.cboHowOften.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cboHowOften.Font = new System.Drawing.Font("Impact", 8.25F);
            this.cboHowOften.FormattingEnabled = true;
            this.cboHowOften.Location = new System.Drawing.Point(238, 95);
            this.cboHowOften.Name = "cboHowOften";
            this.cboHowOften.Size = new System.Drawing.Size(147, 23);
            this.cboHowOften.TabIndex = 14;
            // 
            // txtNewReminderName
            // 
            this.txtNewReminderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNewReminderName.Font = new System.Drawing.Font("Impact", 8.25F);
            this.txtNewReminderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.txtNewReminderName.Location = new System.Drawing.Point(200, 7);
            this.txtNewReminderName.Name = "txtNewReminderName";
            this.txtNewReminderName.Size = new System.Drawing.Size(185, 21);
            this.txtNewReminderName.TabIndex = 13;
            // 
            // lblHowOften
            // 
            this.lblHowOften.AutoSize = true;
            this.lblHowOften.Font = new System.Drawing.Font("Impact", 14F);
            this.lblHowOften.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblHowOften.Location = new System.Drawing.Point(135, 95);
            this.lblHowOften.Name = "lblHowOften";
            this.lblHowOften.Size = new System.Drawing.Size(93, 23);
            this.lblHowOften.TabIndex = 12;
            this.lblHowOften.Text = "How Often:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Impact", 14F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblName.Location = new System.Drawing.Point(135, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 23);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblBack);
            this.FormControlPanel.Controls.Add(this.lblMinimize);
            this.FormControlPanel.Controls.Add(this.lblExit);
            this.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControlPanel.Location = new System.Drawing.Point(0, 0);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(528, 20);
            this.FormControlPanel.TabIndex = 4;
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
            this.lblBack.TabIndex = 2;
            this.lblBack.Text = "◁";
            this.lblBack.Visible = false;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblMinimize.Location = new System.Drawing.Point(491, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(16, 20);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "–";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblExit.Location = new System.Drawing.Point(507, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // ofdAddApp
            // 
            this.ofdAddApp.InitialDirectory = "@\"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\"";
            this.ofdAddApp.ReadOnlyChecked = true;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.BalloonTipText = "Lockdown";
            this.NotifyIcon.BalloonTipTitle = "Lockdown";
            this.NotifyIcon.ContextMenuStrip = this.NotifyIconMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Lockdown";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // NotifyIconMenu
            // 
            this.NotifyIconMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.HelpBalloon;
            this.NotifyIconMenu.AllowMerge = false;
            this.NotifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemClose});
            this.NotifyIconMenu.Name = "NotifyIconMenu";
            this.NotifyIconMenu.ShowImageMargin = false;
            this.NotifyIconMenu.Size = new System.Drawing.Size(79, 26);
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.Size = new System.Drawing.Size(78, 22);
            this.MenuItemClose.Text = "Close";
            this.MenuItemClose.Click += new System.EventHandler(this.MenuItemClose_Click);
            // 
            // frmTabbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.LogoImgBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTabbed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTabbed";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.tablessControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.tabProfiles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLocked.ResumeLayout(false);
            this.panelLocked.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLockDown)).EndInit();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.BlockedWebPanel.ResumeLayout(false);
            this.BlockedAppPanel.ResumeLayout(false);
            this.tabAddProfile.ResumeLayout(false);
            this.tabAddProfile.PerformLayout();
            this.tabReminders.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabAddReminder.ResumeLayout(false);
            this.tabAddReminder.PerformLayout();
            this.FormControlPanel.ResumeLayout(false);
            this.FormControlPanel.PerformLayout();
            this.NotifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private TablessControl tablessControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabProfiles;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReminders;
        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button btnStartProfile;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel BlockedWebPanel;
        private System.Windows.Forms.ListBox listBlockedWebsites;
        private System.Windows.Forms.Button btnUnblockWebsite;
        private System.Windows.Forms.Button btnAddBlockedWebsite;
        private System.Windows.Forms.Panel BlockedAppPanel;
        private System.Windows.Forms.ListBox listBlockedApps;
        private System.Windows.Forms.Button btnUnblockApp;
        private System.Windows.Forms.Button btnAddBlockedApp;
        private System.Windows.Forms.TabPage tabAddProfile;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.TextBox txtNewProfile;
        private System.Windows.Forms.Button btnCancelCreateProfile;
        private System.Windows.Forms.Label lblNewProfile;
        private System.Windows.Forms.Panel panelLocked;
        private System.Windows.Forms.PictureBox pictureLockDown;
        private System.Windows.Forms.Label lblProfileLocked;
        private System.Windows.Forms.Button btnStopProfile;
        private System.Windows.Forms.OpenFileDialog ofdAddApp;
        private System.Windows.Forms.TabPage tabReminders;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label lblDefaultReminders;
        private System.Windows.Forms.Label lblMyReminders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox clbDefaultReminders;
        private System.Windows.Forms.Label lblAddReminder;
        private System.Windows.Forms.CheckedListBox clbMyReminders;
        private System.Windows.Forms.TabPage tabAddReminder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboHowOften;
        private System.Windows.Forms.TextBox txtNewReminderName;
        private System.Windows.Forms.Label lblHowOften;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
    }
}