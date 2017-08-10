using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1602001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;

            toolTip1.SetToolTip(closeButton, "닫기");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            closeButton.Load(care_path.path_close);
            closeButton.Width = closeButton.Height = 20;
            int margin_closeButton = 15;
            closeButton.Location = new System.Drawing.Point(this.Width - closeButton.Width - margin_closeButton, margin_closeButton);
            closeButton.BackColor = this.BackColor;
            closeButton.SizeMode = PictureBoxSizeMode.StretchImage;

            

            about_close_button();
        }

        ////////care component/////////
        static class RGB
        {
            static public int R { get; set; }
            static public int G { get; set; }
            static public int B { get; set; }

            static public string hex
            {
                set
                {
                    hex = value;

                    R = Convert.ToInt32(value.Substring(0, 2), 16);
                    G = Convert.ToInt32(value.Substring(2, 2), 16);
                    B = Convert.ToInt32(value.Substring(4, 2), 16);
                }
            }
        }

        class care_path
        {
            static public string path_close = @"E:\pictogram\close_button.png";
        }




        /////////about close button////////////
        private void about_close_button()
        {
            closeButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



   
}
