namespace MegaDesk1
{
    partial class MegaDesk
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
            this.AddQuotesButton = new System.Windows.Forms.Button();
            this.ViewQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuotesButton
            // 
            this.AddQuotesButton.Location = new System.Drawing.Point(95, 42);
            this.AddQuotesButton.Name = "AddQuotesButton";
            this.AddQuotesButton.Size = new System.Drawing.Size(410, 119);
            this.AddQuotesButton.TabIndex = 0;
            this.AddQuotesButton.Text = "&Add New Quote";
            this.AddQuotesButton.UseVisualStyleBackColor = true;
            // 
            // ViewQuotesButton
            // 
            this.ViewQuotesButton.Location = new System.Drawing.Point(95, 210);
            this.ViewQuotesButton.Name = "ViewQuotesButton";
            this.ViewQuotesButton.Size = new System.Drawing.Size(410, 118);
            this.ViewQuotesButton.TabIndex = 1;
            this.ViewQuotesButton.Text = "&View Quotes";
            this.ViewQuotesButton.UseVisualStyleBackColor = true;
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.Location = new System.Drawing.Point(95, 379);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(410, 117);
            this.SearchQuotesButton.TabIndex = 2;
            this.SearchQuotesButton.Text = "&Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(95, 542);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(410, 108);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 755);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewQuotesButton);
            this.Controls.Add(this.AddQuotesButton);
            this.Name = "MegaDesk";
            this.Text = "Mega Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuotesButton;
        private System.Windows.Forms.Button ViewQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

