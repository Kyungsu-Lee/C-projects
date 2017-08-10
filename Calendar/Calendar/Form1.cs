using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.KeyDown += TextBox1_KeyDown;
            this.KeyDown += Form1_KeyDown;
            this.DragDrop += Form1_DragDrop;

           // MyWebView.Url = new Uri("http://www.naver.com");

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                this.Close();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            this.Close();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();

            if (e.KeyCode == Keys.Up)
                this.Close();
        }
        

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox1.Text.Substring(0,7) != "http://")
                MyWebView.Navigate(new Uri("http://"+textBox1.Text));

            else
                MyWebView.Navigate(new Uri(textBox1.Text));
        }

        private void MyWebView_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = MyWebView.Url.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = MyWebView.DocumentText;
        }
    }
}
