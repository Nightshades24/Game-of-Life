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
            this.Pauze = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.Button();
            this.textBoxSnelheid = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.RasterOn = new System.Windows.Forms.Button();
            this.RasterOff = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLeven
            // 
            this.textBoxLeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLeven.Location = new System.Drawing.Point(1042, 280);
            this.textBoxLeven.Name = "textBoxLeven";
            this.textBoxLeven.Size = new System.Drawing.Size(390, 24);
            this.textBoxLeven.TabIndex = 0;
            this.textBoxLeven.Text = "3";
            // 
            // textBoxBlijfLeven
            // 
            this.textBoxBlijfLeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlijfLeven.Location = new System.Drawing.Point(1042, 404);
            this.textBoxBlijfLeven.Name = "textBoxBlijfLeven";
            this.textBoxBlijfLeven.Size = new System.Drawing.Size(390, 24);
            this.textBoxBlijfLeven.TabIndex = 3;
            this.textBoxBlijfLeven.Text = "2, 3";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRadius.Location = new System.Drawing.Point(1042, 528);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(390, 24);
            this.textBoxRadius.TabIndex = 5;
            this.textBoxRadius.Text = "1";
            // 
            // Pauze
            // 
            this.Pauze.BackColor = System.Drawing.Color.Transparent;
            this.Pauze.BackgroundImage = global::GameOfLife.Properties.Resources.PAUZE;
            this.Pauze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pauze.FlatAppearance.BorderSize = 0;
            this.Pauze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Pauze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Pauze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pauze.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pauze.Location = new System.Drawing.Point(1034, 984);
            this.Pauze.Name = "Pauze";
            this.Pauze.Size = new System.Drawing.Size(120, 38);
            this.Pauze.TabIndex = 6;
            this.Pauze.UseVisualStyleBackColor = false;
            this.Pauze.Visible = false;
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
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.BackgroundImage = global::GameOfLife.Properties.Resources.HELP;
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Location = new System.Drawing.Point(1654, 984);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(120, 38);
            this.Help.TabIndex = 8;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // textBoxSnelheid
            // 
            this.textBoxSnelheid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSnelheid.Location = new System.Drawing.Point(1042, 653);
            this.textBoxSnelheid.Name = "textBoxSnelheid";
            this.textBoxSnelheid.Size = new System.Drawing.Size(390, 24);
            this.textBoxSnelheid.TabIndex = 13;
            this.textBoxSnelheid.Text = "10";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::GameOfLife.Properties.Resources.CLOSE;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(1784, 984);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(120, 38);
            this.Close.TabIndex = 15;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Step
            // 
            this.Step.BackColor = System.Drawing.Color.Transparent;
            this.Step.BackgroundImage = global::GameOfLife.Properties.Resources.STEP;
            this.Step.FlatAppearance.BorderSize = 0;
            this.Step.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Step.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Step.Location = new System.Drawing.Point(1164, 984);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(120, 38);
            this.Step.TabIndex = 16;
            this.Step.UseVisualStyleBackColor = false;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImage = global::GameOfLife.Properties.Resources.PLAY;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Location = new System.Drawing.Point(1034, 984);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(120, 38);
            this.Play.TabIndex = 17;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Play_Click);
            // 
            // RasterOn
            // 
            this.RasterOn.BackColor = System.Drawing.Color.Transparent;
            this.RasterOn.BackgroundImage = global::GameOfLife.Properties.Resources.ON;
            this.RasterOn.FlatAppearance.BorderSize = 0;
            this.RasterOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RasterOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RasterOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RasterOn.Location = new System.Drawing.Point(1034, 771);
            this.RasterOn.Name = "RasterOn";
            this.RasterOn.Size = new System.Drawing.Size(120, 38);
            this.RasterOn.TabIndex = 19;
            this.RasterOn.UseVisualStyleBackColor = false;
            this.RasterOn.Click += new System.EventHandler(this.RasterOn_Click);
            // 
            // RasterOff
            // 
            this.RasterOff.BackColor = System.Drawing.Color.Transparent;
            this.RasterOff.BackgroundImage = global::GameOfLife.Properties.Resources.OFF;
            this.RasterOff.FlatAppearance.BorderSize = 0;
            this.RasterOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RasterOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RasterOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RasterOff.Location = new System.Drawing.Point(1034, 771);
            this.RasterOff.Name = "RasterOff";
            this.RasterOff.Size = new System.Drawing.Size(120, 38);
            this.RasterOff.TabIndex = 18;
            this.RasterOff.UseVisualStyleBackColor = false;
            this.RasterOff.Visible = false;
            this.RasterOff.Click += new System.EventHandler(this.RasterOff_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Image = global::GameOfLife.Properties.Resources.RESET;
            this.Reset.Location = new System.Drawing.Point(1293, 983);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(120, 38);
            this.Reset.TabIndex = 20;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Window
            // 
            this.AcceptButton = this.Step;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::GameOfLife.Properties.Resources.BACKGROUND;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.RasterOff);
            this.Controls.Add(this.RasterOn);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.textBoxSnelheid);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Pauze);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.textBoxBlijfLeven);
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
        private System.Windows.Forms.Button Pauze;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.TextBox textBoxSnelheid;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button RasterOn;
        private System.Windows.Forms.Button RasterOff;
        private System.Windows.Forms.Button Reset;
    }
}

