﻿namespace MegaDesk1
{
    partial class ViewAllQuotes
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
            this.CloseViewQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseViewQuotesButton
            // 
            this.CloseViewQuotesButton.Location = new System.Drawing.Point(574, 363);
            this.CloseViewQuotesButton.Name = "CloseViewQuotesButton";
            this.CloseViewQuotesButton.Size = new System.Drawing.Size(186, 64);
            this.CloseViewQuotesButton.TabIndex = 0;
            this.CloseViewQuotesButton.Text = "Close";
            this.CloseViewQuotesButton.UseVisualStyleBackColor = true;
            this.CloseViewQuotesButton.Click += new System.EventHandler(this.CloseViewQuotesButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 747);
            this.Controls.Add(this.CloseViewQuotesButton);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseViewQuotesButton;
    }
}