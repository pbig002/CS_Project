using C__Project.db_salaryDataSetTableAdapters;
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

        private void dep_button_Click(object sender, EventArgs e)
        {
            {
              //  StaffScreen s = new StaffScreen();
              DepartmentScreen s = new DepartmentScreen();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                panelController.Controls.Add(s);
                s.BringToFront();
                s.Show();
            }
        }

        private void pos_button_Click(object sender, EventArgs e)
        {
            PositionScreen s = new PositionScreen();
            s.TopLevel = false;
            s.Dock = DockStyle.Fill;
            panelController.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quilitification_screen s = new Quilitification_screen();
            s.TopLevel = false;
            s.Dock = DockStyle.Fill;
            panelController.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
