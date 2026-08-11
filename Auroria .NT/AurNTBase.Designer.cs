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
            this.HostBtn = new System.Windows.Forms.Button();
            this.JoinBtn = new System.Windows.Forms.Button();
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.CatalogTab = new System.Windows.Forms.TabPage();
            this.CrditTab = new System.Windows.Forms.TabPage();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.MapsTree = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MOTD = new System.Windows.Forms.Label();
            this.AllTabs.SuspendLayout();
            this.PlayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.PlayTab);
            this.AllTabs.Controls.Add(this.SettingTab);
            this.AllTabs.Controls.Add(this.CatalogTab);
            this.AllTabs.Controls.Add(this.CrditTab);
            this.AllTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllTabs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTabs.ItemSize = new System.Drawing.Size(69, 30);
            this.AllTabs.Location = new System.Drawing.Point(12, 189);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(503, 425);
            this.AllTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AllTabs.TabIndex = 0;
            // 
            // PlayTab
            // 
            this.PlayTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayTab.Controls.Add(this.HostBtn);
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
            // HostBtn
            // 
            this.HostBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HostBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HostBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HostBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HostBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostBtn.FlatAppearance.BorderSize = 0;
            this.HostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HostBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HostBtn.Image = ((System.Drawing.Image)(resources.GetObject("HostBtn.Image")));
            this.HostBtn.Location = new System.Drawing.Point(234, 333);
            this.HostBtn.Name = "HostBtn";
            this.HostBtn.Size = new System.Drawing.Size(125, 47);
            this.HostBtn.TabIndex = 1;
            this.HostBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HostBtn.UseMnemonic = false;
            this.HostBtn.UseVisualStyleBackColor = false;
            this.HostBtn.Click += new System.EventHandler(this.HostBtn_Click);
            // 
            // JoinBtn
            // 
            this.JoinBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.JoinBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.JoinBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.JoinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JoinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinBtn.FlatAppearance.BorderSize = 0;
            this.JoinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JoinBtn.Image = ((System.Drawing.Image)(resources.GetObject("JoinBtn.Image")));
            this.JoinBtn.Location = new System.Drawing.Point(92, 333);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(125, 47);
            this.JoinBtn.TabIndex = 0;
            this.JoinBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.JoinBtn.UseMnemonic = false;
            this.JoinBtn.UseVisualStyleBackColor = false;
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_click);
            // 
            // SettingTab
            // 
            this.SettingTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingTab.Location = new System.Drawing.Point(4, 34);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingTab.Size = new System.Drawing.Size(495, 387);
            this.SettingTab.TabIndex = 1;
            this.SettingTab.Text = "Settings";
            this.SettingTab.ToolTipText = "Need to adjust something? Here\'s the settings tab.";
            // 
            // CatalogTab
            // 
            this.CatalogTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CatalogTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatalogTab.Location = new System.Drawing.Point(4, 34);
            this.CatalogTab.Name = "CatalogTab";
            this.CatalogTab.Padding = new System.Windows.Forms.Padding(3);
            this.CatalogTab.Size = new System.Drawing.Size(495, 387);
            this.CatalogTab.TabIndex = 2;
            this.CatalogTab.Text = "Catalog";
            this.CatalogTab.ToolTipText = "Catalog to get clothes n stuff";
            // 
            // CrditTab
            // 
            this.CrditTab.Location = new System.Drawing.Point(4, 34);
            this.CrditTab.Name = "CrditTab";
            this.CrditTab.Size = new System.Drawing.Size(495, 387);
            this.CrditTab.TabIndex = 3;
            this.CrditTab.Text = "Credits";
            this.CrditTab.ToolTipText = "Credits for all the cool people who made Auroria possible.";
            this.CrditTab.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 115);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MapsTree);
            this.Controls.Add(this.ClientsLabel);
            this.Controls.Add(this.AllTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AurNTBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auroria .NT 0.1";
            this.Load += new System.EventHandler(this.AurNTBase_Load);
            this.AllTabs.ResumeLayout(false);
            this.PlayTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MOTD;
    }
}

