using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PWID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;

            StreamReader st = File.OpenText("a.txt");

            _component.password = st.ReadLine();

            st.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                for (int i = 0; i < _component.main.Count; i++)
                    _component.main[i].Close();
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(_component.PWD == _component.password)
                {
                    this.Hide();
                    this.btn_close.Dispose();
                    this.btn_minimize.Dispose();
                    this.Mark.Dispose();

                    Main m = new Main(this);
                    m.Show();
                }

                else
                {
                    PWD_Text.Text = "";
                    _component.PWD = "";
                }
            }

            else if (PWD_Text.Text.Length == 15)
            {

            }

            else if (e.KeyCode != Keys.Back && PWD_Text.Text.Length < 16)
            {
                 PWD_Text.Text += "*";
                switch(e.KeyCode)
                {
                    case Keys.D0: _component.PWD += "0"; break;
                    case Keys.D1: _component.PWD += "1"; break;
                    case Keys.D2: _component.PWD += "2"; break;
                    case Keys.D3: _component.PWD += "3"; break;
                    case Keys.D4: _component.PWD += "4"; break;
                    case Keys.D5: _component.PWD += "5"; break;
                    case Keys.D6: _component.PWD += "6"; break;
                    case Keys.D7: _component.PWD += "7"; break;
                    case Keys.D8: _component.PWD += "8"; break;
                    case Keys.D9: _component.PWD += "9"; break;
                    case Keys.Q: _component.PWD += "q"; break;
                    case Keys.W: _component.PWD += "w"; break;
                    case Keys.E: _component.PWD += "e"; break;
                    case Keys.R: _component.PWD += "r"; break;
                    case Keys.T: _component.PWD += "t"; break;
                    case Keys.Y: _component.PWD += "y"; break;
                    case Keys.U: _component.PWD += "u"; break;
                    case Keys.I: _component.PWD += "i"; break;
                    case Keys.O: _component.PWD += "o"; break;
                    case Keys.P: _component.PWD += "p"; break;
                    case Keys.A: _component.PWD += "a"; break;
                    case Keys.S: _component.PWD += "s"; break;
                    case Keys.D: _component.PWD += "d"; break;
                    case Keys.F: _component.PWD += "f"; break;
                    case Keys.G: _component.PWD += "g"; break;
                    case Keys.H: _component.PWD += "h"; break;
                    case Keys.J: _component.PWD += "j"; break;
                    case Keys.K: _component.PWD += "k"; break;
                    case Keys.L: _component.PWD += "l"; break;
                    case Keys.Z: _component.PWD += "z"; break;
                    case Keys.X: _component.PWD += "x"; break;
                    case Keys.C: _component.PWD += "c"; break;
                    case Keys.V: _component.PWD += "v"; break;
                    case Keys.B: _component.PWD += "b"; break;
                    case Keys.N: _component.PWD += "n"; break;
                    case Keys.M: _component.PWD += "m"; break;
                }
            }

            else if (PWD_Text.Text.Length > 0)
            {
                PWD_Text.Text = PWD_Text.Text.Substring(0, PWD_Text.Text.Length - 1);
                _component.PWD = _component.PWD.Substring(0, _component.PWD.Length - 1);
            }

            PWD_Text.Location = new Point(PWD.Location.X + PWD.Width / 2 - PWD_Text.Width / 2, PWD.Location.Y + 5);
        }
    

        public void Form1_Load(object sender, EventArgs e)
        {
            _component.mouse_present = Cursor.Position;

            about_TopLabel();
            about_Body();
            about_Mark();
            about_btn_close();
            about_btn_minimize();
            about_PWD();

            toolTip_Mark.SetToolTip(Mark,"메뉴");
        
        }
        



        /// <summary>
        ///  TopLabel
        /// </summary>
        public void about_TopLabel()
        {
            TopLabel.Location = new Point(0, 0);
            TopLabel.Height = (int)(this.Height / 4.5);
            TopLabel.Width = this.Width;
            TopLabel.BackColor = Color.FromArgb(48,63,159);

            TopLabel.MouseDown += TopLabel_MouseDown;
            TopLabel.MouseMove += TopLabel_MouseMove;
            TopLabel.MouseUp += TopLabel_MouseUp;
        }

        public void TopLabel_MouseUp(object sender, MouseEventArgs e)
        {
            _switch.this_move = false;
        }

        public void TopLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if(_switch.this_move)
            {
                System.Drawing.Point P = _component.mouse_present;
                _component.mouse_present = MousePosition;

                P = new Point(_component.mouse_present.X - P.X, _component.mouse_present.Y - P.Y);

                this.Location = new Point(this.Location.X + P.X, this.Location.Y + P.Y);

            }
        }

        public void TopLabel_MouseDown(object sender, MouseEventArgs e)
        {
            _switch.this_move = true;
            _component.mouse_present = MousePosition;
        }

        ////////////

            /// <summary>
            /// Body
            /// </summary>
        public void about_Body()
        {
            Body.Location = new Point(0, TopLabel.Height);
            Body.Width = this.Width;
            Body.Height = this.Height - TopLabel.Height;
            Body.BackColor = Color.FromArgb(63, 81, 181);
        }


        public void about_Mark()
        {
            int margin = 11;
            Mark.Load(@"image\menu.png");
            Mark.SizeMode = PictureBoxSizeMode.StretchImage;
            Mark.Height = TopLabel.Height - 2 * margin;
            Mark.Width = Mark.Height;
            Mark.Location = new Point(margin, margin);
            Mark.BackColor = TopLabel.BackColor;
            Mark.MouseDoubleClick += Mark_MouseDoubleClick;
        }

        public void Mark_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        /////////////


        /// <summary>
        /// close Button
        /// </summary>
        public void about_btn_close()
        {
            int margin = 11;
            btn_close.Height = TopLabel.Height - 2 * margin;
            btn_close.Width = btn_close.Height;
            btn_close.Location = new Point(this.Width - btn_close.Width - margin, margin);
            btn_close.Load(@"image\btn_close.png");
            btn_close.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_close.BackColor = TopLabel.BackColor;

            btn_close.MouseClick += Btn_close_MouseClick;

            ToolTip tool = new ToolTip();
            tool.SetToolTip(btn_close, "닫기");
        }

        public void Btn_close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        //////////////////////////////


        public void about_btn_minimize()
        {
            int margin = 11;
            btn_minimize.Height = TopLabel.Height - 2 * margin;
            btn_minimize.Width = btn_minimize.Height;
            btn_minimize.BackColor = TopLabel.BackColor;
            btn_minimize.Load(@"image\btn_minimize.png");
            btn_minimize.Location = new Point(btn_close.Location.X - btn_minimize.Width - margin*2/2, margin);
            btn_minimize.SizeMode = PictureBoxSizeMode.StretchImage;

            ToolTip tool = new ToolTip();
            tool.SetToolTip(btn_minimize, "최소화");

            btn_minimize.MouseClick += Btn_minimize_MouseClick;
        }

        private void Btn_minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /////////////////////////////////////

        public void about_PWD()
        {
            PWD.Width = this.Width * 7 / 8;
            int margin = (this.Width - PWD.Width) / 2;
            PWD.Location = new Point(margin, TopLabel.Height + (this.Height - TopLabel.Height) / 3);
            PWD.BackColor = Body.BackColor;
            PWD.Height = (this.Height - TopLabel.Height) / 3;

            PWD_Text.BackColor = PWD.BackColor;
            PWD_Text.Text = "";
            PWD_Text.Location = new Point(PWD.Location.X + PWD.Width/2 - PWD_Text.Width/2, PWD.Location.Y + 5);
            PWD_Text.ForeColor = Color.White;
        }


        ///////////////////////////////////
        ///////////////////////////////////
        
        public Form1(Main main_form)
        {
            _component.main.Add(main_form);

            InitializeComponent();
            

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;

            _component.mouse_present = Cursor.Position;

            about_TopLabel();
            about_Body();
            about_Mark();
            about_btn_close();
            about_btn_minimize();
            about_PWD();

            toolTip_Mark.SetToolTip(Mark, "메뉴");
            
        }
    }
}
