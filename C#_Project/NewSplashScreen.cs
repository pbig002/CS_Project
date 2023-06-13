using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class NewSplashScreen : Form
    {
        public NewSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void NewSplashScreen_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        //    panel2.Width = 100;
        
            panel2.Width += 3;
            if (panel2.Width >= 684)
            {
                timer2.Stop();
                MianScreen mianScreen = new MianScreen();
                mianScreen.Show();
                this.Hide();
            }
        }
    }
}
