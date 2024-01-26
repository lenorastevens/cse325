namespace MegaDesk1
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
            this.CloseViewAllQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseViewAllQuotesButton
            // 
            this.CloseViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseViewAllQuotesButton.Location = new System.Drawing.Point(632, 509);
            this.CloseViewAllQuotesButton.Name = "CloseViewAllQuotesButton";
            this.CloseViewAllQuotesButton.Size = new System.Drawing.Size(140, 40);
            this.CloseViewAllQuotesButton.TabIndex = 0;
            this.CloseViewAllQuotesButton.Text = "Close";
            this.CloseViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.CloseViewAllQuotesButton.Click += new System.EventHandler(this.CloseViewAllQuotesButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CloseViewAllQuotesButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseViewAllQuotesButton;
    }
}