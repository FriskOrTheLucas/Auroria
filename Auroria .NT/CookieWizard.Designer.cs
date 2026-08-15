namespace Auroria.NT
{
    partial class CookieWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookieWizard));
            this.PasteText = new System.Windows.Forms.Label();
            this.CookieBox = new System.Windows.Forms.TextBox();
            this.FinishedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasteText
            // 
            this.PasteText.AutoSize = true;
            this.PasteText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteText.Location = new System.Drawing.Point(12, 21);
            this.PasteText.Name = "PasteText";
            this.PasteText.Size = new System.Drawing.Size(336, 19);
            this.PasteText.TabIndex = 0;
            this.PasteText.Text = "Please paste in your ROBLOSECURITY cookie.";
            // 
            // CookieBox
            // 
            this.CookieBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CookieBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookieBox.Location = new System.Drawing.Point(4, 57);
            this.CookieBox.Name = "CookieBox";
            this.CookieBox.PasswordChar = '*';
            this.CookieBox.Size = new System.Drawing.Size(344, 22);
            this.CookieBox.TabIndex = 1;
            // 
            // FinishedBtn
            // 
            this.FinishedBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishedBtn.Location = new System.Drawing.Point(107, 94);
            this.FinishedBtn.Name = "FinishedBtn";
            this.FinishedBtn.Size = new System.Drawing.Size(132, 34);
            this.FinishedBtn.TabIndex = 2;
            this.FinishedBtn.Text = "Finished";
            this.FinishedBtn.UseVisualStyleBackColor = true;
            this.FinishedBtn.Click += new System.EventHandler(this.FinishedBtn_Click);
            // 
            // CookieWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 140);
            this.Controls.Add(this.FinishedBtn);
            this.Controls.Add(this.CookieBox);
            this.Controls.Add(this.PasteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CookieWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROBLOSECURITY Cookie Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasteText;
        private System.Windows.Forms.TextBox CookieBox;
        private System.Windows.Forms.Button FinishedBtn;
    }
}