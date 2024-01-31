namespace MegaDesk1
{
    partial class DisplayQuote
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
            this.CloseDisplayQuoteButton = new System.Windows.Forms.Button();
            this.CurrentNameLabel = new System.Windows.Forms.Label();
            this.CurrentDateLabel = new System.Windows.Forms.Label();
            this.CurrentPriceLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CurrentPrice = new System.Windows.Forms.Label();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseDisplayQuoteButton
            // 
            this.CloseDisplayQuoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseDisplayQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseDisplayQuoteButton.Location = new System.Drawing.Point(632, 509);
            this.CloseDisplayQuoteButton.Name = "CloseDisplayQuoteButton";
            this.CloseDisplayQuoteButton.Size = new System.Drawing.Size(140, 40);
            this.CloseDisplayQuoteButton.TabIndex = 1;
            this.CloseDisplayQuoteButton.Text = "Main Menu";
            this.CloseDisplayQuoteButton.UseVisualStyleBackColor = true;
            this.CloseDisplayQuoteButton.Click += new System.EventHandler(this.CloseDisplayQuoteButton_Click);
            // 
            // CurrentNameLabel
            // 
            this.CurrentNameLabel.AutoSize = true;
            this.CurrentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentNameLabel.Location = new System.Drawing.Point(99, 62);
            this.CurrentNameLabel.Name = "CurrentNameLabel";
            this.CurrentNameLabel.Size = new System.Drawing.Size(174, 25);
            this.CurrentNameLabel.TabIndex = 2;
            this.CurrentNameLabel.Text = "Customer Name:";
            // 
            // CurrentDateLabel
            // 
            this.CurrentDateLabel.AutoSize = true;
            this.CurrentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDateLabel.Location = new System.Drawing.Point(99, 138);
            this.CurrentDateLabel.Name = "CurrentDateLabel";
            this.CurrentDateLabel.Size = new System.Drawing.Size(129, 25);
            this.CurrentDateLabel.TabIndex = 4;
            this.CurrentDateLabel.Text = "Quote Date:";
            // 
            // CurrentPriceLabel
            // 
            this.CurrentPriceLabel.AutoSize = true;
            this.CurrentPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPriceLabel.Location = new System.Drawing.Point(99, 203);
            this.CurrentPriceLabel.Name = "CurrentPriceLabel";
            this.CurrentPriceLabel.Size = new System.Drawing.Size(133, 25);
            this.CurrentPriceLabel.TabIndex = 5;
            this.CurrentPriceLabel.Text = "Quote Price:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(295, 62);
            this.CustomerLabel.MinimumSize = new System.Drawing.Size(30, 0);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(30, 25);
            this.CustomerLabel.TabIndex = 8;
            // 
            // CurrentPrice
            // 
            this.CurrentPrice.AutoSize = true;
            this.CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPrice.Location = new System.Drawing.Point(295, 203);
            this.CurrentPrice.MinimumSize = new System.Drawing.Size(30, 0);
            this.CurrentPrice.Name = "CurrentPrice";
            this.CurrentPrice.Size = new System.Drawing.Size(30, 25);
            this.CurrentPrice.TabIndex = 9;
            this.CurrentPrice.Text = "$";
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(295, 138);
            this.CurrentDate.MinimumSize = new System.Drawing.Size(30, 0);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(30, 25);
            this.CurrentDate.TabIndex = 10;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.CloseDisplayQuoteButton;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.CurrentPrice);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.CurrentPriceLabel);
            this.Controls.Add(this.CurrentDateLabel);
            this.Controls.Add(this.CurrentNameLabel);
            this.Controls.Add(this.CloseDisplayQuoteButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseDisplayQuoteButton;
        private System.Windows.Forms.Label CurrentNameLabel;
        private System.Windows.Forms.Label CurrentDateLabel;
        private System.Windows.Forms.Label CurrentPriceLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label CurrentPrice;
        private System.Windows.Forms.Label CurrentDate;
    }
}