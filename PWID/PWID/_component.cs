using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PWID
{
    class _component
    {
        static public System.Drawing.Point mouse_present { get; set; }
        static public string PWD = "";
        static public List<Form1> open = new List<Form1>();
        static public List<Main> main = new List<Main>();
        static public string password;
    }

    class _switch
    {
        static public bool this_move = false;
    }

    class Comp : PictureBox
    {
        private bool activated;
        public bool Activated
        {
            get
            {
                return activated;
            }

            set
            {
                if(value)
                {
                    activated = value;
                    activate();
                }

                else
                {
                    activated = !value;
                    deactivate();
                }
            }
        }

        public string ID { get; set; }
        public string PWD { get; set; }
        public string NickName { get; set; }
        public string URL { get; set; }
        
        public Comp()
        {
            this.Activated = false;
            defaultset();
        }

        public Comp(bool activate)
        {
            this.Activated = activate;
            defaultset();
        }

        private void activate()
        {
            this.Load(@"image\activated.png");
        }

        private void deactivate()
        {
            this.Load(@"image\deactivated.png");
        }

        private void defaultset()
        {
            this.BackColor = System.Drawing.Color.White;
        }

    }
    


}
