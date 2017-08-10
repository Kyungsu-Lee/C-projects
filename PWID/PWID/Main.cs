using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWID
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        public Main(Form1 form1)
        {
            _component.open.Add(form1);

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.FormClosing += Main_FormClosing;

            this.Width = _component.open[0].Width;
            this.Height = _component.open[0].Height * 3;


            this.Load += Main_Load;
            this.KeyDown += Main_KeyDown;
            this.MouseClick += Main_MouseClick;
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (false)
            //    for (int i = 1; i < _component.open.Count; i++)
            //        _component.open[i].Close();
            //else
                for (int i = 0; i < _component.open.Count; i++)
                    _component.open[i].Close();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                this.Close();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            addBox();
            about_TopLabel();
            about_btn_close();
            about_menu();
            about_minimize();
            about_searchBox();
        }

        /// <summary>
        /// ADD PICTUREBOX
        /// </summary>
        /// 

        private void addBox()
        {
            Controls.Add(searchBox);
            Controls.Add(btn_minimize);
            Controls.Add(Mark);
            this.Controls.Add(btn_close);
            this.Controls.Add(TopLabel);
        }


        ////////////////// TopLabel //////////////

        PictureBox TopLabel = new PictureBox();

        private void about_TopLabel()
        {
            TopLabel.Width = this.Width;
            TopLabel.Height = _component.open[0].TopLabel.Height;
            TopLabel.BackColor = _component.open[0].TopLabel.BackColor;
            TopLabel.Location = new Point(0, 0);


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
            if (_switch.this_move)
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

        //////////// Close Button /////////////

        PictureBox btn_close = new PictureBox();

        private void about_btn_close()
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

        ///////////// Menu //////////////

        PictureBox Mark = new PictureBox();

        private void about_menu()
        {
            int margin = 11;
            Mark.Load(@"image\menu.png");
            Mark.SizeMode = PictureBoxSizeMode.StretchImage;
            Mark.Height = TopLabel.Height - 2 * margin;
            Mark.Width = Mark.Height;
            Mark.Location = new Point(margin, margin);
            Mark.BackColor = TopLabel.BackColor;
            Mark.MouseDoubleClick += Mark_MouseDoubleClick;
            Mark.MouseClick += Mark_MouseClick;

            ToolTip tool = new ToolTip();
            tool.SetToolTip(Mark, "메뉴");
        }

        private void Mark_MouseClick(object sender, MouseEventArgs e)
        {
            //Form1 form = new Form1(this);
            //_component.open.Add(form);
            //form.Show();
            //this.Hide();
        }

        public void Mark_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        

        ///////////////// minimize /////////////////////////
        PictureBox btn_minimize = new PictureBox();

        private void about_minimize()
        {
            int margin = 11;
            btn_minimize.Height = TopLabel.Height - 2 * margin;
            btn_minimize.Width = btn_minimize.Height;
            btn_minimize.BackColor = TopLabel.BackColor;
            btn_minimize.Load(@"image\btn_minimize.png");
            btn_minimize.Location = new Point(btn_close.Location.X - btn_minimize.Width - margin * 2 / 2, margin);
            btn_minimize.SizeMode = PictureBoxSizeMode.StretchImage;

            ToolTip tool = new ToolTip();
            tool.SetToolTip(btn_minimize, "최소화");
            btn_minimize.MouseClick += Btn_minimize_MouseClick;
        }

        private void Btn_minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /////////////// Search Box //////////////////

        TextBox searchBox = new TextBox();
        private void about_searchBox()
        {
            int margin = 10;
            searchBox.Width = this.Width - 2 * margin;
            searchBox.Height = TopLabel.Height;
            searchBox.Location = new Point(margin, TopLabel.Height +  margin*3/2);
            //searchBox.TextAlign = HorizontalAlignment.Center;
            
        }

        ////////////////

    }

    
}
