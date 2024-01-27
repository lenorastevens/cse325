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
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.NumOfDrawersLabel = new System.Windows.Forms.Label();
            this.DeskTopMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.CustomerNameEntry = new System.Windows.Forms.TextBox();
            this.Laminate = new System.Windows.Forms.RadioButton();
            this.Oak = new System.Windows.Forms.RadioButton();
            this.Rosewood = new System.Windows.Forms.RadioButton();
            this.Veneer = new System.Windows.Forms.RadioButton();
            this.Pine = new System.Windows.Forms.RadioButton();
            this.NumOfDrawersChoice = new System.Windows.Forms.NumericUpDown();
            this.RushSelection = new System.Windows.Forms.ListBox();
            this.SubmitQuote = new System.Windows.Forms.Button();
            this.QuoteDateLabel = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.NumericUpDown();
            this.DeskWidth = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfDrawersChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseAddNewQuoteButton
            // 
            this.CloseAddNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAddNewQuoteButton.Location = new System.Drawing.Point(632, 509);
            this.CloseAddNewQuoteButton.Name = "CloseAddNewQuoteButton";
            this.CloseAddNewQuoteButton.Size = new System.Drawing.Size(140, 40);
            this.CloseAddNewQuoteButton.TabIndex = 0;
            this.CloseAddNewQuoteButton.Text = "Main Menu";
            this.CloseAddNewQuoteButton.UseVisualStyleBackColor = true;
            this.CloseAddNewQuoteButton.Click += new System.EventHandler(this.CloseAddNewQuoteButton_Click);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(49, 97);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(174, 25);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(49, 176);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(221, 25);
            this.DeskWidthLabel.TabIndex = 2;
            this.DeskWidthLabel.Text = "Desk Width (inches): ";
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(49, 227);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(222, 25);
            this.DeskDepthLabel.TabIndex = 3;
            this.DeskDepthLabel.Text = "Desk Depth (inches): ";
            // 
            // NumOfDrawersLabel
            // 
            this.NumOfDrawersLabel.AutoSize = true;
            this.NumOfDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfDrawersLabel.Location = new System.Drawing.Point(49, 276);
            this.NumOfDrawersLabel.Name = "NumOfDrawersLabel";
            this.NumOfDrawersLabel.Size = new System.Drawing.Size(209, 25);
            this.NumOfDrawersLabel.TabIndex = 4;
            this.NumOfDrawersLabel.Text = "Number of Drawers: ";
            // 
            // DeskTopMaterialLabel
            // 
            this.DeskTopMaterialLabel.AutoSize = true;
            this.DeskTopMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskTopMaterialLabel.Location = new System.Drawing.Point(49, 319);
            this.DeskTopMaterialLabel.Name = "DeskTopMaterialLabel";
            this.DeskTopMaterialLabel.Size = new System.Drawing.Size(187, 25);
            this.DeskTopMaterialLabel.TabIndex = 5;
            this.DeskTopMaterialLabel.Text = "Desktop Material: ";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(49, 509);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(231, 25);
            this.RushOrderLabel.TabIndex = 6;
            this.RushOrderLabel.Text = "Rush Order Selection: ";
            // 
            // CustomerNameEntry
            // 
            this.CustomerNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameEntry.Location = new System.Drawing.Point(292, 94);
            this.CustomerNameEntry.Name = "CustomerNameEntry";
            this.CustomerNameEntry.Size = new System.Drawing.Size(348, 30);
            this.CustomerNameEntry.TabIndex = 7;
            // 
            // Laminate
            // 
            this.Laminate.AutoSize = true;
            this.Laminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laminate.Location = new System.Drawing.Point(292, 317);
            this.Laminate.Name = "Laminate";
            this.Laminate.Size = new System.Drawing.Size(110, 29);
            this.Laminate.TabIndex = 11;
            this.Laminate.TabStop = true;
            this.Laminate.Text = "Laminate";
            this.Laminate.UseVisualStyleBackColor = true;
            // 
            // Oak
            // 
            this.Oak.AutoSize = true;
            this.Oak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oak.Location = new System.Drawing.Point(292, 352);
            this.Oak.Name = "Oak";
            this.Oak.Size = new System.Drawing.Size(67, 29);
            this.Oak.TabIndex = 12;
            this.Oak.TabStop = true;
            this.Oak.Text = "Oak";
            this.Oak.UseVisualStyleBackColor = true;
            // 
            // Rosewood
            // 
            this.Rosewood.AutoSize = true;
            this.Rosewood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rosewood.Location = new System.Drawing.Point(292, 387);
            this.Rosewood.Name = "Rosewood";
            this.Rosewood.Size = new System.Drawing.Size(122, 29);
            this.Rosewood.TabIndex = 13;
            this.Rosewood.TabStop = true;
            this.Rosewood.Text = "Rosewood";
            this.Rosewood.UseVisualStyleBackColor = true;
            // 
            // Veneer
            // 
            this.Veneer.AutoSize = true;
            this.Veneer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Veneer.Location = new System.Drawing.Point(292, 422);
            this.Veneer.Name = "Veneer";
            this.Veneer.Size = new System.Drawing.Size(94, 29);
            this.Veneer.TabIndex = 14;
            this.Veneer.TabStop = true;
            this.Veneer.Text = "Veneer";
            this.Veneer.UseVisualStyleBackColor = true;
            // 
            // Pine
            // 
            this.Pine.AutoSize = true;
            this.Pine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pine.Location = new System.Drawing.Point(292, 457);
            this.Pine.Name = "Pine";
            this.Pine.Size = new System.Drawing.Size(69, 29);
            this.Pine.TabIndex = 15;
            this.Pine.TabStop = true;
            this.Pine.Text = "Pine";
            this.Pine.UseVisualStyleBackColor = true;
            // 
            // NumOfDrawersChoice
            // 
            this.NumOfDrawersChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfDrawersChoice.Location = new System.Drawing.Point(292, 274);
            this.NumOfDrawersChoice.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumOfDrawersChoice.Name = "NumOfDrawersChoice";
            this.NumOfDrawersChoice.Size = new System.Drawing.Size(39, 30);
            this.NumOfDrawersChoice.TabIndex = 16;
            // 
            // RushSelection
            // 
            this.RushSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushSelection.FormattingEnabled = true;
            this.RushSelection.ItemHeight = 25;
            this.RushSelection.Items.AddRange(new object[] {
            "None (14 days)",
            "3 days",
            "5 days",
            "7 days"});
            this.RushSelection.Location = new System.Drawing.Point(292, 505);
            this.RushSelection.Name = "RushSelection";
            this.RushSelection.Size = new System.Drawing.Size(185, 29);
            this.RushSelection.TabIndex = 17;
            // 
            // SubmitQuote
            // 
            this.SubmitQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitQuote.Location = new System.Drawing.Point(632, 457);
            this.SubmitQuote.Name = "SubmitQuote";
            this.SubmitQuote.Size = new System.Drawing.Size(140, 40);
            this.SubmitQuote.TabIndex = 18;
            this.SubmitQuote.Text = "Submit Quote";
            this.SubmitQuote.UseVisualStyleBackColor = true;
            // 
            // QuoteDateLabel
            // 
            this.QuoteDateLabel.AutoSize = true;
            this.QuoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDateLabel.Location = new System.Drawing.Point(49, 48);
            this.QuoteDateLabel.Name = "QuoteDateLabel";
            this.QuoteDateLabel.Size = new System.Drawing.Size(135, 25);
            this.QuoteDateLabel.TabIndex = 19;
            this.QuoteDateLabel.Text = "Quote Date: ";
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(292, 225);
            this.DeskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DeskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(50, 30);
            this.DeskDepth.TabIndex = 21;
            this.DeskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(292, 173);
            this.DeskWidth.Mask = "00";
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(30, 30);
            this.DeskWidth.TabIndex = 23;
            this.DeskWidth.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(292, 45);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(110, 30);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.CloseAddNewQuoteButton;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.QuoteDateLabel);
            this.Controls.Add(this.SubmitQuote);
            this.Controls.Add(this.RushSelection);
            this.Controls.Add(this.NumOfDrawersChoice);
            this.Controls.Add(this.Pine);
            this.Controls.Add(this.Veneer);
            this.Controls.Add(this.Rosewood);
            this.Controls.Add(this.Oak);
            this.Controls.Add(this.Laminate);
            this.Controls.Add(this.CustomerNameEntry);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.DeskTopMaterialLabel);
            this.Controls.Add(this.NumOfDrawersLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CloseAddNewQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfDrawersChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseAddNewQuoteButton;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.Label NumOfDrawersLabel;
        private System.Windows.Forms.Label DeskTopMaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.TextBox CustomerNameEntry;
        private System.Windows.Forms.RadioButton Laminate;
        private System.Windows.Forms.RadioButton Oak;
        private System.Windows.Forms.RadioButton Rosewood;
        private System.Windows.Forms.RadioButton Veneer;
        private System.Windows.Forms.RadioButton Pine;
        private System.Windows.Forms.NumericUpDown NumOfDrawersChoice;
        private System.Windows.Forms.ListBox RushSelection;
        private System.Windows.Forms.Button SubmitQuote;
        private System.Windows.Forms.Label QuoteDateLabel;
        private System.Windows.Forms.NumericUpDown DeskDepth;
        private System.Windows.Forms.MaskedTextBox DeskWidth;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}