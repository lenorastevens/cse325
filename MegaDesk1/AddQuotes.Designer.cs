namespace MegaDesk1
{
    partial class AddQuotes
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
            this.CloseAddQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseAddQuotesButton
            // 
            this.CloseAddQuotesButton.Location = new System.Drawing.Point(558, 357);
            this.CloseAddQuotesButton.Name = "CloseAddQuotesButton";
            this.CloseAddQuotesButton.Size = new System.Drawing.Size(215, 64);
            this.CloseAddQuotesButton.TabIndex = 0;
            this.CloseAddQuotesButton.Text = "Close";
            this.CloseAddQuotesButton.UseVisualStyleBackColor = true;
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseAddQuotesButton);
            this.Name = "AddQuotes";
            this.Text = "Add Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseAddQuotesButton;
    }
}