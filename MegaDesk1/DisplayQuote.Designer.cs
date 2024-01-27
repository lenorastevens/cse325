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
            this.SuspendLayout();
            // 
            // CloseDisplayQuoteButton
            // 
            this.CloseDisplayQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseDisplayQuoteButton.Location = new System.Drawing.Point(632, 509);
            this.CloseDisplayQuoteButton.Name = "CloseDisplayQuoteButton";
            this.CloseDisplayQuoteButton.Size = new System.Drawing.Size(140, 40);
            this.CloseDisplayQuoteButton.TabIndex = 1;
            this.CloseDisplayQuoteButton.Text = "Main Menu";
            this.CloseDisplayQuoteButton.UseVisualStyleBackColor = true;
            this.CloseDisplayQuoteButton.Click += new System.EventHandler(this.CloseDisplayQuoteButton_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.CloseDisplayQuoteButton;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CloseDisplayQuoteButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseDisplayQuoteButton;
    }
}