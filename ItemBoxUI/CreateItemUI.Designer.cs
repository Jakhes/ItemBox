namespace ItemBoxUI
{
    partial class CreateItemUI
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
            HeaderLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CreateButton = new Button();
            DescriptionRichText = new RichTextBox();
            LoreRichText = new RichTextBox();
            ValueTextBox = new TextBox();
            DescriptionLabel = new Label();
            ValueLabel = new Label();
            LoreLabel = new Label();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = Color.LightYellow;
            HeaderLabel.Location = new Point(91, 41);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(223, 38);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Create Item:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.ForeColor = Color.LightYellow;
            NameLabel.Location = new Point(75, 104);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(94, 31);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            NameLabel.Click += label1_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(64, 64, 64);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(75, 138);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Item Name";
            NameTextBox.Size = new Size(261, 38);
            NameTextBox.TabIndex = 3;
            // 
            // CreateButton
            // 
            CreateButton.FlatAppearance.BorderSize = 2;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Font = new Font("Georgia", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CreateButton.Location = new Point(103, 611);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(200, 50);
            CreateButton.TabIndex = 4;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // DescriptionRichText
            // 
            DescriptionRichText.BackColor = Color.FromArgb(64, 64, 64);
            DescriptionRichText.BorderStyle = BorderStyle.FixedSingle;
            DescriptionRichText.ForeColor = Color.LightYellow;
            DescriptionRichText.Location = new Point(75, 226);
            DescriptionRichText.Name = "DescriptionRichText";
            DescriptionRichText.Size = new Size(261, 89);
            DescriptionRichText.TabIndex = 5;
            DescriptionRichText.Text = "";
            // 
            // LoreRichText
            // 
            LoreRichText.BackColor = Color.FromArgb(64, 64, 64);
            LoreRichText.BorderStyle = BorderStyle.FixedSingle;
            LoreRichText.ForeColor = Color.LightYellow;
            LoreRichText.Location = new Point(75, 470);
            LoreRichText.Name = "LoreRichText";
            LoreRichText.Size = new Size(261, 96);
            LoreRichText.TabIndex = 6;
            LoreRichText.Text = "";
            // 
            // ValueTextBox
            // 
            ValueTextBox.BackColor = Color.FromArgb(64, 64, 64);
            ValueTextBox.BorderStyle = BorderStyle.FixedSingle;
            ValueTextBox.ForeColor = Color.LightYellow;
            ValueTextBox.Location = new Point(75, 375);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.PlaceholderText = "1000";
            ValueTextBox.Size = new Size(261, 38);
            ValueTextBox.TabIndex = 7;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.ForeColor = Color.LightYellow;
            DescriptionLabel.Location = new Point(75, 192);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(161, 31);
            DescriptionLabel.TabIndex = 8;
            DescriptionLabel.Text = "Description:";
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.ForeColor = Color.LightYellow;
            ValueLabel.Location = new Point(75, 341);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(91, 31);
            ValueLabel.TabIndex = 9;
            ValueLabel.Text = "Value:";
            // 
            // LoreLabel
            // 
            LoreLabel.AutoSize = true;
            LoreLabel.ForeColor = Color.LightYellow;
            LoreLabel.Location = new Point(75, 436);
            LoreLabel.Name = "LoreLabel";
            LoreLabel.Size = new Size(77, 31);
            LoreLabel.TabIndex = 10;
            LoreLabel.Text = "Lore:";
            // 
            // CreateItemUI
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1829, 930);
            Controls.Add(LoreLabel);
            Controls.Add(ValueLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(ValueTextBox);
            Controls.Add(LoreRichText);
            Controls.Add(DescriptionRichText);
            Controls.Add(CreateButton);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Honeydew;
            Margin = new Padding(7, 6, 7, 6);
            Name = "CreateItemUI";
            Text = "CreateItem View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button CreateButton;
        private RichTextBox DescriptionRichText;
        private RichTextBox LoreRichText;
        private TextBox ValueTextBox;
        private Label DescriptionLabel;
        private Label ValueLabel;
        private Label LoreLabel;
    }
}