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
    public partial class Sizeprompt : Form
    {
        public static int size = 0;
        public static string template = "Empty";
        public static bool[,] grid;
        public Sizeprompt()
        {
            InitializeComponent();
        }

        private void Get_Size()
        {
            try
            {
                size = int.Parse(textBox1.Text);
                if (size <= 0) throw new Exception();
                try
                {
                    grid = BasePatterns.GetPattern(TemplateSelector.Text, size);
                    this.Hide();
                    Window gameOfLife = new Window();
                    gameOfLife.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selected pattern too large for selected grid size!", "Error");
                }

            }
            catch (Exception)
            {
                string message = "Size is not valid!";
                string title = "Error";
                textBox1.Focus();
                MessageBox.Show(message, title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Get_Size();
        }
    }
}
