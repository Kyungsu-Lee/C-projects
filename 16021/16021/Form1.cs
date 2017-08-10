using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace _16021
{
    public partial class Form1 : Form
    {
        static int start_height;


        public Form1()
        {
            InitializeComponent();

            start_height = this.Height;

            StartPosition = FormStartPosition.CenterScreen;

            RGB.hex = "#eeeeee";

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(RGB.R, RGB.G, RGB.B);
            tootip_close.SetToolTip(closeButton, "닫기");
            tootip_menu.SetToolTip(menuIcon, "메뉴");
            tooltip_minimize.SetToolTip(최소화, "최소화");


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RGB.hex = "#5D4037";
            TopLabel.BackColor = Color.FromArgb(RGB.R, RGB.G, RGB.B);
            TopLabel.Location = new Point(0, 0);
            TopLabel.Size = new Size(this.Width, 40);

            RGB.hex = "#795548";
            Header.BackColor = Color.FromArgb(RGB.R, RGB.G, RGB.B);
            Header.Location = new Point(0, TopLabel.Height);
            Header.Size = new Size(this.Width, this.Height / 8);

            closeButton.Load(_PATH.closeButton);
            closeButton.Size = new Size(16, 16);
            int _margin = (TopLabel.Height - closeButton.Height) / 2;
            closeButton.Location = new Point(this.Width - closeButton.Width - _margin, TopLabel.Height / 2 - closeButton.Height / 2);
            closeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            closeButton.BackColor = TopLabel.BackColor;

            menuIcon.Load(_PATH.menuButton);
            _margin = 10;
            menuIcon.Size = new Size(20, 20);
            menuIcon.Location = new Point(_margin, _margin);
            menuIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            menuIcon.BackColor = TopLabel.BackColor;

            최소화.Load(_PATH.최소화);
            최소화.Size = closeButton.Size;
            최소화.Location = new Point(this.Width - closeButton.Width - 5 * _margin / 2 - closeButton.Width, TopLabel.Height / 2 - closeButton.Height / 2);
            최소화.SizeMode = PictureBoxSizeMode.StretchImage;
            최소화.BackColor = TopLabel.BackColor;

            title.Load(_PATH.title);
            title.BackColor = Header.BackColor;
            title.SizeMode = PictureBoxSizeMode.StretchImage;
            title.Size = new Size((int)((float)this.Width / 3.0F), (int)((float)this.Width / (3.0F * 3.7F)));
            title.Location = new Point(Header.Width / 2 - title.Width / 2, Header.Location.Y + Header.Height / 2 - title.Height / 2 + title.Height / 10);
            // title.Location = new Point(Header.Width / 2 - title.Width / 2, _margin/5);
            //title.BackColor = TopLabel.BackColor;

            menuIcon.Load(_PATH.menuButton);
            _margin = 10;
            menuIcon.Size = new Size(20, 20);
            menuIcon.Location = new Point(_margin, _margin);
            menuIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            menuIcon.BackColor = TopLabel.BackColor;

            resultBox.Load(_PATH.resultBox);
            _margin = 10;
            resultBox.Size = new Size(this.Width - _margin, this.Height / 12);
            resultBox.Location = new Point(_margin / 2, Header.Location.Y + Header.Height + resultBox.Height / 2);
            resultBox.BackColor = Color.White;
            resultBox.SizeMode = PictureBoxSizeMode.StretchImage;

            resultText.Text = "0";
            resultText.Location = new Point(resultBox.Location.X + resultBox.Width - resultText.Width - _margin, resultBox.Location.Y + (resultBox.Height - resultText.Height) / 2);
            resultText.ForeColor = TopLabel.BackColor;
            hex_resultText.ForeColor = TopLabel.BackColor;

            Arrow.Load(_PATH.Arrow);
            _margin = resultBox.Height / 2;
            Arrow.Height = (int)(resultBox.Height * 1.3F);
            Arrow.SizeMode = PictureBoxSizeMode.StretchImage;
            Arrow.BackColor = this.BackColor;
            Arrow.Location = new Point(this.Width / 2 - Arrow.Width / 2, resultBox.Location.Y + resultBox.Height + _margin);

            hex_resultBox.Load(_PATH.resultBox);
            _margin = 10;
            hex_resultBox.Size = new Size(this.Width - _margin, this.Height / 12);
            hex_resultBox.Location = new Point(_margin / 2, Arrow.Location.Y + Arrow.Height + resultBox.Height / 2);
            hex_resultBox.BackColor = Color.White;
            hex_resultBox.SizeMode = PictureBoxSizeMode.StretchImage;

            hex_resultText.Text = "0";
            hex_resultText.Location = new Point(hex_resultBox.Location.X + hex_resultBox.Width - hex_resultText.Width - _margin, hex_resultBox.Location.Y + (hex_resultBox.Height - hex_resultText.Height) / 2);

            ch_dec.Load(_PATH.DEC);
            ch_hex.Load(_PATH.HEX);
            ch_dec.Size = new Size(this.Width / 3, this.Width / 6);
            ch_hex.Size = new Size(this.Width / 3, this.Width / 6);
            ch_hex.BackColor = this.BackColor;
            ch_dec.BackColor = this.BackColor;
            ch_dec.SizeMode = PictureBoxSizeMode.StretchImage;
            ch_hex.SizeMode = PictureBoxSizeMode.StretchImage;

            line.Size = new Size(ch_dec.Width, 3);
            line.BackColor = Header.BackColor;

            about_TopLabel();
            about_header();
            about_closeButton();
            about_menuIcon();
            about_최소화();
            about_resultBox();
            about_resultText();
            about_form();
            about_DEC();
            about_HEX();

            set_index();

            show_View_1();

            


        }

        private void about_form()
        {
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //resultText.Text += e.KeyCode.ToString(); //check keycode

            if (_switch.view == _switch.VIEW.VIEW3)
            {
                if (e.KeyCode == Keys.Right && _switch.viewside == _switch.VIEW_SIDE.LEFT)
                {
                    line.Location = new Point(ch_hex.Location.X, line.Location.Y);
                    _switch.viewside = _switch.VIEW_SIDE.RIGHT;
                }

                if (e.KeyCode == Keys.Left && _switch.viewside == _switch.VIEW_SIDE.RIGHT)
                {
                    line.Location = new Point(ch_dec.Location.X, line.Location.Y);
                    _switch.viewside = _switch.VIEW_SIDE.LEFT;
                }

                if (e.KeyCode == Keys.Enter && _switch.viewside == _switch.VIEW_SIDE.LEFT)
                    show_View_1();

                if (e.KeyCode == Keys.Enter && _switch.viewside == _switch.VIEW_SIDE.RIGHT)
                    show_View_2();
            }

            int _margin = 10;

            if (e.KeyCode == Keys.H)
                show_View_2();

            if (e.KeyCode == Keys.D  && !e.Shift)
                show_View_1();

            if (e.KeyCode == Keys.M)
                show_View_3();

            if (resultText.Text.Length == 32)
            {
                //resultText.Text = resultText.Text.Substring(1, 31);
                resultText.Text = "0";
                resultText.Location = new Point(resultBox.Location.X + resultBox.Width - resultText.Width - _margin, resultBox.Location.Y + (resultBox.Height - resultText.Height) / 2);

            }



            if (e.KeyCode == Keys.C && !e.Shift)
            {
                if (_switch.view == _switch.VIEW.VIEW1)
                    show_View_1();
                if (_switch.view == _switch.VIEW.VIEW2)
                    show_View_2();
                //resultText.Text = "0";
                //_switch.typeofstr = _switch.TYPE.NULL;
            }

            if (e.KeyCode == Keys.W)
                this.Close();

            if(e.KeyCode == Keys.Back)
            {
                if (resultText.Text.Length == 1)
                {
                    if (_switch.view == _switch.VIEW.VIEW1)
                        show_View_1();
                    if (_switch.view == _switch.VIEW.VIEW2)
                        show_View_2();
                }
                else
                {
                    if (_switch.typeofstr == _switch.TYPE.opertor)
                        _switch.inoperator = false;
                    if (resultText.Text[resultText.Text.Length - 1] == '(')
                        _switch.number_open--;
                    if (resultText.Text[resultText.Text.Length - 1] == ')')
                        _switch.number_open++;

                    resultText.Text = resultText.Text.Substring(0, resultText.Text.Length - 1);

                }
                _switch.typeofstr = _switch.b_typeofstr;

                
            }




            //case dec///
            if (_switch.view == _switch.VIEW.VIEW1)
            {
                if(e.Shift && _switch.typeofstr != _switch.TYPE.number && _switch.typeofstr != _switch.TYPE.dot && _switch.typeofstr != _switch.TYPE.brave)
                {
                    if(e.KeyCode == Keys.D9)
                    {
                        if(_switch.typeofstr == _switch.TYPE.NULL)
                        {
                            resultText.Text = "(";
                        }

                        else
                        {
                            resultText.Text += "(";
                        }

                        _switch.number_open++;
                        _switch.inoperator = false;
                        _switch.b_typeofstr = _switch.typeofstr;
                        _switch.typeofstr = _switch.TYPE.brave;
                    }
                }

                if (e.Shift && _switch.typeofstr != _switch.TYPE.dot && _switch.typeofstr != _switch.TYPE.brave && _switch.typeofstr != _switch.TYPE.opertor)
                {
                    if (e.KeyCode == Keys.D0 && _switch.number_open > 0 && _switch.inoperator)
                    {
                        resultText.Text += ")";
                        _switch.number_open--;
                        _switch.b_typeofstr = _switch.typeofstr;
                        _switch.typeofstr = _switch.TYPE.brave;
                    }
                }


                

                if (!e.Shift)
                {


                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                        case Keys.D2:
                        case Keys.D3:
                        case Keys.D4:
                        case Keys.D5:
                        case Keys.D6:
                        case Keys.D7:
                        case Keys.D8:
                        case Keys.D9:
                        case Keys.D0: if (resultText.Text == "0") resultText.Text = ""; _switch.b_typeofstr = _switch.typeofstr; _switch.typeofstr = _switch.TYPE.number; resultText.Text += e.KeyCode.ToString().Substring(1, 1); break;
                        case Keys.NumPad0:
                        case Keys.NumPad1:
                        case Keys.NumPad2:
                        case Keys.NumPad3:
                        case Keys.NumPad4:
                        case Keys.NumPad5:
                        case Keys.NumPad6:
                        case Keys.NumPad7:
                        case Keys.NumPad8:
                        case Keys.NumPad9: if (resultText.Text == "0") resultText.Text = ""; _switch.b_typeofstr = _switch.typeofstr; _switch.typeofstr = _switch.TYPE.number; resultText.Text += e.KeyCode.ToString().Substring(6, 1); break;
                        case Keys.OemPeriod:
                        case Keys.Decimal:
                            {

                                if (resultText.Text.IndexOf('.') < 0)
                                {
                                    if (resultText.Text == "") resultText.Text = "0";
                                    resultText.Text += ".";
                                    _switch.b_typeofstr = _switch.typeofstr;
                                    _switch.typeofstr = _switch.TYPE.dot;
                                }

                                break;
                            }
                    }
                }

                if (!e.Shift)
                {
                    if (_switch.typeofstr == _switch.TYPE.number || resultText.Text[resultText.Text.Length - 1] == ')')
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.Add: resultText.Text += "+"; break;
                            case Keys.Subtract: resultText.Text += "-"; break;
                            case Keys.Multiply: resultText.Text += "*"; break;
                            case Keys.Divide: resultText.Text += "/"; break;
                        }

                        _switch.b_typeofstr = _switch.typeofstr;
                        _switch.typeofstr = _switch.TYPE.opertor;
                        _switch.inoperator = true;
                    }
                }


            }


            ////////////////////////////// VIEW 2/////////////////////////
            else if(_switch.view == _switch.VIEW.VIEW2 && !_switch.entered)
            {
                if (resultText.Text.Length == 10)
                {
                    //resultText.Text = resultText.Text.Substring(1, 31);
                    resultText.Text = "0";
                    resultText.Location = new Point(resultBox.Location.X + resultBox.Width - resultText.Width - _margin, resultBox.Location.Y + (resultBox.Height - resultText.Height) / 2);

                }

                if (resultText.Text.Length == 7 && resultText.Text.Substring(0,1) == "#" && e.KeyCode != Keys.Enter)
                {
                    //resultText.Text = resultText.Text.Substring(1, 31);
                    resultText.Text = "0";
                    resultText.Location = new Point(resultBox.Location.X + resultBox.Width - resultText.Width - _margin, resultBox.Location.Y + (resultBox.Height - resultText.Height) / 2);

                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (resultText.Text.Substring(0, 1) == "#" && resultText.Text.Length == 7)
                    {
                        RGB.hex = resultText.Text;
                        hex_resultText.Text = "(" + RGB.R.ToString() + ", " + RGB.G.ToString() + ", " + RGB.B.ToString() + ")";
                        hex_resultText.Location = new Point(hex_resultBox.Location.X + hex_resultBox.Width - hex_resultText.Width - _margin, hex_resultBox.Location.Y + (hex_resultBox.Height - hex_resultText.Height) / 2);
                    }

                    else
                    {
                        hex_resultText.Text = Convert.ToString(int.Parse(resultText.Text), 16).ToUpper();
                        hex_resultText.Location = new Point(hex_resultBox.Location.X + hex_resultBox.Width - hex_resultText.Width - _margin, hex_resultBox.Location.Y + (hex_resultBox.Height - hex_resultText.Height) / 2);
                    }

                    _switch.entered = true;
                }

                if (!e.Shift)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                        case Keys.D2:
                        case Keys.D3:
                        case Keys.D4:
                        case Keys.D5:
                        case Keys.D6:
                        case Keys.D7:
                        case Keys.D8:
                        case Keys.D9:
                        case Keys.D0: if (resultText.Text == "0") resultText.Text = ""; resultText.Text += e.KeyCode.ToString().Substring(1, 1); break;
                        case Keys.NumPad0:
                        case Keys.NumPad1:
                        case Keys.NumPad2:
                        case Keys.NumPad3:
                        case Keys.NumPad4:
                        case Keys.NumPad5:
                        case Keys.NumPad6:
                        case Keys.NumPad7:
                        case Keys.NumPad8:
                        case Keys.NumPad9: if (resultText.Text == "0") resultText.Text = ""; resultText.Text += e.KeyCode.ToString().Substring(6, 1); break;
                        
                    }

                    
                }

                if(e.Shift && e.KeyCode == Keys.D3 && resultText.Text == "0")
                {
                    resultText.Text = "#";
                }

                if(e.Shift)
                {
                    if (resultText.Text.Substring(0, 1) == "#")
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.A:
                            case Keys.B:
                            case Keys.C:
                            case Keys.D:
                            case Keys.E:
                            case Keys.F: resultText.Text += e.KeyCode.ToString().Substring(0, 1); break;
                        }
                    }
                }

                
            }

            if(_switch.entered && e.KeyCode != Keys.Enter)
            {
                resultText.Text = "0";
                _switch.entered = !_switch.entered;
            }


            resultText.Location = new Point(resultBox.Location.X + resultBox.Width - resultText.Width - _margin, resultBox.Location.Y + (resultBox.Height - resultText.Height) / 2);
        }


        /// <summary>
        /// care component 
        /// </summary>
        /// 
        class RGB
        {
            static public int R { get; set; }
            static public int G { get; set; }
            static public int B { get; set; }

            static public string hex
            {
                set
                {

                    R = Convert.ToInt32(value.Substring(1, 2), 16);
                    G = Convert.ToInt32(value.Substring(3, 2), 16);
                    B = Convert.ToInt32(value.Substring(5, 2), 16);
                }
            }
        }

        class _point
        {
            static public int present_X;
            static public int present_Y;

            static public int X;  // to point
            static public int Y;  // to point
        }

        private class _switch
        {
            static public bool moveform = false;

            public enum TYPE
            {
                number, opertor, brave, dot, NULL
            }

            static public TYPE typeofstr = TYPE.NULL;
            static public TYPE b_typeofstr = TYPE.NULL;
            static public int number_open = 0;

            public enum VIEW { VIEW1, VIEW2, VIEW3 }

            static public VIEW view = VIEW.VIEW1;

            public enum VIEW_SIDE {  LEFT, RIGHT }
            static public VIEW_SIDE viewside;

            static public bool entered = false;

            static public bool inoperator = false;


        }

        private class _PATH
        {
            static public string closeButton = @"E:\pictogram\close_button_#ffffff.png";
            static public string menuButton = @"E:\pictogram\noun_335410_cc_#ffffff.png";
            static public string 최소화 = @"E:\pictogram\minimize_1.png";
            static public string title = @"E:\pictogram\About_cal.png";
            static public string resultBox = @"E:\pictogram\box_#5D4037_#eeeeee.png";
            static public string Arrow = @"E:\pictogram\arrow_#5D4037.png";
            static public string HEX = @"E:\pictogram\HEX.png";
            static public string DEC = @"E:\pictogram\DEC.png";
        }



        private void set_index()
        {
            TopLabel.TabIndex = 2;
            Header.TabIndex = 0;
            closeButton.TabIndex = 1;
            최소화.TabIndex = 1;
            menuIcon.TabIndex = 1;
            title.TabIndex = 1;

        }

        ////// TopLabel /////////
        void about_TopLabel()
        {
            TopLabel.MouseDown += TopLabel_MouseDown;
            TopLabel.MouseMove += TopLabel_MouseMove;
            TopLabel.MouseUp += TopLabel_MouseUp;
        }

        private void TopLabel_MouseUp(object sender, MouseEventArgs e)
        {
            _switch.moveform = false;
        }

        private void TopLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_switch.moveform)
            {
                _point.X = _point.present_X;
                _point.Y = _point.present_Y;

                _point.present_X = MousePosition.X;
                _point.present_Y = MousePosition.Y;

                _point.X -= _point.present_X;
                _point.Y -= _point.present_Y;

                this.Location = new Point(this.Location.X - _point.X, this.Location.Y - _point.Y);
            }
        }

        private void TopLabel_MouseDown(object sender, MouseEventArgs e)
        {
            _point.present_X = MousePosition.X;
            _point.present_Y = MousePosition.Y;
            _switch.moveform = true;
        }




        ////////////////////////



        ////// Header ///////////
        private void about_header()
        {

        }

        



        /////// close Button ///////////
        private void about_closeButton()
        {
            closeButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /////////// menu Icon ///////////
        private void about_menuIcon()
        {
            menuIcon.DoubleClick += MenuIcon_DoubleClick;
            menuIcon.Click += MenuIcon_Click;
        }

        private void MenuIcon_Click(object sender, EventArgs e)
        {
            if (_switch.view != _switch.VIEW.VIEW3)
                show_View_3();

            else if (this.Height < 400)
                show_View_1();
            else
                show_View_2();
        }

        private void MenuIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }


        /////////// 최소화 /////////////////
        private void about_최소화()
        {
            최소화.Click += 최소화_Click;
        }

        private void 최소화_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /////////// result Box //////////////
        private void about_resultBox()
        {

        }



        ////////////// result text ///////////
        private void about_resultText()
        {
            resultText.TextChanged += ResultText_TextChanged;
        }

        private void ResultText_TextChanged(object sender, EventArgs e)
        {
            int _margin = 10;

            hex_resultText.Text = "0";
            hex_resultText.Location = new Point(hex_resultBox.Location.X + hex_resultBox.Width - hex_resultText.Width - _margin, hex_resultBox.Location.Y + (hex_resultBox.Height - hex_resultText.Height) / 2);
        }


        /// <summary>
        /// about HEX DEC
        /// </summary>


        private void about_HEX()
        {
            ch_hex.Click += Ch_hex_Click;
            ch_hex.MouseDown += Ch_hex_MouseDown;
        }

        private void Ch_hex_MouseDown(object sender, MouseEventArgs e)
        {
            line.Location = new Point(ch_hex.Location.X, line.Location.Y);
            _switch.viewside = _switch.VIEW_SIDE.RIGHT;

        }

        private void Ch_hex_Click(object sender, EventArgs e)
        {
            
            show_View_2();
        }

        private void about_DEC()
        {
            ch_dec.Click += Ch_dec_Click;
            ch_dec.MouseDown += Ch_dec_MouseDown;
        }

        private void Ch_dec_MouseDown(object sender, MouseEventArgs e)
        {
            line.Location = new Point(ch_dec.Location.X, line.Location.Y);
            _switch.viewside = _switch.VIEW_SIDE.LEFT;
        }

        private void Ch_dec_Click(object sender, EventArgs e)
        {
            show_View_1();
        }


        ////////////// about View //////////////
        private void show_View_1()
        {
            _switch.view = _switch.VIEW.VIEW1;

            this.Height = 250;
            Arrow.Hide();
            hex_resultBox.Hide();
            hex_resultText.Hide();
            blackscreen.Hide();

            ch_hex.Hide();
            ch_dec.Hide();
            line.Hide();

            resultText.Text = "0";
            _switch.typeofstr = _switch.TYPE.NULL;
            _switch.b_typeofstr = _switch.TYPE.NULL;
            _switch.number_open = 0;
            _switch.inoperator = false;
            _switch.view = _switch.VIEW.VIEW1;
            _switch.entered = false;
        }

        private void show_View_2()
        {
            _switch.view = _switch.VIEW.VIEW2;

            this.Height = 430;
            Arrow.Show();
            hex_resultBox.Show();
            hex_resultText.Show();
            blackscreen.Hide();

            ch_hex.Hide();
            ch_dec.Hide();
            line.Hide();

            resultText.Text = "0";
            _switch.typeofstr = _switch.TYPE.NULL;
        }

        private void show_View_3()
        {
            _switch.view = _switch.VIEW.VIEW3;
            _switch.viewside = _switch.VIEW_SIDE.LEFT;

            blackscreen.Size = new Size(this.Width, this.Height - TopLabel.Height);
            //blackscreen.Image = pic;
            //blackscreen.SizeMode = PictureBoxSizeMode.StretchImage;
            //blackscreen.BackColor = Color.Transparent;
            blackscreen.BackColor = this.BackColor;
            blackscreen.Location = new Point(0, TopLabel.Height);

            ch_dec.Location = new Point(this.Width / 7, blackscreen.Location.Y + blackscreen.Height / 2 - ch_dec.Height / 2);
            ch_hex.Location = new Point(this.Width *3 / 5, blackscreen.Location.Y + blackscreen.Height / 2 - ch_hex.Height / 2);

            line.Location = new Point(ch_dec.Location.X, ch_dec.Location.Y + ch_dec.Height + 3);

            ch_dec.Show();
            ch_hex.Show();
            blackscreen.Show();
            line.Show();


        }

    }

  
}
