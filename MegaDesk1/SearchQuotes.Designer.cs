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
            this.CloseSearchQuotesButton = new System.Windows.Forms.Button();
            this.SearchMaterial = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            // SearchMaterial
            // 
            this.SearchMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMaterial.FormattingEnabled = true;
            this.SearchMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.SearchMaterial.Location = new System.Drawing.Point(352, 24);
            this.SearchMaterial.Name = "SearchMaterial";
            this.SearchMaterial.Size = new System.Drawing.Size(301, 33);
            this.SearchMaterial.TabIndex = 3;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLabel.Location = new System.Drawing.Point(131, 27);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(202, 25);
            this.SearchByLabel.TabIndex = 4;
            this.SearchByLabel.Text = "Search By Material:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(722, 380);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.CloseSearchQuotesButton;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.SearchMaterial);
            this.Controls.Add(this.CloseSearchQuotesButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseSearchQuotesButton;
        private System.Windows.Forms.ComboBox SearchMaterial;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}