namespace Auroria.NT
{
    partial class AvatarRendererWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvatarRendererWindow));
            this.RenderedBox = new System.Windows.Forms.PictureBox();
            this.RenderButton = new System.Windows.Forms.Button();
            this.ClientSelection = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.RenderedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderedBox
            // 
            this.RenderedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RenderedBox.Location = new System.Drawing.Point(58, 45);
            this.RenderedBox.Name = "RenderedBox";
            this.RenderedBox.Size = new System.Drawing.Size(261, 261);
            this.RenderedBox.TabIndex = 0;
            this.RenderedBox.TabStop = false;
            // 
            // RenderButton
            // 
            this.RenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenderButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenderButton.Location = new System.Drawing.Point(58, 323);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(261, 30);
            this.RenderButton.TabIndex = 1;
            this.RenderButton.Text = "Draw Avatar!";
            this.RenderButton.UseVisualStyleBackColor = true;
            // 
            // ClientSelection
            // 
            this.ClientSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientSelection.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSelection.FormattingEnabled = true;
            this.ClientSelection.ItemHeight = 17;
            this.ClientSelection.Location = new System.Drawing.Point(135, 20);
            this.ClientSelection.Name = "ClientSelection";
            this.ClientSelection.Size = new System.Drawing.Size(107, 19);
            this.ClientSelection.TabIndex = 2;
            // 
            // AvatarRendererWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 365);
            this.Controls.Add(this.ClientSelection);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.RenderedBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AvatarRendererWindow";
            this.ShowInTaskbar = false;
            this.Text = "Renderer";
            ((System.ComponentModel.ISupportInitialize)(this.RenderedBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RenderedBox;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.ListBox ClientSelection;
    }
}