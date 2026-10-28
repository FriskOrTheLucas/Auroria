namespace Auroria.NT
{
    partial class BodyColorsWindow
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Black Color"}, -1, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(53))))), null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Br. yellowish green"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(189)))), ((int)(((byte)(71))))), null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Br. yellowish orange"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(154)))), ((int)(((byte)(66))))), null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bright blue"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(105)))), ((int)(((byte)(172))))), null);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bright yellow"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(48))))), null);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cool Yellow"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(234)))), ((int)(((byte)(141))))), null);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "White Color"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243))))), null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodyColorsWindow));
            this.bodycolorListView = new System.Windows.Forms.ListView();
            this.colorList = new System.Windows.Forms.ImageList(this.components);
            this.LeftLegColorBox = new System.Windows.Forms.PictureBox();
            this.RightLegColorBox = new System.Windows.Forms.PictureBox();
            this.RightArmColorBox = new System.Windows.Forms.PictureBox();
            this.LeftArmColorBox = new System.Windows.Forms.PictureBox();
            this.TorsoColorBox = new System.Windows.Forms.PictureBox();
            this.HeadColorBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLegColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLegColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArmColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArmColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TorsoColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bodycolorListView
            // 
            this.bodycolorListView.HideSelection = false;
            listViewItem1.Tag = "26";
            listViewItem2.Tag = "119";
            listViewItem3.Tag = "105";
            listViewItem4.Tag = "23";
            listViewItem5.Tag = "24";
            listViewItem6.Tag = "226";
            listViewItem7.Tag = "1";
            listViewItem7.ToolTipText = "Classic";
            this.bodycolorListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.bodycolorListView.Location = new System.Drawing.Point(12, 12);
            this.bodycolorListView.Name = "bodycolorListView";
            this.bodycolorListView.Size = new System.Drawing.Size(269, 352);
            this.bodycolorListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.bodycolorListView.TabIndex = 0;
            this.bodycolorListView.UseCompatibleStateImageBehavior = false;
            this.bodycolorListView.SelectedIndexChanged += new System.EventHandler(this.bodycolorListView_SelectedIndexChanged);
            // 
            // colorList
            // 
            this.colorList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.colorList.ImageSize = new System.Drawing.Size(32, 32);
            this.colorList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LeftLegColorBox
            // 
            this.LeftLegColorBox.BackColor = System.Drawing.Color.White;
            this.LeftLegColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftLegColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftLegColorBox.Location = new System.Drawing.Point(401, 243);
            this.LeftLegColorBox.Name = "LeftLegColorBox";
            this.LeftLegColorBox.Size = new System.Drawing.Size(46, 107);
            this.LeftLegColorBox.TabIndex = 6;
            this.LeftLegColorBox.TabStop = false;
            this.LeftLegColorBox.Click += new System.EventHandler(this.LeftLegColorBox_Click);
            // 
            // RightLegColorBox
            // 
            this.RightLegColorBox.BackColor = System.Drawing.Color.White;
            this.RightLegColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightLegColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightLegColorBox.Location = new System.Drawing.Point(347, 243);
            this.RightLegColorBox.Name = "RightLegColorBox";
            this.RightLegColorBox.Size = new System.Drawing.Size(46, 107);
            this.RightLegColorBox.TabIndex = 5;
            this.RightLegColorBox.TabStop = false;
            this.RightLegColorBox.Click += new System.EventHandler(this.RightLegColorBox_Click);
            // 
            // RightArmColorBox
            // 
            this.RightArmColorBox.BackColor = System.Drawing.Color.White;
            this.RightArmColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightArmColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightArmColorBox.Location = new System.Drawing.Point(295, 130);
            this.RightArmColorBox.Name = "RightArmColorBox";
            this.RightArmColorBox.Size = new System.Drawing.Size(46, 107);
            this.RightArmColorBox.TabIndex = 4;
            this.RightArmColorBox.TabStop = false;
            this.RightArmColorBox.Click += new System.EventHandler(this.RightArmColorBox_Click);
            // 
            // LeftArmColorBox
            // 
            this.LeftArmColorBox.BackColor = System.Drawing.Color.White;
            this.LeftArmColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftArmColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftArmColorBox.Location = new System.Drawing.Point(453, 130);
            this.LeftArmColorBox.Name = "LeftArmColorBox";
            this.LeftArmColorBox.Size = new System.Drawing.Size(46, 107);
            this.LeftArmColorBox.TabIndex = 3;
            this.LeftArmColorBox.TabStop = false;
            this.LeftArmColorBox.Click += new System.EventHandler(this.LeftArmColorBox_Click);
            // 
            // TorsoColorBox
            // 
            this.TorsoColorBox.BackColor = System.Drawing.Color.White;
            this.TorsoColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TorsoColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TorsoColorBox.Location = new System.Drawing.Point(347, 130);
            this.TorsoColorBox.Name = "TorsoColorBox";
            this.TorsoColorBox.Size = new System.Drawing.Size(100, 107);
            this.TorsoColorBox.TabIndex = 2;
            this.TorsoColorBox.TabStop = false;
            this.TorsoColorBox.Click += new System.EventHandler(this.TorsoColorBox_Click);
            // 
            // HeadColorBox
            // 
            this.HeadColorBox.BackColor = System.Drawing.Color.White;
            this.HeadColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeadColorBox.Location = new System.Drawing.Point(347, 74);
            this.HeadColorBox.Name = "HeadColorBox";
            this.HeadColorBox.Size = new System.Drawing.Size(100, 50);
            this.HeadColorBox.TabIndex = 1;
            this.HeadColorBox.TabStop = false;
            this.HeadColorBox.Click += new System.EventHandler(this.HeadColorBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Your Color!";
            // 
            // BodyColorsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftLegColorBox);
            this.Controls.Add(this.RightLegColorBox);
            this.Controls.Add(this.RightArmColorBox);
            this.Controls.Add(this.LeftArmColorBox);
            this.Controls.Add(this.TorsoColorBox);
            this.Controls.Add(this.HeadColorBox);
            this.Controls.Add(this.bodycolorListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BodyColorsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Colors";
            this.Load += new System.EventHandler(this.BodyColorsWindow_load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftLegColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLegColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArmColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArmColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TorsoColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bodycolorListView;
        private System.Windows.Forms.ImageList colorList;
        private System.Windows.Forms.PictureBox HeadColorBox;
        private System.Windows.Forms.PictureBox TorsoColorBox;
        private System.Windows.Forms.PictureBox LeftArmColorBox;
        private System.Windows.Forms.PictureBox RightArmColorBox;
        private System.Windows.Forms.PictureBox RightLegColorBox;
        private System.Windows.Forms.PictureBox LeftLegColorBox;
        private System.Windows.Forms.Label label1;
    }
}