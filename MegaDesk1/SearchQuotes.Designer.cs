﻿namespace MegaDesk1
{
    partial class SearchQuotes
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
            this.CloseSearchQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseSearchQuotesButton
            // 
            this.CloseSearchQuotesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseSearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSearchQuotesButton.Location = new System.Drawing.Point(632, 509);
            this.CloseSearchQuotesButton.Name = "CloseSearchQuotesButton";
            this.CloseSearchQuotesButton.Size = new System.Drawing.Size(140, 40);
            this.CloseSearchQuotesButton.TabIndex = 0;
            this.CloseSearchQuotesButton.Text = "Main Menu";
            this.CloseSearchQuotesButton.UseVisualStyleBackColor = true;
            this.CloseSearchQuotesButton.Click += new System.EventHandler(this.CloseSearchQuotesButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.CloseSearchQuotesButton;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CloseSearchQuotesButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseSearchQuotesButton;
    }
}