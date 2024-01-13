namespace ItemBoxUI
{
    partial class Dashboard
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
            panel1 = new Panel();
            label1 = new Label();
            SystemsCombobox = new ComboBox();
            SelectionLabel = new Label();
            LoadSystemButton = new Button();
            CreateSystemButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(148, 71, 62);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -18);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 123);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(242, 47);
            label1.Name = "label1";
            label1.Size = new Size(289, 43);
            label1.TabIndex = 0;
            label1.Text = "ItemBox V.0.1";
            // 
            // SystemsCombobox
            // 
            SystemsCombobox.BackColor = Color.FromArgb(61, 68, 78);
            SystemsCombobox.FlatStyle = FlatStyle.Flat;
            SystemsCombobox.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SystemsCombobox.ForeColor = Color.Lavender;
            SystemsCombobox.FormattingEnabled = true;
            SystemsCombobox.Location = new Point(210, 204);
            SystemsCombobox.Name = "SystemsCombobox";
            SystemsCombobox.Size = new Size(353, 39);
            SystemsCombobox.TabIndex = 1;
            // 
            // SelectionLabel
            // 
            SelectionLabel.AutoSize = true;
            SelectionLabel.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectionLabel.ForeColor = Color.Lavender;
            SelectionLabel.Location = new Point(210, 161);
            SelectionLabel.Name = "SelectionLabel";
            SelectionLabel.Size = new Size(185, 31);
            SelectionLabel.TabIndex = 2;
            SelectionLabel.Text = "Select System:";
            // 
            // LoadSystemButton
            // 
            LoadSystemButton.FlatAppearance.BorderSize = 2;
            LoadSystemButton.FlatStyle = FlatStyle.Flat;
            LoadSystemButton.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadSystemButton.ForeColor = Color.Lavender;
            LoadSystemButton.Location = new Point(210, 268);
            LoadSystemButton.Name = "LoadSystemButton";
            LoadSystemButton.Size = new Size(353, 40);
            LoadSystemButton.TabIndex = 3;
            LoadSystemButton.Text = "Load System";
            LoadSystemButton.UseVisualStyleBackColor = true;
            LoadSystemButton.Click += LoadSystemButton_Click;
            // 
            // CreateSystemButton
            // 
            CreateSystemButton.FlatAppearance.BorderSize = 2;
            CreateSystemButton.FlatStyle = FlatStyle.Flat;
            CreateSystemButton.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateSystemButton.ForeColor = Color.Lavender;
            CreateSystemButton.Location = new Point(210, 333);
            CreateSystemButton.Name = "CreateSystemButton";
            CreateSystemButton.Size = new Size(353, 40);
            CreateSystemButton.TabIndex = 4;
            CreateSystemButton.Text = "Create new System";
            CreateSystemButton.UseVisualStyleBackColor = true;
            CreateSystemButton.Click += CreateSystemButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 48, 59);
            ClientSize = new Size(800, 450);
            Controls.Add(CreateSystemButton);
            Controls.Add(LoadSystemButton);
            Controls.Add(SelectionLabel);
            Controls.Add(SystemsCombobox);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox SystemsCombobox;
        private Label SelectionLabel;
        private Button LoadSystemButton;
        private Button CreateSystemButton;
    }
}