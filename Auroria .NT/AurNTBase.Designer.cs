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
            this.ClientList = new System.Windows.Forms.ListBox();
            this.SrvrIPbox = new System.Windows.Forms.TextBox();
            this.CustmTab = new System.Windows.Forms.TabPage();
            this.BodyColorBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UserNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CatalogTabsOptions = new System.Windows.Forms.TabControl();
            this.HatTab = new System.Windows.Forms.TabPage();
            this.HatsSlot3 = new System.Windows.Forms.Button();
            this.HatsSlot2 = new System.Windows.Forms.Button();
            this.HatsSlot1 = new System.Windows.Forms.Button();
            this.HatsInfoTxt = new System.Windows.Forms.RichTextBox();
            this.HatsListView = new System.Windows.Forms.ListView();
            this.HatsImgList = new System.Windows.Forms.ImageList(this.components);
            this.HeadsTab = new System.Windows.Forms.TabPage();
            this.FaceTab = new System.Windows.Forms.TabPage();
            this.TshrtTab = new System.Windows.Forms.TabPage();
            this.ShrtTab = new System.Windows.Forms.TabPage();
            this.ShrtSlot1 = new System.Windows.Forms.Button();
            this.ShrtInfoTxt = new System.Windows.Forms.RichTextBox();
            this.ShirtsListView = new System.Windows.Forms.ListView();
            this.ShrtsImgList = new System.Windows.Forms.ImageList(this.components);
            this.PntTab = new System.Windows.Forms.TabPage();
            this.PntsInfoTxt = new System.Windows.Forms.RichTextBox();
            this.PantsListView = new System.Windows.Forms.ListView();
            this.PntsImgList = new System.Windows.Forms.ImageList(this.components);
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
            this.MOTD = new System.Windows.Forms.Label();
            this.RndrBtn = new System.Windows.Forms.Button();
            this.HostingBox = new System.Windows.Forms.ComboBox();
            this.hostingtypelabel = new System.Windows.Forms.Label();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.PlayButtonC = new System.Windows.Forms.PictureBox();
            this.ClientPictureBox = new System.Windows.Forms.PictureBox();
            this.HostButtonC = new System.Windows.Forms.PictureBox();
            this.AssetPacksBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PacksLabel = new System.Windows.Forms.Label();
            this.AllTabs.SuspendLayout();
            this.PlayTab.SuspendLayout();
            this.CustmTab.SuspendLayout();
            this.CatalogTabsOptions.SuspendLayout();
            this.HatTab.SuspendLayout();
            this.ShrtTab.SuspendLayout();
            this.PntTab.SuspendLayout();
            this.PacksTab.SuspendLayout();
            this.CrditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButtonC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostButtonC)).BeginInit();
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
            this.PlayTab.Controls.Add(this.HostButtonC);
            this.PlayTab.Controls.Add(this.PlayButtonC);
            this.PlayTab.Controls.Add(this.hostingtypelabel);
            this.PlayTab.Controls.Add(this.HostingBox);
            this.PlayTab.Controls.Add(this.ClientInfoBox);
            this.PlayTab.Controls.Add(this.ClientPictureBox);
            this.PlayTab.Controls.Add(this.ClientList);
            this.PlayTab.Controls.Add(this.SrvrIPbox);
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
            this.ClientInfoBox.Location = new System.Drawing.Point(6, 194);
            this.ClientInfoBox.Name = "ClientInfoBox";
            this.ClientInfoBox.ReadOnly = true;
            this.ClientInfoBox.Size = new System.Drawing.Size(275, 67);
            this.ClientInfoBox.TabIndex = 0;
            this.ClientInfoBox.Text = "Client Info will be displayed here.";
            this.ClientInfoBox.TextChanged += new System.EventHandler(this.ClientInfoBox_TextChanged);
            // 
            // ClientList
            // 
            this.ClientList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 16;
            this.ClientList.Location = new System.Drawing.Point(287, 30);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(201, 276);
            this.ClientList.TabIndex = 12;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // SrvrIPbox
            // 
            this.SrvrIPbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SrvrIPbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SrvrIPbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrvrIPbox.Location = new System.Drawing.Point(5, 267);
            this.SrvrIPbox.Name = "SrvrIPbox";
            this.SrvrIPbox.Size = new System.Drawing.Size(276, 25);
            this.SrvrIPbox.TabIndex = 11;
            this.SrvrIPbox.Text = "localhost:53640";
            this.SrvrIPbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustmTab
            // 
            this.CustmTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustmTab.Controls.Add(this.RndrBtn);
            this.CustmTab.Controls.Add(this.BodyColorBtn);
            this.CustmTab.Controls.Add(this.SaveBtn);
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
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(253, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 41);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save Name and ID";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.HatTab.Controls.Add(this.HatsSlot3);
            this.HatTab.Controls.Add(this.HatsSlot2);
            this.HatTab.Controls.Add(this.HatsSlot1);
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
            // HatsSlot3
            // 
            this.HatsSlot3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HatsSlot3.FlatAppearance.BorderSize = 2;
            this.HatsSlot3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HatsSlot3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HatsSlot3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HatsSlot3.Location = new System.Drawing.Point(399, 154);
            this.HatsSlot3.Name = "HatsSlot3";
            this.HatsSlot3.Size = new System.Drawing.Size(60, 60);
            this.HatsSlot3.TabIndex = 7;
            this.HatsSlot3.UseVisualStyleBackColor = true;
            this.HatsSlot3.Click += new System.EventHandler(this.HatsSlot3_Click);
            // 
            // HatsSlot2
            // 
            this.HatsSlot2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HatsSlot2.FlatAppearance.BorderSize = 2;
            this.HatsSlot2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HatsSlot2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HatsSlot2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HatsSlot2.Location = new System.Drawing.Point(399, 88);
            this.HatsSlot2.Name = "HatsSlot2";
            this.HatsSlot2.Size = new System.Drawing.Size(60, 60);
            this.HatsSlot2.TabIndex = 6;
            this.HatsSlot2.UseVisualStyleBackColor = true;
            this.HatsSlot2.Click += new System.EventHandler(this.HatsSlot2_Click);
            // 
            // HatsSlot1
            // 
            this.HatsSlot1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HatsSlot1.FlatAppearance.BorderSize = 2;
            this.HatsSlot1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.HatsSlot1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HatsSlot1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HatsSlot1.Location = new System.Drawing.Point(399, 22);
            this.HatsSlot1.Name = "HatsSlot1";
            this.HatsSlot1.Size = new System.Drawing.Size(60, 60);
            this.HatsSlot1.TabIndex = 5;
            this.HatsSlot1.UseVisualStyleBackColor = true;
            this.HatsSlot1.Click += new System.EventHandler(this.HatsSlot1_Click);
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
            this.ShrtTab.Controls.Add(this.ShrtSlot1);
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
            // ShrtSlot1
            // 
            this.ShrtSlot1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShrtSlot1.FlatAppearance.BorderSize = 2;
            this.ShrtSlot1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ShrtSlot1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShrtSlot1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShrtSlot1.Location = new System.Drawing.Point(399, 22);
            this.ShrtSlot1.Name = "ShrtSlot1";
            this.ShrtSlot1.Size = new System.Drawing.Size(60, 60);
            this.ShrtSlot1.TabIndex = 4;
            this.ShrtSlot1.UseVisualStyleBackColor = true;
            this.ShrtSlot1.Click += new System.EventHandler(this.ShrtSlot1_Click);
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
            this.PntTab.Controls.Add(this.PntsInfoTxt);
            this.PntTab.Controls.Add(this.PantsListView);
            this.PntTab.Location = new System.Drawing.Point(4, 34);
            this.PntTab.Name = "PntTab";
            this.PntTab.Size = new System.Drawing.Size(475, 284);
            this.PntTab.TabIndex = 2;
            this.PntTab.Text = "Pants";
            this.PntTab.UseVisualStyleBackColor = true;
            // 
            // PntsInfoTxt
            // 
            this.PntsInfoTxt.BackColor = System.Drawing.SystemColors.Control;
            this.PntsInfoTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PntsInfoTxt.Location = new System.Drawing.Point(6, 204);
            this.PntsInfoTxt.Name = "PntsInfoTxt";
            this.PntsInfoTxt.ReadOnly = true;
            this.PntsInfoTxt.Size = new System.Drawing.Size(375, 74);
            this.PntsInfoTxt.TabIndex = 4;
            this.PntsInfoTxt.Text = "No Item Selected!";
            // 
            // PantsListView
            // 
            this.PantsListView.HideSelection = false;
            this.PantsListView.LargeImageList = this.PntsImgList;
            this.PantsListView.Location = new System.Drawing.Point(6, 6);
            this.PantsListView.Name = "PantsListView";
            this.PantsListView.Size = new System.Drawing.Size(375, 192);
            this.PantsListView.TabIndex = 1;
            this.PantsListView.UseCompatibleStateImageBehavior = false;
            this.PantsListView.SelectedIndexChanged += new System.EventHandler(this.PantsListView_SelectedIndexChanged);
            // 
            // PntsImgList
            // 
            this.PntsImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.PntsImgList.ImageSize = new System.Drawing.Size(16, 16);
            this.PntsImgList.TransparentColor = System.Drawing.Color.Transparent;
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
            this.PacksTab.Controls.Add(this.PacksLabel);
            this.PacksTab.Controls.Add(this.groupBox1);
            this.PacksTab.Controls.Add(this.AssetPacksBox);
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
            this.ClientsLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsLabel.Location = new System.Drawing.Point(586, 175);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(99, 45);
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
            // MOTD
            // 
            this.MOTD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MOTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.MOTD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MOTD.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOTD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MOTD.Location = new System.Drawing.Point(-5, 108);
            this.MOTD.Name = "MOTD";
            this.MOTD.Size = new System.Drawing.Size(768, 47);
            this.MOTD.TabIndex = 8;
            this.MOTD.Text = "insert default text here lmao";
            this.MOTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MOTD.Click += new System.EventHandler(this.MOTDLabel);
            // 
            // RndrBtn
            // 
            this.RndrBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RndrBtn.Location = new System.Drawing.Point(409, 12);
            this.RndrBtn.Name = "RndrBtn";
            this.RndrBtn.Size = new System.Drawing.Size(72, 41);
            this.RndrBtn.TabIndex = 15;
            this.RndrBtn.Text = "Render Avatar";
            this.RndrBtn.UseVisualStyleBackColor = true;
            // 
            // HostingBox
            // 
            this.HostingBox.FormattingEnabled = true;
            this.HostingBox.Location = new System.Drawing.Point(286, 344);
            this.HostingBox.Name = "HostingBox";
            this.HostingBox.Size = new System.Drawing.Size(202, 22);
            this.HostingBox.TabIndex = 15;
            // 
            // hostingtypelabel
            // 
            this.hostingtypelabel.AutoSize = true;
            this.hostingtypelabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostingtypelabel.Location = new System.Drawing.Point(322, 314);
            this.hostingtypelabel.Name = "hostingtypelabel";
            this.hostingtypelabel.Size = new System.Drawing.Size(133, 27);
            this.hostingtypelabel.TabIndex = 16;
            this.hostingtypelabel.Text = "Hosting Type";
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.Image = global::Auroria.NT.Properties.Resources.BannerLong;
            this.BackgroundBox.Location = new System.Drawing.Point(0, -1);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(763, 115);
            this.BackgroundBox.TabIndex = 3;
            this.BackgroundBox.TabStop = false;
            // 
            // PlayButtonC
            // 
            this.PlayButtonC.BackColor = System.Drawing.Color.Transparent;
            this.PlayButtonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButtonC.Image = global::Auroria.NT.Properties.Resources.AurPlayButton;
            this.PlayButtonC.Location = new System.Drawing.Point(6, 298);
            this.PlayButtonC.Name = "PlayButtonC";
            this.PlayButtonC.Size = new System.Drawing.Size(130, 40);
            this.PlayButtonC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayButtonC.TabIndex = 17;
            this.PlayButtonC.TabStop = false;
            this.PlayButtonC.Click += new System.EventHandler(this.PlayButtonC_Click);
            // 
            // ClientPictureBox
            // 
            this.ClientPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientPictureBox.Location = new System.Drawing.Point(5, 30);
            this.ClientPictureBox.Name = "ClientPictureBox";
            this.ClientPictureBox.Size = new System.Drawing.Size(275, 158);
            this.ClientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientPictureBox.TabIndex = 14;
            this.ClientPictureBox.TabStop = false;
            this.ClientPictureBox.Click += new System.EventHandler(this.ClientPictureBox_Click);
            // 
            // HostButtonC
            // 
            this.HostButtonC.BackColor = System.Drawing.Color.Transparent;
            this.HostButtonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostButtonC.Image = global::Auroria.NT.Properties.Resources.AurHostButton;
            this.HostButtonC.Location = new System.Drawing.Point(150, 298);
            this.HostButtonC.Name = "HostButtonC";
            this.HostButtonC.Size = new System.Drawing.Size(130, 40);
            this.HostButtonC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HostButtonC.TabIndex = 18;
            this.HostButtonC.TabStop = false;
            this.HostButtonC.Click += new System.EventHandler(this.HostButtonC_Click);
            // 
            // AssetPacksBox
            // 
            this.AssetPacksBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetPacksBox.Location = new System.Drawing.Point(12, 121);
            this.AssetPacksBox.Name = "AssetPacksBox";
            this.AssetPacksBox.Size = new System.Drawing.Size(226, 250);
            this.AssetPacksBox.TabIndex = 0;
            this.AssetPacksBox.TabStop = false;
            this.AssetPacksBox.Text = "Asset Packs";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(256, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Packs";
            // 
            // PacksLabel
            // 
            this.PacksLabel.AutoSize = true;
            this.PacksLabel.BackColor = System.Drawing.Color.Transparent;
            this.PacksLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacksLabel.Location = new System.Drawing.Point(8, 9);
            this.PacksLabel.Name = "PacksLabel";
            this.PacksLabel.Size = new System.Drawing.Size(437, 80);
            this.PacksLabel.TabIndex = 2;
            this.PacksLabel.Text = "-Asset packs are a feature that allow you to load assets that\r\nare unavailable an" +
    "ymore. \r\n-Client Packs on the other hand are basically client extensions\r\nthat a" +
    "llow you to add more clients.";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.AurNTBase_Load);
            this.AllTabs.ResumeLayout(false);
            this.PlayTab.ResumeLayout(false);
            this.PlayTab.PerformLayout();
            this.CustmTab.ResumeLayout(false);
            this.CustmTab.PerformLayout();
            this.CatalogTabsOptions.ResumeLayout(false);
            this.HatTab.ResumeLayout(false);
            this.ShrtTab.ResumeLayout(false);
            this.PntTab.ResumeLayout(false);
            this.PacksTab.ResumeLayout(false);
            this.PacksTab.PerformLayout();
            this.CrditTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButtonC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostButtonC)).EndInit();
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
        private System.Windows.Forms.ImageList ShrtsImgList;
        private System.Windows.Forms.RichTextBox ShrtInfoTxt;
        private System.Windows.Forms.RichTextBox HatsInfoTxt;
        private System.Windows.Forms.ImageList HatsImgList;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BodyColorBtn;
        private System.Windows.Forms.Button RndrBtn;
        private System.Windows.Forms.RichTextBox PntsInfoTxt;
        private System.Windows.Forms.ImageList PntsImgList;
        private System.Windows.Forms.Button ShrtSlot1;
        private System.Windows.Forms.Button HatsSlot1;
        private System.Windows.Forms.Button HatsSlot3;
        private System.Windows.Forms.Button HatsSlot2;
        private System.Windows.Forms.Label hostingtypelabel;
        private System.Windows.Forms.ComboBox HostingBox;
        private System.Windows.Forms.PictureBox PlayButtonC;
        private System.Windows.Forms.PictureBox HostButtonC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox AssetPacksBox;
        private System.Windows.Forms.Label PacksLabel;
    }
}

