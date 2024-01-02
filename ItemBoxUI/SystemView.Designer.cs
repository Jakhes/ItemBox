namespace ItemBoxUI
{
    partial class SystemView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SystemNameLabel = new Label();
            listBox1 = new ListBox();
            AddItemButton = new Button();
            SuspendLayout();
            // 
            // SystemNameLabel
            // 
            SystemNameLabel.AutoSize = true;
            SystemNameLabel.Font = new Font("Georgia", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SystemNameLabel.ForeColor = Color.LightYellow;
            SystemNameLabel.Location = new Point(12, 9);
            SystemNameLabel.Name = "SystemNameLabel";
            SystemNameLabel.Size = new Size(314, 41);
            SystemNameLabel.TabIndex = 0;
            SystemNameLabel.Text = "<System Name>";
            SystemNameLabel.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = Color.DimGray;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = SystemColors.Info;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(134, 86);
            listBox1.Margin = new Padding(15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(646, 225);
            listBox1.TabIndex = 1;
            // 
            // AddItemButton
            // 
            AddItemButton.FlatAppearance.BorderSize = 2;
            AddItemButton.FlatStyle = FlatStyle.Flat;
            AddItemButton.Font = new Font("Georgia", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddItemButton.ForeColor = Color.Honeydew;
            AddItemButton.Location = new Point(560, 353);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(200, 50);
            AddItemButton.TabIndex = 5;
            AddItemButton.Text = "Add New";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // SystemView
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(914, 450);
            Controls.Add(AddItemButton);
            Controls.Add(listBox1);
            Controls.Add(SystemNameLabel);
            Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SystemView";
            Text = "ItemBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SystemNameLabel;
        private ListBox listBox1;
        private Button AddItemButton;
    }
}
