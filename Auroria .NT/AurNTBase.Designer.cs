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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AurNTBase));
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.PlayTab = new System.Windows.Forms.TabPage();
            this.ClientInfoBox = new System.Windows.Forms.RichTextBox();
            this.ClientPictureBox = new System.Windows.Forms.PictureBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.HostBtn = new System.Windows.Forms.Button();
            this.SrvrIPbox = new System.Windows.Forms.TextBox();
            this.JoinBtn = new System.Windows.Forms.Button();
            this.CustmTab = new System.Windows.Forms.TabPage();
            this.BodyColorBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CookieWzrd = new System.Windows.Forms.Button();
            this.UserNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CatalogTabsOptions = new System.Windows.Forms.TabControl();
            this.HatTab = new System.Windows.Forms.TabPage();
            this.HatsInfoTxt = new System.Windows.Forms.RichTextBox();
            this.HatsListView = new System.Windows.Forms.ListView();
            this.HatsImgList = new System.Windows.Forms.ImageList(this.components);
            this.HeadsTab = new System.Windows.Forms.TabPage();
            this.FaceTab = new System.Windows.Forms.TabPage();
            this.TshrtTab = new System.Windows.Forms.TabPage();
            this.ShrtTab = new System.Windows.Forms.TabPage();
            this.ShrtInfoTxt = new System.Windows.Forms.RichTextBox();
            this.ShirtsListView = new System.Windows.Forms.ListView();
            this.ShrtsImgList = new System.Windows.Forms.ImageList(this.components);
            this.PntTab = new System.Windows.Forms.TabPage();
            this.PantsListView = new System.Windows.Forms.ListView();
            this.PckgeTab = new System.Windows.Forms.TabPage();
            this.PlayerNameBox = new System.Windows.Forms.TextBox();
            this.PlayerIDBox = new System.Windows.Forms.TextBox();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.PacksTab = new System.Windows.Forms.TabPage();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.CrditTab = new System.Windows.Forms.TabPage();
            this.DCButton = new System.Windows.Forms.Button();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.MapsTree = new System.Windows.Forms.TreeView();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.MOTD = new System.Windows.Forms.Label();
            this.AllTabs.SuspendLayout();
            this.PlayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).BeginInit();
            this.CustmTab.SuspendLayout();
            this.CatalogTabsOptions.SuspendLayout();
            this.HatTab.SuspendLayout();
            this.ShrtTab.SuspendLayout();
            this.PntTab.SuspendLayout();
            this.CrditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.PlayTab);
            this.AllTabs.Controls.Add(this.CustmTab);
            this.AllTabs.Controls.Add(this.InfoTab);
            this.AllTabs.Controls.Add(this.PacksTab);
            this.AllTabs.Controls.Add(this.SettingTab);
            this.AllTabs.Controls.Add(this.CrditTab);
            this.AllTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllTabs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTabs.HotTrack = true;
            this.AllTabs.ItemSize = new System.Drawing.Size(76, 30);
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
            this.PlayTab.Controls.Add(this.ClientInfoBox);
            this.PlayTab.Controls.Add(this.ClientPictureBox);
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
            // ClientInfoBox
            // 
            this.ClientInfoBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientInfoBox.Location = new System.Drawing.Point(6, 205);
            this.ClientInfoBox.Name = "ClientInfoBox";
            this.ClientInfoBox.ReadOnly = true;
            this.ClientInfoBox.Size = new System.Drawing.Size(275, 82);
            this.ClientInfoBox.TabIndex = 0;
            this.ClientInfoBox.Text = "Client Info will be displayed here.";
            this.ClientInfoBox.TextChanged += new System.EventHandler(this.ClientInfoBox_TextChanged);
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
            // ClientList
            // 
            this.ClientList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 16;
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
            // CustmTab
            // 
            this.CustmTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustmTab.Controls.Add(this.BodyColorBtn);
            this.CustmTab.Controls.Add(this.SaveBtn);
            this.CustmTab.Controls.Add(this.CookieWzrd);
            this.CustmTab.Controls.Add(this.UserNote);
            this.CustmTab.Controls.Add(this.label1);
            this.CustmTab.Controls.Add(this.CatalogTabsOptions);
            this.CustmTab.Controls.Add(this.PlayerNameBox);
            this.CustmTab.Controls.Add(this.PlayerIDBox);
            this.CustmTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustmTab.Location = new System.Drawing.Point(4, 34);
            this.CustmTab.Name = "CustmTab";
            this.CustmTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustmTab.Size = new System.Drawing.Size(495, 387);
            this.CustmTab.TabIndex = 2;
            this.CustmTab.Text = "Customize";
            this.CustmTab.ToolTipText = "Catalog to get clothes n stuff";
            // 
            // BodyColorBtn
            // 
            this.BodyColorBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyColorBtn.Location = new System.Drawing.Point(331, 12);
            this.BodyColorBtn.Name = "BodyColorBtn";
            this.BodyColorBtn.Size = new System.Drawing.Size(72, 41);
            this.BodyColorBtn.TabIndex = 15;
            this.BodyColorBtn.Text = "Body Colors";
            this.BodyColorBtn.UseVisualStyleBackColor = true;
            this.BodyColorBtn.Click += new System.EventHandler(this.BodyColorBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(253, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 41);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save Data";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CookieWzrd
            // 
            this.CookieWzrd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookieWzrd.Location = new System.Drawing.Point(409, 12);
            this.CookieWzrd.Name = "CookieWzrd";
            this.CookieWzrd.Size = new System.Drawing.Size(77, 41);
            this.CookieWzrd.TabIndex = 13;
            this.CookieWzrd.Text = "Cookie Wizard";
            this.CookieWzrd.UseVisualStyleBackColor = true;
            this.CookieWzrd.Click += new System.EventHandler(this.CookieWzrd_Click);
            // 
            // UserNote
            // 
            this.UserNote.AutoSize = true;
            this.UserNote.BackColor = System.Drawing.Color.Transparent;
            this.UserNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNote.Location = new System.Drawing.Point(125, 12);
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
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "User ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CatalogTabsOptions.Location = new System.Drawing.Point(6, 59);
            this.CatalogTabsOptions.Name = "CatalogTabsOptions";
            this.CatalogTabsOptions.SelectedIndex = 0;
            this.CatalogTabsOptions.Size = new System.Drawing.Size(483, 322);
            this.CatalogTabsOptions.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CatalogTabsOptions.TabIndex = 0;
            // 
            // HatTab
            // 
            this.HatTab.Controls.Add(this.HatsInfoTxt);
            this.HatTab.Controls.Add(this.HatsListView);
            this.HatTab.Location = new System.Drawing.Point(4, 34);
            this.HatTab.Name = "HatTab";
            this.HatTab.Padding = new System.Windows.Forms.Padding(3);
            this.HatTab.Size = new System.Drawing.Size(475, 284);
            this.HatTab.TabIndex = 0;
            this.HatTab.Text = "Hats";
            this.HatTab.UseVisualStyleBackColor = true;
            // 
            // HatsInfoTxt
            // 
            this.HatsInfoTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HatsInfoTxt.Location = new System.Drawing.Point(6, 204);
            this.HatsInfoTxt.Name = "HatsInfoTxt";
            this.HatsInfoTxt.ReadOnly = true;
            this.HatsInfoTxt.Size = new System.Drawing.Size(375, 74);
            this.HatsInfoTxt.TabIndex = 4;
            this.HatsInfoTxt.Text = "No Item Selected!";
            // 
            // HatsListView
            // 
            this.HatsListView.HideSelection = false;
            this.HatsListView.LargeImageList = this.HatsImgList;
            this.HatsListView.Location = new System.Drawing.Point(6, 6);
            this.HatsListView.Name = "HatsListView";
            this.HatsListView.Size = new System.Drawing.Size(375, 192);
            this.HatsListView.TabIndex = 0;
            this.HatsListView.UseCompatibleStateImageBehavior = false;
            this.HatsListView.SelectedIndexChanged += new System.EventHandler(this.HatsListView_SelectedIndexChanged);
            // 
            // HatsImgList
            // 
            this.HatsImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.HatsImgList.ImageSize = new System.Drawing.Size(64, 64);
            this.HatsImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // HeadsTab
            // 
            this.HeadsTab.Location = new System.Drawing.Point(4, 34);
            this.HeadsTab.Name = "HeadsTab";
            this.HeadsTab.Size = new System.Drawing.Size(475, 284);
            this.HeadsTab.TabIndex = 4;
            this.HeadsTab.Text = "Heads";
            this.HeadsTab.UseVisualStyleBackColor = true;
            // 
            // FaceTab
            // 
            this.FaceTab.Location = new System.Drawing.Point(4, 34);
            this.FaceTab.Name = "FaceTab";
            this.FaceTab.Size = new System.Drawing.Size(475, 284);
            this.FaceTab.TabIndex = 5;
            this.FaceTab.Text = "Faces";
            this.FaceTab.UseVisualStyleBackColor = true;
            // 
            // TshrtTab
            // 
            this.TshrtTab.Location = new System.Drawing.Point(4, 34);
            this.TshrtTab.Name = "TshrtTab";
            this.TshrtTab.Size = new System.Drawing.Size(475, 284);
            this.TshrtTab.TabIndex = 3;
            this.TshrtTab.Text = "T-Shirts";
            this.TshrtTab.UseVisualStyleBackColor = true;
            // 
            // ShrtTab
            // 
            this.ShrtTab.Controls.Add(this.ShrtInfoTxt);
            this.ShrtTab.Controls.Add(this.ShirtsListView);
            this.ShrtTab.Location = new System.Drawing.Point(4, 34);
            this.ShrtTab.Name = "ShrtTab";
            this.ShrtTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShrtTab.Size = new System.Drawing.Size(475, 284);
            this.ShrtTab.TabIndex = 1;
            this.ShrtTab.Text = "Shirts";
            this.ShrtTab.UseVisualStyleBackColor = true;
            // 
            // ShrtInfoTxt
            // 
            this.ShrtInfoTxt.BackColor = System.Drawing.SystemColors.Control;
            this.ShrtInfoTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ShrtInfoTxt.Location = new System.Drawing.Point(6, 204);
            this.ShrtInfoTxt.Name = "ShrtInfoTxt";
            this.ShrtInfoTxt.ReadOnly = true;
            this.ShrtInfoTxt.Size = new System.Drawing.Size(375, 74);
            this.ShrtInfoTxt.TabIndex = 3;
            this.ShrtInfoTxt.Text = "No Item Selected!";
            // 
            // ShirtsListView
            // 
            this.ShirtsListView.GridLines = true;
            this.ShirtsListView.HideSelection = false;
            this.ShirtsListView.LargeImageList = this.ShrtsImgList;
            this.ShirtsListView.Location = new System.Drawing.Point(6, 6);
            this.ShirtsListView.Name = "ShirtsListView";
            this.ShirtsListView.Size = new System.Drawing.Size(375, 192);
            this.ShirtsListView.TabIndex = 2;
            this.ShirtsListView.UseCompatibleStateImageBehavior = false;
            this.ShirtsListView.SelectedIndexChanged += new System.EventHandler(this.ShirtsListView_SelectedIndexChanged);
            // 
            // ShrtsImgList
            // 
            this.ShrtsImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ShrtsImgList.ImageSize = new System.Drawing.Size(64, 64);
            this.ShrtsImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PntTab
            // 
            this.PntTab.Controls.Add(this.PantsListView);
            this.PntTab.Location = new System.Drawing.Point(4, 34);
            this.PntTab.Name = "PntTab";
            this.PntTab.Size = new System.Drawing.Size(475, 284);
            this.PntTab.TabIndex = 2;
            this.PntTab.Text = "Pants";
            this.PntTab.UseVisualStyleBackColor = true;
            // 
            // PantsListView
            // 
            this.PantsListView.HideSelection = false;
            this.PantsListView.Location = new System.Drawing.Point(0, 0);
            this.PantsListView.Name = "PantsListView";
            this.PantsListView.Size = new System.Drawing.Size(381, 284);
            this.PantsListView.TabIndex = 1;
            this.PantsListView.UseCompatibleStateImageBehavior = false;
            // 
            // PckgeTab
            // 
            this.PckgeTab.Location = new System.Drawing.Point(4, 34);
            this.PckgeTab.Name = "PckgeTab";
            this.PckgeTab.Size = new System.Drawing.Size(475, 284);
            this.PckgeTab.TabIndex = 6;
            this.PckgeTab.Text = "Packages";
            this.PckgeTab.UseVisualStyleBackColor = true;
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlayerNameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerNameBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameBox.Location = new System.Drawing.Point(128, 30);
            this.PlayerNameBox.MaxLength = 20;
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(118, 23);
            this.PlayerNameBox.TabIndex = 10;
            this.PlayerNameBox.Text = "Username";
            this.PlayerNameBox.TextChanged += new System.EventHandler(this.PlayerNameBox_TextChanged);
            // 
            // PlayerIDBox
            // 
            this.PlayerIDBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlayerIDBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerIDBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIDBox.Location = new System.Drawing.Point(8, 30);
            this.PlayerIDBox.MaxLength = 30;
            this.PlayerIDBox.Name = "PlayerIDBox";
            this.PlayerIDBox.Size = new System.Drawing.Size(113, 23);
            this.PlayerIDBox.TabIndex = 9;
            this.PlayerIDBox.Text = "123456789";
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
            this.CustmTab.ResumeLayout(false);
            this.CustmTab.PerformLayout();
            this.CatalogTabsOptions.ResumeLayout(false);
            this.HatTab.ResumeLayout(false);
            this.ShrtTab.ResumeLayout(false);
            this.PntTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage CustmTab;
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
        private System.Windows.Forms.TabPage TshrtTab;
        private System.Windows.Forms.TabPage PntTab;
        private System.Windows.Forms.TabPage PacksTab;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.TextBox SrvrIPbox;
        private System.Windows.Forms.RichTextBox ClientInfoBox;
        private System.Windows.Forms.PictureBox ClientPictureBox;
        private System.Windows.Forms.Button DCButton;
        private System.Windows.Forms.TabPage HeadsTab;
        private System.Windows.Forms.TabPage FaceTab;
        private System.Windows.Forms.TabPage PckgeTab;
        private System.Windows.Forms.ListView HatsListView;
        private System.Windows.Forms.ListView PantsListView;
        private System.Windows.Forms.ListView ShirtsListView;
        private System.Windows.Forms.Button CookieWzrd;
        private System.Windows.Forms.ImageList ShrtsImgList;
        private System.Windows.Forms.RichTextBox ShrtInfoTxt;
        private System.Windows.Forms.RichTextBox HatsInfoTxt;
        private System.Windows.Forms.ImageList HatsImgList;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BodyColorBtn;
    }
}

