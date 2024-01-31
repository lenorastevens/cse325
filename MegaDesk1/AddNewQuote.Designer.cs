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
            this.components = new System.ComponentModel.Container();
            this.CloseAddNewQuoteButton = new System.Windows.Forms.Button();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.NumOfDrawersLabel = new System.Windows.Forms.Label();
            this.DeskTopMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.NumDrawers = new System.Windows.Forms.NumericUpDown();
            this.RushSelection = new System.Windows.Forms.ListBox();
            this.SubmitQuote = new System.Windows.Forms.Button();
            this.QuoteDateLabel = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.TextBox();
            this.DeskDepth = new System.Windows.Forms.TextBox();
            this.Material = new System.Windows.Forms.ComboBox();
            this.QuoteDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseAddNewQuoteButton
            // 
            this.CloseAddNewQuoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseAddNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAddNewQuoteButton.Location = new System.Drawing.Point(1685, 1214);
            this.CloseAddNewQuoteButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CloseAddNewQuoteButton.Name = "CloseAddNewQuoteButton";
            this.CloseAddNewQuoteButton.Size = new System.Drawing.Size(373, 95);
            this.CloseAddNewQuoteButton.TabIndex = 9;
            this.CloseAddNewQuoteButton.Text = "Main Menu";
            this.CloseAddNewQuoteButton.UseVisualStyleBackColor = true;
            this.CloseAddNewQuoteButton.Click += new System.EventHandler(this.CloseAddNewQuoteButton_Click);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(131, 231);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(418, 58);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(131, 420);
            this.DeskWidthLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(520, 58);
            this.DeskWidthLabel.TabIndex = 2;
            this.DeskWidthLabel.Text = "Desk Width (inches): ";
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(131, 541);
            this.DeskDepthLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(526, 58);
            this.DeskDepthLabel.TabIndex = 3;
            this.DeskDepthLabel.Text = "Desk Depth (inches): ";
            // 
            // NumOfDrawersLabel
            // 
            this.NumOfDrawersLabel.AutoSize = true;
            this.NumOfDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfDrawersLabel.Location = new System.Drawing.Point(131, 658);
            this.NumOfDrawersLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.NumOfDrawersLabel.Name = "NumOfDrawersLabel";
            this.NumOfDrawersLabel.Size = new System.Drawing.Size(505, 58);
            this.NumOfDrawersLabel.TabIndex = 4;
            this.NumOfDrawersLabel.Text = "Number of Drawers: ";
            // 
            // DeskTopMaterialLabel
            // 
            this.DeskTopMaterialLabel.AutoSize = true;
            this.DeskTopMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskTopMaterialLabel.Location = new System.Drawing.Point(131, 761);
            this.DeskTopMaterialLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DeskTopMaterialLabel.Name = "DeskTopMaterialLabel";
            this.DeskTopMaterialLabel.Size = new System.Drawing.Size(446, 58);
            this.DeskTopMaterialLabel.TabIndex = 5;
            this.DeskTopMaterialLabel.Text = "Desktop Material: ";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(131, 885);
            this.RushOrderLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(455, 58);
            this.RushOrderLabel.TabIndex = 6;
            this.RushOrderLabel.Text = "Rush Order Days: ";
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(779, 224);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(921, 64);
            this.CustomerName.TabIndex = 2;
            this.CustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerName_Validating);
            // 
            // NumDrawers
            // 
            this.NumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDrawers.Location = new System.Drawing.Point(779, 653);
            this.NumDrawers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NumDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumDrawers.Name = "NumDrawers";
            this.NumDrawers.Size = new System.Drawing.Size(104, 64);
            this.NumDrawers.TabIndex = 5;
            // 
            // RushSelection
            // 
            this.RushSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushSelection.FormattingEnabled = true;
            this.RushSelection.ItemHeight = 58;
            this.RushSelection.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.RushSelection.Location = new System.Drawing.Point(779, 885);
            this.RushSelection.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RushSelection.Name = "RushSelection";
            this.RushSelection.Size = new System.Drawing.Size(104, 236);
            this.RushSelection.TabIndex = 7;
            this.RushSelection.Validating += new System.ComponentModel.CancelEventHandler(this.RushSelection_Validating);
            // 
            // SubmitQuote
            // 
            this.SubmitQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitQuote.Location = new System.Drawing.Point(779, 1214);
            this.SubmitQuote.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SubmitQuote.Name = "SubmitQuote";
            this.SubmitQuote.Size = new System.Drawing.Size(373, 95);
            this.SubmitQuote.TabIndex = 8;
            this.SubmitQuote.Text = "Submit Quote";
            this.SubmitQuote.UseVisualStyleBackColor = true;
            this.SubmitQuote.Click += new System.EventHandler(this.SubmitQuote_Click);
            // 
            // QuoteDateLabel
            // 
            this.QuoteDateLabel.AutoSize = true;
            this.QuoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDateLabel.Location = new System.Drawing.Point(131, 114);
            this.QuoteDateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.QuoteDateLabel.Name = "QuoteDateLabel";
            this.QuoteDateLabel.Size = new System.Drawing.Size(320, 58);
            this.QuoteDateLabel.TabIndex = 19;
            this.QuoteDateLabel.Text = "Quote Date: ";
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(779, 413);
            this.DeskWidth.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(287, 64);
            this.DeskWidth.TabIndex = 3;
            this.DeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidth_Validating);
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(779, 534);
            this.DeskDepth.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(287, 64);
            this.DeskDepth.TabIndex = 4;
            this.DeskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskDepth_KeyPress);
            this.DeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDepth_Validating);
            // 
            // Material
            // 
            this.Material.DisplayMember = "\"\"";
            this.Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.FormattingEnabled = true;
            this.Material.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.Material.Location = new System.Drawing.Point(779, 754);
            this.Material.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(356, 66);
            this.Material.TabIndex = 6;
            this.Material.Validating += new System.ComponentModel.CancelEventHandler(this.Material_Validating);
            // 
            // QuoteDate
            // 
            this.QuoteDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDate.CustomFormat = "";
            this.QuoteDate.Enabled = false;
            this.QuoteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.QuoteDate.Location = new System.Drawing.Point(779, 103);
            this.QuoteDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.Size = new System.Drawing.Size(401, 64);
            this.QuoteDate.TabIndex = 1;
            this.QuoteDate.Value = new System.DateTime(2024, 1, 30, 0, 0, 0, 0);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.CloseAddNewQuoteButton;
            this.ClientSize = new System.Drawing.Size(2091, 1338);
            this.Controls.Add(this.QuoteDate);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.QuoteDateLabel);
            this.Controls.Add(this.SubmitQuote);
            this.Controls.Add(this.RushSelection);
            this.Controls.Add(this.NumDrawers);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.DeskTopMaterialLabel);
            this.Controls.Add(this.NumOfDrawersLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CloseAddNewQuoteButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.NumDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.NumericUpDown NumDrawers;
        private System.Windows.Forms.ListBox RushSelection;
        private System.Windows.Forms.Button SubmitQuote;
        private System.Windows.Forms.Label QuoteDateLabel;
        private System.Windows.Forms.TextBox DeskWidth;
        private System.Windows.Forms.TextBox DeskDepth;
        private System.Windows.Forms.ComboBox Material;
        private System.Windows.Forms.DateTimePicker QuoteDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}