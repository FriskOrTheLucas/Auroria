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
            this.SettingTab = new System.Windows.Forms.TabPage();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.MapsTree = new System.Windows.Forms.TreeView();
            this.CatalogTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.AllTabs.SuspendLayout();
            this.PlayTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.PlayTab);
            this.AllTabs.Controls.Add(this.SettingTab);
            this.AllTabs.Controls.Add(this.CatalogTab);
            this.AllTabs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTabs.ItemSize = new System.Drawing.Size(65, 23);
            this.AllTabs.Location = new System.Drawing.Point(3, 1);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(432, 441);
            this.AllTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AllTabs.TabIndex = 0;
            // 
            // PlayTab
            // 
            this.PlayTab.Controls.Add(this.button1);
            this.PlayTab.Location = new System.Drawing.Point(4, 27);
            this.PlayTab.Name = "PlayTab";
            this.PlayTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayTab.Size = new System.Drawing.Size(424, 410);
            this.PlayTab.TabIndex = 0;
            this.PlayTab.Text = "Play/Host";
            this.PlayTab.UseVisualStyleBackColor = true;
            this.PlayTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SettingTab
            // 
            this.SettingTab.Location = new System.Drawing.Point(4, 27);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingTab.Size = new System.Drawing.Size(424, 410);
            this.SettingTab.TabIndex = 1;
            this.SettingTab.Text = "Settings";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // ClientsLabel
            // 
            this.ClientsLabel.AutoSize = true;
            this.ClientsLabel.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsLabel.Location = new System.Drawing.Point(459, 9);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(98, 36);
            this.ClientsLabel.TabIndex = 1;
            this.ClientsLabel.Text = "Maps";
            this.ClientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClientsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MapsTree
            // 
            this.MapsTree.Location = new System.Drawing.Point(437, 50);
            this.MapsTree.Name = "MapsTree";
            this.MapsTree.Size = new System.Drawing.Size(134, 392);
            this.MapsTree.TabIndex = 2;
            this.MapsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MapsTree_AfterSelect);
            // 
            // CatalogTab
            // 
            this.CatalogTab.Location = new System.Drawing.Point(4, 27);
            this.CatalogTab.Name = "CatalogTab";
            this.CatalogTab.Padding = new System.Windows.Forms.Padding(3);
            this.CatalogTab.Size = new System.Drawing.Size(424, 410);
            this.CatalogTab.TabIndex = 2;
            this.CatalogTab.Text = "Catalog";
            this.CatalogTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AurNTBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(581, 454);
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
        private System.Windows.Forms.Button button1;
    }
}

