using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
          time.Sec();
          label1.Text = time.Hours.ToString() + " Hours and " + time.Minuties.ToString() + " Minutes and " +
                        time.second.ToString() + " Seconds passed";

        }
        public static class time
        {
            public static int second;
            public static int Minuties;
            public static int Hours;

            public static void Sec()
            {
                second++;
                if (second >= 60)
                {
                    second = 0;
                    Minuties++;
                }
                if (Minuties >= 60)
                {
                    second = 0;
                    Minuties = 0;
                    Hours++;
                }
            }

            
            

        }
    }
}
