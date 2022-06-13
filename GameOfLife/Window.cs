using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GameOfLife
{
    public partial class Window : Form
    {
        public bool pauze = true;
        public bool lines = false;
        public bool lines_changed = false;
        public bool step = false;

        public int[] leven = new int[] { 3 };
        public int[] blijfleven = new int[] { 2, 3 };
        public int radius = 1;
        public int snelheid = 10;
        public int size = Sizeprompt.size;
        public bool[,] grid;

        public Window()
        {

            grid = BasePatterns.GetPattern("Empty", size);

            InitializeComponent();

            panel.Paint += Teken_Panel;
            textBoxLeven.Leave += Leven_Textbox;
            textBoxBlijfLeven.Leave += BlijfLeven_Textbox;
            textBoxRadius.Leave += Radius_Textbox;
            textBoxSnelheid.Leave += Snelheid_Textbox;
            panel.MouseClick += Panel_MouseClick;
            Pauze.MouseUp += Invalidate_Panel;
            Pauze.MouseLeave += Invalidate_Panel;
        }

        private void Invalidate_Panel(object sender, EventArgs e)
        {
            if (!pauze) panel.Invalidate();
        }

        // Pauze - play knop
        private void Pauze_Click(object sender, EventArgs e)
        {
            Pauze.Hide();
            pauze = true;
            textBoxLeven.ReadOnly = false;
            textBoxBlijfLeven.ReadOnly = false;
            textBoxRadius.ReadOnly = false;
            textBoxSnelheid.ReadOnly = false;
            TemplateSelector.Enabled = true;
            Play.Show();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Play.Hide();
            pauze = false;
            textBoxLeven.ReadOnly = true;
            textBoxBlijfLeven.ReadOnly = true;
            textBoxRadius.ReadOnly = true;
            textBoxSnelheid.ReadOnly = true;
            TemplateSelector.Enabled = false;
            Pauze.Show();
        }

        // Popup help scherm
        private void Help_Click(object sender, EventArgs e)
        {
            string message = "This is a simulation of Conway's Game of Life. At the start it has the default variables. When you pause the simulation, you can change these variables. You can enter multiple intigers in the first 2 textboxes and split them with a comma. The radius decides in which radius to check for the alive neighbourcells. Speed caps the fps of the form. Step makes the simulation take 1 step when it is paused.";
            string title = "Help";
            textBoxLeven.Focus();
            MessageBox.Show(message, title);
        }

        // Run wanneer text in leven textbox veranderd
        private void Leven_Textbox(object sender, EventArgs e)
        {
            try
            {
                leven = Array.ConvertAll(textBoxLeven.Text.Split(','), s => int.Parse(s));
            }
            catch (Exception)
            {
                string message = "Input is not correct!";
                string title = "Error";
                textBoxLeven.Focus();
                MessageBox.Show(message, title);
            }
        }

        // Run wanneer text in dood textbox veranderd
        private void BlijfLeven_Textbox(object sender, EventArgs e)
        {
            try
            {
                blijfleven = Array.ConvertAll(textBoxBlijfLeven.Text.Split(','), s => int.Parse(s));
            }
            catch (Exception)
            {
                string message = "Input is not correct!";
                string title = "Error";
                textBoxBlijfLeven.Focus();
                MessageBox.Show(message, title);
            }
        }

        // Run wanneer text in radius textbox veranderd
        private void Radius_Textbox(object sender, EventArgs e)
        {
            try
            {
                radius = int.Parse(textBoxRadius.Text);
            }
            catch (Exception)
            {
                string message = "Input is not correct!";
                string title = "Error";
                textBoxRadius.Focus();
                MessageBox.Show(message, title);
            }
        }

        // Run wanneer text in snelheid textbox veranderd
        private void Snelheid_Textbox(object sender, EventArgs e)
        {
            try
            {
                snelheid = int.Parse(textBoxSnelheid.Text);
                if (snelheid <= 0)
                {
                    string message = "Speed can't be 0 or lower!";
                    string title = "Error";
                    textBoxSnelheid.Focus();
                    MessageBox.Show(message, title);
                }
            }
            catch (Exception)
            {
                string message = "Input is not correct!";
                string title = "Error";
                textBoxSnelheid.Focus();
                MessageBox.Show(message, title);
            }
        }

        // Tekent lijnen op de panel
        private void Teken_Panel(object sender, PaintEventArgs e)
        {
            float vakGrootte = (float)panel.Width / (float)size + 0.5f;
            Graphics g = e.Graphics;
            
            Brush brush = Brushes.Black;

            // Teken opstelling
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[i, j])
                    {
                        Rectangle rectangle = new Rectangle((int)(i * vakGrootte), (int)(j * vakGrootte), (int)(vakGrootte + 0.5f), (int)(vakGrootte + 0.5f));
                        g.FillRectangle(brush, rectangle);
                    }
                }
            }

            if (lines_changed || lines)
            {
                // Teken rooster
                if (lines)
                {
                    Pen pen = new Pen(Color.Black, 2);

                    for (float i = 1; i < panel.Width; i += vakGrootte)
                    {
                        Point p1 = new Point((int)i, 0);
                        Point p2 = new Point((int)i, panel.Width);
                        g.DrawLine(pen, p1, p2);

                        Point p3 = new Point(0, (int)i);
                        Point p4 = new Point(panel.Width, (int)i);
                        g.DrawLine(pen, p3, p4);
                    }
                }
            }


            if (!pauze || step)
            {
                Thread.Sleep(1000 / snelheid);
                panel.Invalidate();
                
                if(!lines_changed || step) grid = Functionaliteit.Step(grid, leven, blijfleven, radius);
            }

            if (lines_changed) lines_changed = false;
            if (step) step = false;
        }

        private void Step_Click(object sender, EventArgs e)
        {
            if (pauze)
            {
                step = true;
                panel.Invalidate();
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YesButton.Checked)
            {
                lines = true;
                lines_changed = true;
                panel.Invalidate();
            }
        }

        private void NoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoButton.Checked)
            {
                lines = false;
                lines_changed = true;
                panel.Invalidate();
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (pauze)
            {
                float scale = (float)panel.Width / (float)size + 0.5f;

                float xcoord = e.X / scale;
                float ycoord = e.Y / scale;

                grid[(int)xcoord, (int)ycoord] = !grid[(int)xcoord, (int)ycoord];
                panel.Invalidate();
            }
        }

        private void TemplateSelector_ChoiceChanged(object sender, EventArgs e)
        {
            try
            {
                grid = BasePatterns.GetPattern(TemplateSelector.Text, size);
                panel.Invalidate();
            }
            catch (Exception)
            {
                MessageBox.Show("Selected pattern too large for selected grid size.");
            }
        }
    }
}
