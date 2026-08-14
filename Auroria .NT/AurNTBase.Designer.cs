namespace Auroria.NT
{
    partial class AurNTBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AurNTBase));
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.PlayTab = new System.Windows.Forms.TabPage();
            this.ClientPictureBox = new System.Windows.Forms.PictureBox();
            this.ClientInfoPanel = new System.Windows.Forms.Panel();
            this.ClientInfoBox = new System.Windows.Forms.RichTextBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.HostBtn = new System.Windows.Forms.Button();
            this.SrvrIPbox = new System.Windows.Forms.TextBox();
            this.JoinBtn = new System.Windows.Forms.Button();
            this.PlyrTab = new System.Windows.Forms.TabPage();
            this.UserNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerIDBox = new System.Windows.Forms.TextBox();
            this.PlayerNameBox = new System.Windows.Forms.TextBox();
            this.CatalogTab = new System.Windows.Forms.TabPage();
            this.CatalogTabsOptions = new System.Windows.Forms.TabControl();
            this.HatTab = new System.Windows.Forms.TabPage();
            this.TshrtTab = new System.Windows.Forms.TabPage();
            this.ShrtTab = new System.Windows.Forms.TabPage();
            this.PntTab = new System.Windows.Forms.TabPage();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.PacksTab = new System.Windows.Forms.TabPage();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.CrditTab = new System.Windows.Forms.TabPage();
            this.DCButton = new System.Windows.Forms.Button();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.MapsTree = new System.Windows.Forms.TreeView();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.MOTD = new System.Windows.Forms.Label();
            this.HeadsTab = new System.Windows.Forms.TabPage();
            this.FaceTab = new System.Windows.Forms.TabPage();
            this.PckgeTab = new System.Windows.Forms.TabPage();
            this.HatsListView = new System.Windows.Forms.ListView();
            this.AllTabs.SuspendLayout();
            this.PlayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).BeginInit();
            this.ClientInfoPanel.SuspendLayout();
            this.PlyrTab.SuspendLayout();
            this.CatalogTab.SuspendLayout();
            this.CatalogTabsOptions.SuspendLayout();
            this.HatTab.SuspendLayout();
            this.CrditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.PlayTab);
            this.AllTabs.Controls.Add(this.PlyrTab);
            this.AllTabs.Controls.Add(this.CatalogTab);
            this.AllTabs.Controls.Add(this.InfoTab);
            this.AllTabs.Controls.Add(this.PacksTab);
            this.AllTabs.Controls.Add(this.SettingTab);
            this.AllTabs.Controls.Add(this.CrditTab);
            this.AllTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllTabs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTabs.HotTrack = true;
            this.AllTabs.ItemSize = new System.Drawing.Size(69, 30);
            this.AllTabs.Location = new System.Drawing.Point(12, 189);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.ShowToolTips = true;
            this.AllTabs.Size = new System.Drawing.Size(503, 425);
            this.AllTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AllTabs.TabIndex = 0;
            // 
            // PlayTab
            // 
            this.PlayTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayTab.Controls.Add(this.ClientPictureBox);
            this.PlayTab.Controls.Add(this.ClientInfoPanel);
            this.PlayTab.Controls.Add(this.ClientList);
            this.PlayTab.Controls.Add(this.HostBtn);
            this.PlayTab.Controls.Add(this.SrvrIPbox);
            this.PlayTab.Controls.Add(this.JoinBtn);
            this.PlayTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayTab.Location = new System.Drawing.Point(4, 34);
            this.PlayTab.Name = "PlayTab";
            this.PlayTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayTab.Size = new System.Drawing.Size(495, 387);
            this.PlayTab.TabIndex = 0;
            this.PlayTab.Text = "Play/Host";
            this.PlayTab.ToolTipText = "Contains the Play/Host options.";
            this.PlayTab.Click += new System.EventHandler(this.PlayPage_Click);
            // 
            // ClientPictureBox
            // 
            this.ClientPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientPictureBox.Location = new System.Drawing.Point(6, 41);
            this.ClientPictureBox.Name = "ClientPictureBox";
            this.ClientPictureBox.Size = new System.Drawing.Size(275, 158);
            this.ClientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientPictureBox.TabIndex = 14;
            this.ClientPictureBox.TabStop = false;
            this.ClientPictureBox.Click += new System.EventHandler(this.ClientPictureBox_Click);
            // 
            // ClientInfoPanel
            // 
            this.ClientInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientInfoPanel.Controls.Add(this.ClientInfoBox);
            this.ClientInfoPanel.Location = new System.Drawing.Point(6, 208);
            this.ClientInfoPanel.Name = "ClientInfoPanel";
            this.ClientInfoPanel.Size = new System.Drawing.Size(276, 76);
            this.ClientInfoPanel.TabIndex = 13;
            // 
            // ClientInfoBox
            // 
            this.ClientInfoBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientInfoBox.Location = new System.Drawing.Point(3, 3);
            this.ClientInfoBox.Name = "ClientInfoBox";
            this.ClientInfoBox.ReadOnly = true;
            this.ClientInfoBox.Size = new System.Drawing.Size(266, 66);
            this.ClientInfoBox.TabIndex = 0;
            this.ClientInfoBox.Text = "Client Info will be displayed here.";
            this.ClientInfoBox.TextChanged += new System.EventHandler(this.ClientInfoBox_TextChanged);
            // 
            // ClientList
            // 
            this.ClientList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 16;
            this.ClientList.Items.AddRange(new object[] {
            "2007S",
            "2007E [NF]",
            "2007M [NF]",
            "2007L [NF]",
            "2008E [NF]",
            "2008M [NF]",
            "2008L [NF]",
            "2009E [NF]"});
            this.ClientList.Location = new System.Drawing.Point(288, 41);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(201, 340);
            this.ClientList.TabIndex = 12;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // HostBtn
            // 
            this.HostBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HostBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HostBtn.BackColor = System.Drawing.Color.Transparent;
            this.HostBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HostBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostBtn.FlatAppearance.BorderSize = 0;
            this.HostBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HostBtn.Image = ((System.Drawing.Image)(resources.GetObject("HostBtn.Image")));
            this.HostBtn.Location = new System.Drawing.Point(148, 334);
            this.HostBtn.Name = "HostBtn";
            this.HostBtn.Size = new System.Drawing.Size(125, 47);
            this.HostBtn.TabIndex = 8;
            this.HostBtn.TabStop = false;
            this.HostBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HostBtn.UseMnemonic = false;
            this.HostBtn.UseVisualStyleBackColor = false;
            this.HostBtn.Click += new System.EventHandler(this.HostBtn_Click);
            // 
            // SrvrIPbox
            // 
            this.SrvrIPbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SrvrIPbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SrvrIPbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrvrIPbox.Location = new System.Drawing.Point(6, 303);
            this.SrvrIPbox.Name = "SrvrIPbox";
            this.SrvrIPbox.Size = new System.Drawing.Size(276, 25);
            this.SrvrIPbox.TabIndex = 11;
            this.SrvrIPbox.Text = "localhost:53640";
            this.SrvrIPbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JoinBtn
            // 
            this.JoinBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.JoinBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.JoinBtn.BackColor = System.Drawing.Color.Transparent;
            this.JoinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JoinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinBtn.FlatAppearance.BorderSize = 0;
            this.JoinBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JoinBtn.Image = ((System.Drawing.Image)(resources.GetObject("JoinBtn.Image")));
            this.JoinBtn.Location = new System.Drawing.Point(17, 334);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(125, 47);
            this.JoinBtn.TabIndex = 9;
            this.JoinBtn.TabStop = false;
            this.JoinBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.JoinBtn.UseMnemonic = false;
            this.JoinBtn.UseVisualStyleBackColor = false;
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_click);
            // 
            // PlyrTab
            // 
            this.PlyrTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlyrTab.Controls.Add(this.UserNote);
            this.PlyrTab.Controls.Add(this.label1);
            this.PlyrTab.Controls.Add(this.PlayerIDBox);
            this.PlyrTab.Controls.Add(this.PlayerNameBox);
            this.PlyrTab.Location = new System.Drawing.Point(4, 34);
            this.PlyrTab.Name = "PlyrTab";
            this.PlyrTab.Size = new System.Drawing.Size(495, 387);
            this.PlyrTab.TabIndex = 5;
            this.PlyrTab.Text = "Player";
            this.PlyrTab.ToolTipText = "Adjust things such as your name or ID, and avatar!";
            // 
            // UserNote
            // 
            this.UserNote.AutoSize = true;
            this.UserNote.BackColor = System.Drawing.Color.Transparent;
            this.UserNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNote.Location = new System.Drawing.Point(149, 5);
            this.UserNote.Name = "UserNote";
            this.UserNote.Size = new System.Drawing.Size(66, 15);
            this.UserNote.TabIndex = 11;
            this.UserNote.Text = "Username";
            this.UserNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "User ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerIDBox
            // 
            this.PlayerIDBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlayerIDBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerIDBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIDBox.Location = new System.Drawing.Point(16, 23);
            this.PlayerIDBox.MaxLength = 30;
            this.PlayerIDBox.Name = "PlayerIDBox";
            this.PlayerIDBox.Size = new System.Drawing.Size(113, 23);
            this.PlayerIDBox.TabIndex = 9;
            this.PlayerIDBox.Text = "123456789";
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlayerNameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerNameBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameBox.Location = new System.Drawing.Point(152, 23);
            this.PlayerNameBox.MaxLength = 20;
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(118, 23);
            this.PlayerNameBox.TabIndex = 10;
            this.PlayerNameBox.Text = "Username";
            this.PlayerNameBox.TextChanged += new System.EventHandler(this.PlayerNameBox_TextChanged);
            // 
            // CatalogTab
            // 
            this.CatalogTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CatalogTab.Controls.Add(this.CatalogTabsOptions);
            this.CatalogTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.CatalogTab.Location = new System.Drawing.Point(4, 34);
            this.CatalogTab.Name = "CatalogTab";
            this.CatalogTab.Padding = new System.Windows.Forms.Padding(3);
            this.CatalogTab.Size = new System.Drawing.Size(495, 387);
            this.CatalogTab.TabIndex = 2;
            this.CatalogTab.Text = "Catalog";
            this.CatalogTab.ToolTipText = "Catalog to get clothes n stuff";
            // 
            // CatalogTabsOptions
            // 
            this.CatalogTabsOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CatalogTabsOptions.Controls.Add(this.HatTab);
            this.CatalogTabsOptions.Controls.Add(this.HeadsTab);
            this.CatalogTabsOptions.Controls.Add(this.FaceTab);
            this.CatalogTabsOptions.Controls.Add(this.TshrtTab);
            this.CatalogTabsOptions.Controls.Add(this.ShrtTab);
            this.CatalogTabsOptions.Controls.Add(this.PntTab);
            this.CatalogTabsOptions.Controls.Add(this.PckgeTab);
            this.CatalogTabsOptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.CatalogTabsOptions.HotTrack = true;
            this.CatalogTabsOptions.ItemSize = new System.Drawing.Size(68, 30);
            this.CatalogTabsOptions.Location = new System.Drawing.Point(6, 6);
            this.CatalogTabsOptions.Name = "CatalogTabsOptions";
            this.CatalogTabsOptions.SelectedIndex = 0;
            this.CatalogTabsOptions.Size = new System.Drawing.Size(483, 375);
            this.CatalogTabsOptions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CatalogTabsOptions.TabIndex = 0;
            // 
            // HatTab
            // 
            this.HatTab.Controls.Add(this.HatsListView);
            this.HatTab.Location = new System.Drawing.Point(4, 34);
            this.HatTab.Name = "HatTab";
            this.HatTab.Padding = new System.Windows.Forms.Padding(3);
            this.HatTab.Size = new System.Drawing.Size(475, 337);
            this.HatTab.TabIndex = 0;
            this.HatTab.Text = "Hats";
            this.HatTab.UseVisualStyleBackColor = true;
            // 
            // TshrtTab
            // 
            this.TshrtTab.Location = new System.Drawing.Point(4, 34);
            this.TshrtTab.Name = "TshrtTab";
            this.TshrtTab.Size = new System.Drawing.Size(475, 337);
            this.TshrtTab.TabIndex = 3;
            this.TshrtTab.Text = "T-Shirts";
            this.TshrtTab.UseVisualStyleBackColor = true;
            // 
            // ShrtTab
            // 
            this.ShrtTab.Location = new System.Drawing.Point(4, 34);
            this.ShrtTab.Name = "ShrtTab";
            this.ShrtTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShrtTab.Size = new System.Drawing.Size(475, 337);
            this.ShrtTab.TabIndex = 1;
            this.ShrtTab.Text = "Shirts";
            this.ShrtTab.UseVisualStyleBackColor = true;
            // 
            // PntTab
            // 
            this.PntTab.Location = new System.Drawing.Point(4, 34);
            this.PntTab.Name = "PntTab";
            this.PntTab.Size = new System.Drawing.Size(475, 337);
            this.PntTab.TabIndex = 2;
            this.PntTab.Text = "Pants";
            this.PntTab.UseVisualStyleBackColor = true;
            // 
            // InfoTab
            // 
            this.InfoTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoTab.Location = new System.Drawing.Point(4, 34);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Size = new System.Drawing.Size(495, 387);
            this.InfoTab.TabIndex = 4;
            this.InfoTab.Text = "Info";
            this.InfoTab.ToolTipText = "Shows you System Info and Documentation!";
            // 
            // PacksTab
            // 
            this.PacksTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PacksTab.Location = new System.Drawing.Point(4, 34);
            this.PacksTab.Name = "PacksTab";
            this.PacksTab.Size = new System.Drawing.Size(495, 387);
            this.PacksTab.TabIndex = 6;
            this.PacksTab.Text = "Packs";
            this.PacksTab.ToolTipText = "Includes Assetpacks and Clientpacks. Both will be explained in the tab.";
            // 
            // SettingTab
            // 
            this.SettingTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingTab.Location = new System.Drawing.Point(4, 34);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingTab.Size = new System.Drawing.Size(495, 387);
            this.SettingTab.TabIndex = 1;
            this.SettingTab.Text = "Settings";
            this.SettingTab.ToolTipText = "Need to adjust something? Here\'s the settings tab.";
            // 
            // CrditTab
            // 
            this.CrditTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CrditTab.Controls.Add(this.DCButton);
            this.CrditTab.Location = new System.Drawing.Point(4, 34);
            this.CrditTab.Name = "CrditTab";
            this.CrditTab.Size = new System.Drawing.Size(495, 387);
            this.CrditTab.TabIndex = 3;
            this.CrditTab.Text = "Credits";
            this.CrditTab.ToolTipText = "Credits for all the cool people who made Auroria possible.";
            // 
            // DCButton
            // 
            this.DCButton.BackColor = System.Drawing.Color.SlateBlue;
            this.DCButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DCButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DCButton.Location = new System.Drawing.Point(16, 15);
            this.DCButton.Name = "DCButton";
            this.DCButton.Size = new System.Drawing.Size(153, 40);
            this.DCButton.TabIndex = 0;
            this.DCButton.Text = "Join the Discord!";
            this.DCButton.UseVisualStyleBackColor = false;
            this.DCButton.Click += new System.EventHandler(this.DCButton_Click);
            // 
            // ClientsLabel
            // 
            this.ClientsLabel.AutoSize = true;
            this.ClientsLabel.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsLabel.Location = new System.Drawing.Point(586, 175);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(98, 36);
            this.ClientsLabel.TabIndex = 1;
            this.ClientsLabel.Text = "Maps";
            this.ClientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClientsLabel.Click += new System.EventHandler(this.MapsLbl_Click);
            // 
            // MapsTree
            // 
            this.MapsTree.Location = new System.Drawing.Point(521, 223);
            this.MapsTree.Name = "MapsTree";
            this.MapsTree.Size = new System.Drawing.Size(226, 391);
            this.MapsTree.TabIndex = 2;
            this.MapsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MapsTree_AfterSelect);
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.Location = new System.Drawing.Point(0, -1);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(763, 115);
            this.BackgroundBox.TabIndex = 3;
            this.BackgroundBox.TabStop = false;
            // 
            // MOTD
            // 
            this.MOTD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MOTD.BackColor = System.Drawing.Color.AliceBlue;
            this.MOTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MOTD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MOTD.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOTD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MOTD.Location = new System.Drawing.Point(-5, 117);
            this.MOTD.Name = "MOTD";
            this.MOTD.Size = new System.Drawing.Size(768, 47);
            this.MOTD.TabIndex = 8;
            this.MOTD.Text = "insert default text here lmao";
            this.MOTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MOTD.Click += new System.EventHandler(this.MOTDLabel);
            // 
            // HeadsTab
            // 
            this.HeadsTab.Location = new System.Drawing.Point(4, 34);
            this.HeadsTab.Name = "HeadsTab";
            this.HeadsTab.Size = new System.Drawing.Size(475, 337);
            this.HeadsTab.TabIndex = 4;
            this.HeadsTab.Text = "Heads";
            this.HeadsTab.UseVisualStyleBackColor = true;
            // 
            // FaceTab
            // 
            this.FaceTab.Location = new System.Drawing.Point(4, 34);
            this.FaceTab.Name = "FaceTab";
            this.FaceTab.Size = new System.Drawing.Size(475, 337);
            this.FaceTab.TabIndex = 5;
            this.FaceTab.Text = "Faces";
            this.FaceTab.UseVisualStyleBackColor = true;
            // 
            // PckgeTab
            // 
            this.PckgeTab.Location = new System.Drawing.Point(4, 34);
            this.PckgeTab.Name = "PckgeTab";
            this.PckgeTab.Size = new System.Drawing.Size(475, 337);
            this.PckgeTab.TabIndex = 6;
            this.PckgeTab.Text = "Packages";
            this.PckgeTab.UseVisualStyleBackColor = true;
            // 
            // HatsListView
            // 
            this.HatsListView.HideSelection = false;
            this.HatsListView.Location = new System.Drawing.Point(3, 6);
            this.HatsListView.Name = "HatsListView";
            this.HatsListView.Size = new System.Drawing.Size(466, 325);
            this.HatsListView.TabIndex = 0;
            this.HatsListView.UseCompatibleStateImageBehavior = false;
            // 
            // AurNTBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(762, 626);
            this.Controls.Add(this.MOTD);
            this.Controls.Add(this.BackgroundBox);
            this.Controls.Add(this.MapsTree);
            this.Controls.Add(this.ClientsLabel);
            this.Controls.Add(this.AllTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AurNTBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auroria .NT 0.1 [Codename:Invidia]";
            this.Load += new System.EventHandler(this.AurNTBase_Load);
            this.AllTabs.ResumeLayout(false);
            this.PlayTab.ResumeLayout(false);
            this.PlayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).EndInit();
            this.ClientInfoPanel.ResumeLayout(false);
            this.PlyrTab.ResumeLayout(false);
            this.PlyrTab.PerformLayout();
            this.CatalogTab.ResumeLayout(false);
            this.CatalogTabsOptions.ResumeLayout(false);
            this.HatTab.ResumeLayout(false);
            this.CrditTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.TabPage PlayTab;
        private System.Windows.Forms.TabPage SettingTab;
        private System.Windows.Forms.Label ClientsLabel;
        private System.Windows.Forms.TreeView MapsTree;
        private System.Windows.Forms.TabPage CatalogTab;
        private System.Windows.Forms.Button JoinBtn;
        private System.Windows.Forms.Button HostBtn;
        private System.Windows.Forms.TabPage CrditTab;
        private System.Windows.Forms.PictureBox BackgroundBox;
        private System.Windows.Forms.Label MOTD;
        private System.Windows.Forms.TabControl CatalogTabsOptions;
        private System.Windows.Forms.TabPage HatTab;
        private System.Windows.Forms.TabPage ShrtTab;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.TextBox PlayerIDBox;
        private System.Windows.Forms.TextBox PlayerNameBox;
        private System.Windows.Forms.Label UserNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage PlyrTab;
        private System.Windows.Forms.TabPage TshrtTab;
        private System.Windows.Forms.TabPage PntTab;
        private System.Windows.Forms.TabPage PacksTab;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.TextBox SrvrIPbox;
        private System.Windows.Forms.Panel ClientInfoPanel;
        private System.Windows.Forms.RichTextBox ClientInfoBox;
        private System.Windows.Forms.PictureBox ClientPictureBox;
        private System.Windows.Forms.Button DCButton;
        private System.Windows.Forms.TabPage HeadsTab;
        private System.Windows.Forms.TabPage FaceTab;
        private System.Windows.Forms.TabPage PckgeTab;
        private System.Windows.Forms.ListView HatsListView;
    }
}

