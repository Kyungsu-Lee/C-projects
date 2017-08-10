using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lots
{
    public partial class Form1 : Form
    {
        static public int mouse_x;
        static public int mouse_y;

        static public bool check_move = false;

        person[] mem = new person[32];


        person[][] mem_list = new person[2][];

        static public string NONE = "";


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Width = this.Width / 2;
            this.Height = this.Height * 2 / 3;

            show_border();


            mem_list[0] = new person[16];   //male
            mem_list[1] = new person[16];   //female

            
        }

        public void show_border()
        {
            int Lborder = 3;
            Color Cborder = Color.FromArgb(0, 122, 204);

            PictureBox UL = new PictureBox();
            UL.Location = new Point(0, 0);
            UL.Width = this.Width;
            UL.Height = Lborder;
            UL.BackColor = Cborder;
            this.Controls.Add(UL);

            PictureBox LL = new PictureBox();
            LL.Location = new Point(0, 0);
            LL.Height = this.Height;
            LL.Width = Lborder;
            LL.BackColor = Cborder;
            this.Controls.Add(LL);

            PictureBox RL = new PictureBox();
            RL.Location = new Point(this.Width - Lborder, 0);
            RL.Height = this.Height;
            RL.Width = Lborder;
            RL.BackColor = Cborder;
            this.Controls.Add(RL);

            PictureBox DL = new PictureBox();
            DL.Location = new Point(0, this.Height - Lborder);
            DL.Width = this.Width;
            DL.Height = Lborder;
            DL.BackColor = Cborder;
            this.Controls.Add(DL);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyUp += Form1_KeyUp;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            initializemember();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            check_move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(check_move)
            {
                int x = mouse_x;
                int y = mouse_y;

                mouse_x = MousePosition.X;
                mouse_y = MousePosition.Y;

                this.Location = new Point(this.Location.X - x + mouse_x, this.Location.Y - y + mouse_y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            check_move = true;

            mouse_x = MousePosition.X;
            mouse_y = MousePosition.Y;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                this.Close();
            else if (e.KeyCode == Keys.S)
            {
                
                this.Controls.Clear();
                initializemember();
                //show_mem();
                ////result_norestrict();
                result_nooverap();
                show_border();




            }
        }
    }

    public partial class Form1 : Form
    {
        public void initializemember()
        {
            mem[0] = new person("강내은", 14, 22, person.sex.female);
            mem[1] = new person("강주헌", 12, 24, person.sex.male);
            mem[2] = new person("김동규", 16, 20, person.sex.male);
            mem[3] = new person("김시온", 15, 21, person.sex.male );
            mem[4] = new person("김예은", 15, 21, person.sex.female);
            mem[5] = new person("김진향", 14, 22, person.sex.female);
            mem[6] = new person("나지혜", 16, 22, person.sex.female);
            mem[7] = new person("남은택", 16, 20, person.sex.male);
            mem[8] = new person("노민영", 15, 21, person.sex.female);
            mem[9] = new person("박상호", 14, 22, person.sex.male);
            mem[10] = new person("송영한", 16, 20, person.sex.male);
            mem[11] = new person("송원경", 16, 20, person.sex.female);
            mem[12] = new person("안정호", 10, 26, person.sex.male);
            mem[13] = new person("오영은", 14, 22, person.sex.female);
            mem[14] = new person("이경수", 14, 23, person.sex.male);
            mem[15] = new person("이다은", 14, 22, person.sex.female);
            mem[16] = new person("이민규", 12, 29, person.sex.male);
            mem[17] = new person("이요셉", 12, 24, person.sex.male);
            mem[18] = new person("이윤희", 14, 23, person.sex.female);
            mem[19] = new person("이은혜", 13, 23, person.sex.female);
            mem[20] = new person("이주안", 15, 21, person.sex.male);
            mem[21] = new person("이혜원", 14, 22, person.sex.female);
            mem[22] = new person("이홍주", 16, 20, person.sex.female);
            mem[23] = new person("전영우", 16, 20, person.sex.male);
            mem[24] = new person("전찬영", 12, 24, person.sex.male);
            mem[25] = new person("정성욱", 10, 26, person.sex.male);
            mem[26] = new person("최윤정", 11, 25, person.sex.female);
            mem[27] = new person("최주연", 15, 21, person.sex.female);
            mem[28] = new person("최희락",14 , 23, person.sex.female);
            mem[29] = new person("현동우", 15, 21, person.sex.male);
            mem[30] = new person("홍은아", 16, 20, person.sex.female);
            mem[31] = new person("황겨레", 16, 20, person.sex.male);

            for(int i=0; i<32; i++)
            {
                if (mem[i].id == 16)
                    mem[i].traits = "새내기";

                else if (mem[i].name == "이경수" || mem[i].name == "이다은")
                    mem[i].traits = "새섬";
            }

            List<int> numlist = new List<int>();
            for (int i = 0; i < 32; i++)
                numlist.Add(i);
            
            for (int i = 31; i > -1; i--)
            {
                Random rd = new Random();

                int n = rd.Next(0, 100);
                int m = rd.Next(200, 300);
                
                n = (n + m) % (1+i);

                mem[i].number = numlist[n];
                
                numlist.RemoveAt(n);
            }

            for (int i=0; i < 31; i++)
            {
                Random rd = new Random();

                int n = rd.Next() % 32;

                int temp = mem[i].number;
                mem[i].number = mem[n].number;
                mem[i].number = temp;
            }

            set_none("이민규", "김진향");
            set_none("안정호", "이혜원");
            set_none("김동규", "이은혜");
            set_none("전영우", "홍은아");
            set_none("송영한", "최윤정");
            set_none("박상호", "김예은");
            set_none("이요셉", "송원경");
            set_none("강주헌", "나지혜");
            set_none("현동우", "이홍주");
            set_none("김시온", "최희락");
            set_none("정성욱", "노민영");
            set_none("이주안", "이윤희");
            set_none("남은택", "오영은");
            set_none("이경수", "이다은");
            set_none("전찬영", "최주연");
            set_none("황겨레", "강내은");

            set_none("김시온", "노민영");
            set_none("강주헌", "이다은");
            set_none("송영한", "송원경");
            set_none("황겨레", "나지혜");
            set_none("전영우", "이은혜");
            set_none("김동규", "최윤정");
            set_none("이주안", "최희락");
            set_none("남은택", "이윤희");
            set_none("전찬영", "홍은아");
            set_none("이요셉", "김예은");
            set_none("박상호", "이혜원");
            set_none("안정호", "김진향");
            set_none("이민규", "오영은");
            set_none("이경수", "이홍주");
            set_none("정성욱", "최주연");
            set_none("현동우", "강내은");

            set_none("안정호", "이혜원");
            set_none("안정호", "오영은");
            set_none("이민규", "오영은");
            set_none("이민규", "이혜원");
            set_none("김시온", "홍은아");
            set_none("이요셉", "이다은");
            set_none("남은택", "강내은");
            set_none("김동규", "최주연");
            set_none("안정호", "최희락");
            set_none("강주헌", "노민영");
            set_none("정성욱", "나지혜");
            set_none("이주안", "최윤정");
            set_none("현동우", "이은혜");
            set_none("이경수", "송원경");
            set_none("전영우", "이윤희");
            set_none("전찬영", "오영은");
            set_none("황겨레", "김예은");
            set_none("박상호", "이홍주");
            set_none("이민규", "김진향");
            set_none("송영한", "이혜원");

            set_none("이요셉", "이윤희");
            set_none("이민규", "노민영");
            set_none("현동우","김진향");
            set_none("전찬영","이다은");
            set_none("김동규" ,"김예은");
            set_none("남은택", "이은혜");
            set_none("강주헌 이홍주");
            set_none("이경수 최윤정");
            set_none("이주안 송원경");
            set_none("황겨레 최희락");
            set_none("안정호 나지혜");
            set_none("박상호 오영은");
            set_none("김시온 홍은아");
            set_none("전영우 이혜원");
            set_none("정성욱 강내은");
            set_none("송영한 최주연");
            set_none("이경수 이윤희");

            set_none("김시온 김예은");
            set_none("정성욱 최희락");
            set_none("이요셉 노민영");
            set_none("안정호 이홍주");
            set_none("이주안 김진향");
            set_none("강주헌 이윤희");
            set_none("송영한 강내은");
            set_none("황겨레 최주연");
            set_none("전찬영 송원경");
            set_none("남은택 이혜원");
            set_none("박상호 홍은아");
            set_none("이경수 이은혜");
            set_none("전영우 최윤정");
            set_none("현동우 이다은");
            set_none("이민규 나지혜");
            set_none("김동규 오영은");



            for (int i=0; i<32; i++)
            {
                if(mem[i].traits == "새내기")
                {
                    for (int j = 0; j < 32; j++)
                        if (mem[j].traits == "새내기" && i != j)
                            mem[i].set_non(mem[j].name);


                    mem[14].set_non(mem[i].name);
                    mem[15].set_non(mem[i].name);
                    mem[i].set_non("이다은");
                }


            }
        }

        public void set_none(string male, string female)
        {
            int n_male = 0;
            int n_female = 0;

            for (int i = 0; i < 32; i++)
                if (mem[i].name == male)
                    n_male = i;

            for (int i = 0; i < 32; i++)
                if (mem[i].name == female)
                    n_female = i;

            mem[n_male].set_non(female);
        }

        public void set_none(string str)
        {
            string male = str.Substring(0, 3);
            string female = str.Substring(4, 3);

            int n_male = 0;
            int n_female = 0;

            for (int i = 0; i < 32; i++)
                if (mem[i].name == male)
                    n_male = i;

            for (int i = 0; i < 32; i++)
                if (mem[i].name == female)
                    n_female = i;

            mem[n_male].set_non(female);
        }

        public void show_mem()
        {
            string str = "";

            Label[] label_test = new Label[32];

            for (int i = 0; i < 32; i++)
                label_test[i] = new Label();

            int k = 0;

            for (int i = 0; i < 32; i++)
            {
                if (mem[i].traits == "새내기" || mem[i].traits == "새섬")
                {
                    label_test[k++].Text = mem[i].name;
                    str += mem[i].name + "\n";
                }
            }

            //for (int i = 0; i < 11; i++)
            //{
            //    this.Controls.Add(label_test[i]);
            //    label_test[i].Location = new Point(this.Width / 2, (int)(this.Height * (i+1) / 13.0));
            //}
            
            str = "";

            for (int i = 0; i < 32; i++)
            {
                this.Controls.Add(label_test[i]);
                label_test[i].Text = "" + mem[i].number;
                label_test[i].Location = new Point(this.Width / 2, (int)(this.Height * (i + 1) / 33.0));
                str += mem[i].name + ": " + mem[i].number + "\n";
            }

            Clipboard.SetText(str);

        }

        public void result_norestrict()
        {


            int index_male = 0;
            int index_female = 0;

            for(int index = 0; index<32; index++)
            {
                for(int i=0; i<32; i++)
                {
                    if(mem[i].number == index)
                    {
                        if (mem[i].gender == person.sex.female)
                            mem_list[1][index_female++] = mem[i];

                        else
                            mem_list[0][index_male++] = mem[i];
                    }
                }
            }

            string str = "";
            string str_cp = "";

            for(int i=0; i<16; i++)
            {
                str += mem_list[0][i].name + " - " + mem_list[1][i].name + "\n\n";

                str_cp += mem_list[0][i].name + " - " + mem_list[1][i].name + "\n";
            }


            Clipboard.SetText(str_cp);

            Label lll = new Label();
            lll.Height = 400;
            lll.Text = str;
            lll.ForeColor = Color.White;
            lll.Location = new Point(this.Width / 2 - lll.Width / 2, 50);
            this.Controls.Add(lll);

        }

        public void result_nooverap()
        {
            int index_male = 0;

            for(int index=0; index<32; index++)
            {
                for(int i = 0; i<32; i++)
                    if (mem[i].gender == person.sex.male && mem[i].number == index)
                         mem_list[0][index_male++] = mem[i];

            }

            index_male = 0;

            List<person> fe_list = new List<person>();


            for(int index = 0; index < 32; index++)
            {
                for (int i = 0; i < 32; i++)
                    if (mem[i].gender == person.sex.female && mem[i].number == index)
                        fe_list.Add(mem[i]);

            }

            for (int i = 0; i < 16; i++)
             {
                for (int index = 0; index < fe_list.Count; index++)
                {
                    if (mem_list[0][i].check_mem(fe_list[index]))
                    {
                        mem_list[1][index_male++] = fe_list[index];
                        fe_list.RemoveAt(index);
                        break;
                    }

                    else if (index == fe_list.Count-1 && !mem_list[0][i].check_mem(fe_list[index]))
                    {
                        person v = new person("none", 0, 0, person.sex.female);
                        mem_list[1][index_male++] = v;

                        this.Controls.Clear();
                        initializemember();
                        // show_mem();
                        //result_norestrict();
                        result_nooverap();
                        break;
                    }
                }
             }



            ////////////// design /////////
            string str = "";
            string str_cp = "";

            for (int i = 0; i < 16; i++)
            {
                str += mem_list[0][i].name + " - " + mem_list[1][i].name + "\n\n";

                str_cp += mem_list[0][i].name + " - " + mem_list[1][i].name + "\n";
            }


            Clipboard.SetText(str_cp);

            Label lll = new Label();
            lll.Height = 400;
            lll.Text = str;
            lll.ForeColor = Color.White;
            lll.Location = new Point(this.Width / 2 - lll.Width / 2, 50);
            this.Controls.Add(lll);
        }
    }




    public partial class person
    {
        public string name;
        public int age;
        public int id;
        public sex gender;
        public int number;
        public List<string> non_mem = new List<string>();

        public enum sex { male, female }

        public person()
        {

        }
        

        public person(string name, int id, int age, sex gender)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.gender = gender;
        }

        public string traits { get; set; }

        public bool check_mem(person other)
        {
            bool b = true;

            for (int i = 0; i < non_mem.Count; i++)
            {
                if (non_mem[i] == other.name)
                {
                    b = false;
                    break;
                }
            }

            return b;
        }

        public void set_non(string str)
        {
            this.non_mem.Add(str);
        }
    }



    public partial class person
    {
        public string prior;
    }

    
}
