using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160201
{
    

    public partial class Form1 : Form
    {
        static public int NUM_TIMER = 0;

        int presnet_width;
        int present_height;

        int present_mouse_X;
        int present_mouse_Y;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            FormBorderStyle = FormBorderStyle.None;

            this.Click += Form1_Click;

            label1.BackColor = pictureBox2.BackColor;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            present_height = this.Height;
            presnet_width = this.Width;

            this.LocationChanged += Form1_LocationChanged;

            label1.Location = new System.Drawing.Point(this.Width/2 - label1.Width/2, label1.Location.Y);

            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Width = this.Width;

            pictureBox1.Height = this.Height - pictureBox2.Height;
            pictureBox1.Location = new System.Drawing.Point(0, pictureBox2.Height);

            icon_close.Width = 20;
            icon_close.Height = 20;
            int margin = 6;
            icon_close.Location = new Point(this.Width - icon_close.Width - margin, margin);
            icon_close.Load(care_files.Image_Path3);
            icon_close.SizeMode = PictureBoxSizeMode.Zoom;
            icon_close.BackColor = pictureBox2.BackColor;

            about_pictureBox1();
            about_pictureBox2();
            about_label1();
            about_close_icon();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            care_switch.switch_what = false;
        }




        /// <summary>
        /// care about
        /// </summary>
        class care_files
        {
            static public string Image_Path = @"E:\pictogram\Label_1.png";
            static public string Image_Path2 = @"E:\pictogram\computer_1.png";
            static public string Image_Path3 = @"E:\pictogram\incorrect_1_#ffffff.png";
        }

        class care_switch
        {
            static public bool switch_image = true;
            static public bool switch_move = false;
            static public bool switch_what = true;
        }

        static class hex_rgb
        {
            static public int R { get; set; }
            static public int G { get; set; }
            static public int B { get; set; }
            static public string hex
            {
                set
                {
                    R = Convert.ToInt32(value.Substring(0, 2), 16);
                    G = Convert.ToInt32(value.Substring(2, 2), 16);
                    B = Convert.ToInt32(value.Substring(4, 2), 16);
                }
            }


        }

        class _timer
        {
            static public int time;
        }

        ////// about care_end //////


        /// <summary>
        /// pictureBox
        /// </summary>
        private void about_pictureBox1()
        {
            //pictureBox1.MouseHover += PictureBox1_MouseHover;

            pictureBox1.Load(care_files.Image_Path2);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            if (care_switch.switch_image)
            {
                pictureBox1.Load(care_files.Image_Path2);
                care_switch.switch_image = false;
            }

            else
            {

                pictureBox1.Load(care_files.Image_Path);
                care_switch.switch_image = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.pictureBox1.DoubleClick += PictureBox1_DoubleClick;
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        ////// pictureBox1_end //////


        //////pictureBox2 /////////

        private void about_pictureBox2()
        {
            pictureBox2.MouseDown += PictureBox2_MouseDown;
            pictureBox2.MouseUp += PictureBox2_MouseUp;
            pictureBox2.MouseMove += PictureBox2_MouseMove;
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (care_switch.switch_move)
            {
                int x = present_mouse_X;
                int y = present_mouse_Y;

                present_mouse_X = MousePosition.X;
                present_mouse_Y = MousePosition.Y;

                x -= present_mouse_X;
                y -= present_mouse_Y;

                this.Location = new System.Drawing.Point(this.Location.X - x, this.Location.Y - y);
            }
        }

        private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            care_switch.switch_move = false;
            care_switch.switch_what = true;
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            present_mouse_X = MousePosition.X;
            present_mouse_Y = MousePosition.Y;

            care_switch.switch_move = true;
        }
        

        ////// Label 1//////

        private void about_label1()
        {
            label1.MouseDown += Label1_MouseDown;
            label1.MouseUp += Label1_MouseUp;
            label1.MouseMove += Label1_MouseMove;
            label1.MouseClick += Label1_MouseClick;
        }

        private void Label1_MouseClick(object sender, MouseEventArgs e)
        {

            if (care_switch.switch_what)
            {
                if (care_switch.switch_image)
                {
                    hex_rgb.hex = "FFC107";
                    pictureBox2.BackColor = Color.FromArgb(hex_rgb.R, hex_rgb.G, hex_rgb.B);
                    label1.BackColor = pictureBox2.BackColor;
                    icon_close.BackColor = pictureBox2.BackColor;
                }

                else
                {
                    hex_rgb.hex = "F44336";
                    pictureBox2.BackColor = Color.FromArgb(hex_rgb.R, hex_rgb.G, hex_rgb.B);
                    label1.BackColor = pictureBox2.BackColor;
                    icon_close.BackColor = pictureBox2.BackColor;
                    this.BackColor = Color.FromArgb(255, 255, 255);
                }

                care_switch.switch_image = !(care_switch.switch_image);

                care_switch.switch_what = !care_switch.switch_what;
            }

            care_switch.switch_what = !care_switch.switch_what;
        }
        

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (care_switch.switch_move)
            {
                int x = present_mouse_X;
                int y = present_mouse_Y;

                present_mouse_X = MousePosition.X;
                present_mouse_Y = MousePosition.Y;

                x -= present_mouse_X;
                y -= present_mouse_Y;

                this.Location = new System.Drawing.Point(this.Location.X - x, this.Location.Y - y);
            }
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            care_switch.switch_move = false;
            care_switch.switch_what = true;
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            present_mouse_X = MousePosition.X;
            present_mouse_Y = MousePosition.Y;

            care_switch.switch_move = true;
        }

        ///////close_icon ////////
        private void about_close_icon()
        {
            icon_close.Click += Icon_close_Click;
        }

        private void Icon_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timer.time++;

            if(_timer.time % 2 == 0)
            {
                hex_rgb.hex = "FFC107";
                pictureBox2.BackColor = Color.FromArgb(hex_rgb.R, hex_rgb.G, hex_rgb.B);
                label1.BackColor = pictureBox2.BackColor;
                icon_close.BackColor = pictureBox2.BackColor;
            }

            else
            {
                hex_rgb.hex = "F44336";
                pictureBox2.BackColor = Color.FromArgb(hex_rgb.R, hex_rgb.G, hex_rgb.B);
                label1.BackColor = pictureBox2.BackColor;
                icon_close.BackColor = pictureBox2.BackColor;
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
