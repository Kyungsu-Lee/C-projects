using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160130
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //MDI

            IsMdiContainer = false;

            //

            InitializeComponent();

            myLabel.Text = "";
            btn.Text = "입력";


            btn_allocated.Click += Btn_allocated_Click;

            btn_allocated.Size = new System.Drawing.Size(90, 30);
            btn_allocated.Location = new System.Drawing.Point(215, 70);
            btn_allocated.TabIndex = 0;
            btn_allocated.Text = "hi";

            Controls.Add(btn_allocated);

            Process.Style = ProgressBarStyle.Marquee;

            SaveFileDialog dial = new SaveFileDialog();
            dial.ShowDialog();
            MessageBox.Show(dial.FileName);
        }

        class A
        {
            static private int n = 100;

            static public int N
            {
                get
                {
                    return n;
                }

                set
                {
                    if (!(value > 300 || value < 0))
                        n = value;
                }
            }
        }

        private void Btn_allocated_Click(object sender, EventArgs e)
        {
            btn_allocated.Location = new System.Drawing.Point(215, A.N++);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_numbers(myTB.Text))
                A.N = int.Parse(myTB.Text);

            btn_allocated.Location = new System.Drawing.Point(215, A.N);
        }

        public bool check_numbers(string str)
        {
            bool r_value = true;

            for(int i=0; i<str.Length; i++)
            {
                if (str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' && str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' && str[i] != '8' && str[i] != '9')
                    r_value = false;
            }

            return r_value;
        }


        public Button btn_allocated = new Button();

        int time = 0;
        

        //set menu bar

        public float myLabel_font_size = 12F;
       
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            myLabel.Font = new System.Drawing.Font("나눔고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

            myLabel_font_size = 10F;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            myLabel.Font = new System.Drawing.Font("나눔고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

            myLabel_font_size = 20F;
        }

        private void 증가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myLabel_font_size++;

            myLabel.Font = new System.Drawing.Font("나눔고딕", myLabel_font_size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        }

        private void 감소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myLabel_font_size--;

            myLabel.Font = new System.Drawing.Font("나눔고딕", myLabel_font_size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("처음부터 다시 하겠습니까?","다시 시작", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                time = 0;
        }

        private void 새창ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void process_timer_Tick(object sender, EventArgs e)
        {

            Process.Value++;

            if (Process.Value > 99)
                Process.Value = 0;

            myLabel.Text = Process.Value + "%";
        }

        private void Process_Click(object sender, EventArgs e)
        {

        }
        
    }
}
