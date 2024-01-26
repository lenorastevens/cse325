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
            this.SuspendLayout();
            // 
            // AddQuotesButton
            // 
            this.AddQuotesButton.Location = new System.Drawing.Point(262, 83);
            this.AddQuotesButton.Name = "AddQuotesButton";
            this.AddQuotesButton.Size = new System.Drawing.Size(188, 130);
            this.AddQuotesButton.TabIndex = 0;
            this.AddQuotesButton.Text = "Add Quotes";
            this.AddQuotesButton.UseVisualStyleBackColor = true;
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 755);
            this.Controls.Add(this.AddQuotesButton);
            this.Name = "MegaDesk";
            this.Text = "Mega Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuotesButton;
    }
}

