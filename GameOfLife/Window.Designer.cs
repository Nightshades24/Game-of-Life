namespace GameOfLife
{
    partial class Window
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
            this.textBoxLeven = new System.Windows.Forms.TextBox();
            this.textBoxBlijfLeven = new System.Windows.Forms.TextBox();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.LevenScheppen = new System.Windows.Forms.Label();
            this.BlijfLeven = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.Label();
            this.Pauze = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.RadioButton();
            this.NoButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSnelheid = new System.Windows.Forms.TextBox();
            this.TemplateSelector = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLeven
            // 
            this.textBoxLeven.Location = new System.Drawing.Point(1050, 36);
            this.textBoxLeven.Name = "textBoxLeven";
            this.textBoxLeven.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeven.TabIndex = 0;
            this.textBoxLeven.Text = "3";
            // 
            // textBoxBlijfLeven
            // 
            this.textBoxBlijfLeven.Location = new System.Drawing.Point(1050, 88);
            this.textBoxBlijfLeven.Name = "textBoxBlijfLeven";
            this.textBoxBlijfLeven.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlijfLeven.TabIndex = 3;
            this.textBoxBlijfLeven.Text = "2, 3";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(1050, 145);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadius.TabIndex = 5;
            this.textBoxRadius.Text = "1";
            // 
            // LevenScheppen
            // 
            this.LevenScheppen.AutoSize = true;
            this.LevenScheppen.Location = new System.Drawing.Point(1047, 20);
            this.LevenScheppen.Name = "LevenScheppen";
            this.LevenScheppen.Size = new System.Drawing.Size(141, 13);
            this.LevenScheppen.TabIndex = 1;
            this.LevenScheppen.Text = "Number of cells to create life";
            // 
            // BlijfLeven
            // 
            this.BlijfLeven.AutoSize = true;
            this.BlijfLeven.Location = new System.Drawing.Point(1047, 72);
            this.BlijfLeven.Name = "BlijfLeven";
            this.BlijfLeven.Size = new System.Drawing.Size(139, 13);
            this.BlijfLeven.TabIndex = 4;
            this.BlijfLeven.Text = "Number of cells to stay alive";
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(1047, 129);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(40, 13);
            this.Radius.TabIndex = 2;
            this.Radius.Text = "Radius";
            // 
            // Pauze
            // 
            this.Pauze.Location = new System.Drawing.Point(1050, 308);
            this.Pauze.Name = "Pauze";
            this.Pauze.Size = new System.Drawing.Size(75, 23);
            this.Pauze.TabIndex = 6;
            this.Pauze.Text = "Pause";
            this.Pauze.UseVisualStyleBackColor = true;
            this.Pauze.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pauze_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Location = new System.Drawing.Point(20, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1002, 1002);
            this.panel.TabIndex = 7;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(1736, 997);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 8;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // YesButton
            // 
            this.YesButton.AutoSize = true;
            this.YesButton.Location = new System.Drawing.Point(1050, 240);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(43, 17);
            this.YesButton.TabIndex = 9;
            this.YesButton.TabStop = true;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.CheckedChanged += new System.EventHandler(this.YesButton_CheckedChanged);
            // 
            // NoButton
            // 
            this.NoButton.AutoSize = true;
            this.NoButton.Checked = true;
            this.NoButton.Location = new System.Drawing.Point(1131, 240);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(39, 17);
            this.NoButton.TabIndex = 10;
            this.NoButton.TabStop = true;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.CheckedChanged += new System.EventHandler(this.NoButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1047, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Display raster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1047, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Speed";
            // 
            // textBoxSnelheid
            // 
            this.textBoxSnelheid.Location = new System.Drawing.Point(1050, 201);
            this.textBoxSnelheid.Name = "textBoxSnelheid";
            this.textBoxSnelheid.Size = new System.Drawing.Size(100, 20);
            this.textBoxSnelheid.TabIndex = 13;
            this.textBoxSnelheid.Text = "10";
            // 
            // TemplateSelector
            // 
            this.TemplateSelector.FormattingEnabled = true;
            this.TemplateSelector.Items.AddRange(new object[] {
            "Empty",
            "Glider",
            "Fight"});
            this.TemplateSelector.Location = new System.Drawing.Point(1049, 272);
            this.TemplateSelector.Name = "TemplateSelector";
            this.TemplateSelector.Size = new System.Drawing.Size(121, 21);
            this.TemplateSelector.TabIndex = 14;
            this.TemplateSelector.Text = "Empty";
            this.TemplateSelector.SelectedIndexChanged += new System.EventHandler(this.TemplateSelector_ChoiceChanged);
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Location = new System.Drawing.Point(1817, 997);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 15;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(1131, 308);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(75, 23);
            this.Step.TabIndex = 16;
            this.Step.Text = "Step";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(1050, 308);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 17;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Play_Click);
            // 
            // Window
            // 
            this.AcceptButton = this.Step;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TemplateSelector);
            this.Controls.Add(this.textBoxSnelheid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Pauze);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.BlijfLeven);
            this.Controls.Add(this.textBoxBlijfLeven);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.LevenScheppen);
            this.Controls.Add(this.textBoxLeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLeven;
        private System.Windows.Forms.TextBox textBoxBlijfLeven;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label LevenScheppen;
        private System.Windows.Forms.Label BlijfLeven;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Button Pauze;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.RadioButton YesButton;
        private System.Windows.Forms.RadioButton NoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSnelheid;
        private System.Windows.Forms.ComboBox TemplateSelector;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Button Play;
    }
}

