namespace Auroria.NT
{
    partial class ItemMetadataCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemMetadataCreator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreatorLabel = new System.Windows.Forms.Label();
            this.CreatorBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CreateNewAsset = new System.Windows.Forms.CheckBox();
            this.ItemType = new System.Windows.Forms.ListBox();
            this.CreateMetadata = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreatorLabel);
            this.groupBox1.Controls.Add(this.CreatorBox);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.CreateNewAsset);
            this.groupBox1.Controls.Add(this.ItemType);
            this.groupBox1.Controls.Add(this.CreateMetadata);
            this.groupBox1.Controls.Add(this.IDLabel);
            this.groupBox1.Controls.Add(this.DescriptionLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.DescriptionBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Location = new System.Drawing.Point(12, 235);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(61, 17);
            this.CreatorLabel.TabIndex = 13;
            this.CreatorLabel.Text = "Creator";
            // 
            // CreatorBox
            // 
            this.CreatorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreatorBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorBox.Location = new System.Drawing.Point(15, 255);
            this.CreatorBox.Name = "CreatorBox";
            this.CreatorBox.Size = new System.Drawing.Size(265, 26);
            this.CreatorBox.TabIndex = 12;
            // 
            // DateBox
            // 
            this.DateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.Location = new System.Drawing.Point(15, 189);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(265, 26);
            this.DateBox.TabIndex = 11;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 169);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(99, 17);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Date Created";
            // 
            // CreateNewAsset
            // 
            this.CreateNewAsset.AutoSize = true;
            this.CreateNewAsset.Location = new System.Drawing.Point(184, 386);
            this.CreateNewAsset.Name = "CreateNewAsset";
            this.CreateNewAsset.Size = new System.Drawing.Size(139, 21);
            this.CreateNewAsset.TabIndex = 9;
            this.CreateNewAsset.Text = "Save Seperately";
            this.CreateNewAsset.UseVisualStyleBackColor = true;
            // 
            // ItemType
            // 
            this.ItemType.FormattingEnabled = true;
            this.ItemType.ItemHeight = 17;
            this.ItemType.Items.AddRange(new object[] {
            "charhats",
            "charpants",
            "charshirts",
            "chartshirt"});
            this.ItemType.Location = new System.Drawing.Point(15, 386);
            this.ItemType.Name = "ItemType";
            this.ItemType.Size = new System.Drawing.Size(163, 21);
            this.ItemType.TabIndex = 8;
            // 
            // CreateMetadata
            // 
            this.CreateMetadata.BackColor = System.Drawing.Color.White;
            this.CreateMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateMetadata.Location = new System.Drawing.Point(192, 334);
            this.CreateMetadata.Name = "CreateMetadata";
            this.CreateMetadata.Size = new System.Drawing.Size(88, 25);
            this.CreateMetadata.TabIndex = 7;
            this.CreateMetadata.Text = "Create";
            this.CreateMetadata.UseVisualStyleBackColor = false;
            this.CreateMetadata.Click += new System.EventHandler(this.CreateMetadata_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 313);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(56, 17);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "Item ID";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 104);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 17);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 17);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Item Name";
            // 
            // IDBox
            // 
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(15, 333);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(169, 26);
            this.IDBox.TabIndex = 3;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(15, 124);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(265, 26);
            this.DescriptionBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(15, 59);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(265, 26);
            this.NameBox.TabIndex = 1;
            // 
            // ItemMetadataCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 442);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemMetadataCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metadata Creator";
            this.Load += new System.EventHandler(this.ItemMetadataCreator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button CreateMetadata;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListBox ItemType;
        private System.Windows.Forms.CheckBox CreateNewAsset;
        private System.Windows.Forms.Label CreatorLabel;
        private System.Windows.Forms.TextBox CreatorBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label DateLabel;
    }
}