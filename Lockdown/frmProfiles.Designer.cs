namespace Lockdown
{
    partial class frmProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfiles));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.btnStopProfile = new System.Windows.Forms.Button();
            this.btnStartProfile = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.txtNewProfile = new System.Windows.Forms.TextBox();
            this.btnCancelCreateProfile = new System.Windows.Forms.Button();
            this.lblNewProfile = new System.Windows.Forms.Label();
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
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoImgBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NavigationPanel.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.BlockedWebPanel.SuspendLayout();
            this.BlockedAppPanel.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.btnStopProfile);
            this.NavigationPanel.Controls.Add(this.btnStartProfile);
            this.NavigationPanel.Controls.Add(this.panelProfile);
            this.NavigationPanel.Controls.Add(this.BlockedWebPanel);
            this.NavigationPanel.Controls.Add(this.BlockedAppPanel);
            this.NavigationPanel.Controls.Add(this.FormControlPanel);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPanel.Location = new System.Drawing.Point(200, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(530, 440);
            this.NavigationPanel.TabIndex = 5;
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
            this.btnStopProfile.Location = new System.Drawing.Point(344, 402);
            this.btnStopProfile.Name = "btnStopProfile";
            this.btnStopProfile.Size = new System.Drawing.Size(88, 32);
            this.btnStopProfile.TabIndex = 7;
            this.btnStopProfile.Text = "Stop Profile";
            this.btnStopProfile.UseVisualStyleBackColor = false;
            this.btnStopProfile.Click += new System.EventHandler(this.btnStopProfile_Click);
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
            this.btnStartProfile.Location = new System.Drawing.Point(438, 402);
            this.btnStartProfile.Name = "btnStartProfile";
            this.btnStartProfile.Size = new System.Drawing.Size(88, 32);
            this.btnStartProfile.TabIndex = 6;
            this.btnStartProfile.Text = "Start Profile";
            this.btnStartProfile.UseVisualStyleBackColor = false;
            this.btnStartProfile.Click += new System.EventHandler(this.btnStartProfile_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.btnCreateProfile);
            this.panelProfile.Controls.Add(this.txtNewProfile);
            this.panelProfile.Controls.Add(this.btnCancelCreateProfile);
            this.panelProfile.Controls.Add(this.lblNewProfile);
            this.panelProfile.Controls.Add(this.btnNewProfile);
            this.panelProfile.Controls.Add(this.cbProfiles);
            this.panelProfile.Controls.Add(this.lblProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 29);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(530, 94);
            this.panelProfile.TabIndex = 5;
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
            this.btnCreateProfile.Location = new System.Drawing.Point(450, 27);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(35, 42);
            this.btnCreateProfile.TabIndex = 13;
            this.btnCreateProfile.Text = "✓";
            this.btnCreateProfile.UseVisualStyleBackColor = false;
            this.btnCreateProfile.Visible = false;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // txtNewProfile
            // 
            this.txtNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtNewProfile.Location = new System.Drawing.Point(130, 27);
            this.txtNewProfile.Name = "txtNewProfile";
            this.txtNewProfile.Size = new System.Drawing.Size(318, 44);
            this.txtNewProfile.TabIndex = 12;
            this.txtNewProfile.Visible = false;
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
            this.btnCancelCreateProfile.Location = new System.Drawing.Point(491, 27);
            this.btnCancelCreateProfile.Name = "btnCancelCreateProfile";
            this.btnCancelCreateProfile.Size = new System.Drawing.Size(35, 42);
            this.btnCancelCreateProfile.TabIndex = 11;
            this.btnCancelCreateProfile.Text = "X";
            this.btnCancelCreateProfile.UseVisualStyleBackColor = false;
            this.btnCancelCreateProfile.Visible = false;
            this.btnCancelCreateProfile.Click += new System.EventHandler(this.btnCancelCreateProfile_Click);
            // 
            // lblNewProfile
            // 
            this.lblNewProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewProfile.AutoSize = true;
            this.lblNewProfile.Font = new System.Drawing.Font("Impact", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblNewProfile.Location = new System.Drawing.Point(3, 3);
            this.lblNewProfile.Name = "lblNewProfile";
            this.lblNewProfile.Size = new System.Drawing.Size(124, 88);
            this.lblNewProfile.TabIndex = 10;
            this.lblNewProfile.Text = "New\nProfile:";
            this.lblNewProfile.Visible = false;
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
            this.btnNewProfile.Location = new System.Drawing.Point(474, 27);
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
            this.lblProfile.Location = new System.Drawing.Point(6, 32);
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
            this.BlockedWebPanel.Location = new System.Drawing.Point(266, 129);
            this.BlockedWebPanel.Name = "BlockedWebPanel";
            this.BlockedWebPanel.Size = new System.Drawing.Size(260, 267);
            this.BlockedWebPanel.TabIndex = 5;
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
            // FormControlPanel
            // 
            this.FormControlPanel.Controls.Add(this.lblBack);
            this.FormControlPanel.Controls.Add(this.lblMinimize);
            this.FormControlPanel.Controls.Add(this.lblExit);
            this.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControlPanel.Location = new System.Drawing.Point(0, 0);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(530, 29);
            this.FormControlPanel.TabIndex = 3;
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
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.lblMinimize.Location = new System.Drawing.Point(493, 0);
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
            this.lblExit.Location = new System.Drawing.Point(509, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoImgBox);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 440);
            this.LogoPanel.TabIndex = 4;
            // 
            // LogoImgBox
            // 
            this.LogoImgBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoImgBox.Image")));
            this.LogoImgBox.Location = new System.Drawing.Point(12, 0);
            this.LogoImgBox.Name = "LogoImgBox";
            this.LogoImgBox.Size = new System.Drawing.Size(180, 440);
            this.LogoImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImgBox.TabIndex = 0;
            this.LogoImgBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // frmProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(730, 440);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lockdown";
            this.Load += new System.EventHandler(this.frmProfiles_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.BlockedWebPanel.ResumeLayout(false);
            this.BlockedAppPanel.ResumeLayout(false);
            this.FormControlPanel.ResumeLayout(false);
            this.FormControlPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox LogoImgBox;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.ListBox listBlockedApps;
        private System.Windows.Forms.Button btnUnblockApp;
        private System.Windows.Forms.Button btnAddBlockedApp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel BlockedWebPanel;
        private System.Windows.Forms.ListBox listBlockedWebsites;
        private System.Windows.Forms.Button btnUnblockWebsite;
        private System.Windows.Forms.Button btnAddBlockedWebsite;
        private System.Windows.Forms.Panel BlockedAppPanel;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button btnStartProfile;
        private System.Windows.Forms.ComboBox cbProfiles;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.TextBox txtNewProfile;
        private System.Windows.Forms.Button btnCancelCreateProfile;
        private System.Windows.Forms.Label lblNewProfile;
        private System.Windows.Forms.Button btnStopProfile;
    }
}