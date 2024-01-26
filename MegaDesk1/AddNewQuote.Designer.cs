namespace MegaDesk1
{
    partial class AddNewQuote
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
            this.CloseAddNewQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseAddNewQuoteButton
            // 
            this.CloseAddNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAddNewQuoteButton.Location = new System.Drawing.Point(632, 509);
            this.CloseAddNewQuoteButton.Name = "CloseAddNewQuoteButton";
            this.CloseAddNewQuoteButton.Size = new System.Drawing.Size(140, 40);
            this.CloseAddNewQuoteButton.TabIndex = 0;
            this.CloseAddNewQuoteButton.Text = "Close";
            this.CloseAddNewQuoteButton.UseVisualStyleBackColor = true;
            this.CloseAddNewQuoteButton.Click += new System.EventHandler(this.CloseAddNewQuoteButton_Click);
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CloseAddNewQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseAddNewQuoteButton;
    }
}