using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;

            button1.KeyDown += Button1_KeyDown;

            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                y--;

                button1.Location = new System.Drawing.Point(x, y);
            }

            if (e.KeyCode == Keys.Down)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                y++;

                button1.Location = new System.Drawing.Point(x, y);
            }

            if (e.KeyCode == Keys.Left)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                x--;

                button1.Location = new System.Drawing.Point(x, y);
            }

            if (e.KeyCode == Keys.Right)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                x++;

                button1.Location = new System.Drawing.Point(x, y);
            }
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                y--;

                button1.Location = new System.Drawing.Point(x, y);
            }

            if (e.KeyCode == Keys.Down)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                y++;

                button1.Location = new System.Drawing.Point(x, y);
            }

            if (e.KeyCode == Keys.Left)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                x--;

                button1.Location = new System.Drawing.Point(x, y);
            }

            if (e.KeyCode == Keys.Right)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                y++;

                button1.Location = new System.Drawing.Point(x, y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int x = button1.Location.X;
                int y = button1.Location.Y;

                y--;

                button1.Location = new System.Drawing.Point(x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = button1.Location.X;
            int y = button1.Location.Y;

            y--;

            button1.Location = new System.Drawing.Point(x, y);

            this.Select();
        }
    }
}
