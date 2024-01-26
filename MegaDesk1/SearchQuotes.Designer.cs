namespace MegaDesk1
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
            this.CloseSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseSearchButton
            // 
            this.CloseSearchButton.Location = new System.Drawing.Point(866, 826);
            this.CloseSearchButton.Name = "CloseSearchButton";
            this.CloseSearchButton.Size = new System.Drawing.Size(241, 97);
            this.CloseSearchButton.TabIndex = 0;
            this.CloseSearchButton.Text = "Close";
            this.CloseSearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 985);
            this.Controls.Add(this.CloseSearchButton);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseSearchButton;
    }
}