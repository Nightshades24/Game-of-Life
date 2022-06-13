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
                this.Hide();
                Window gameOfLife = new Window();
                gameOfLife.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {
                string message = "Input is not correct!";
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
