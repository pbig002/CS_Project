using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class MianScreen : Form
    {
        public MianScreen()
        {
            InitializeComponent();
        }
       

        private void teacher_show_btn_Click(object sender, EventArgs e)
        {
            {
                StaffScreen s = new StaffScreen();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                panelController.Controls.Add(s);
                s.BringToFront();
                s.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelController_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
