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
    public partial class StaffScreen : System.Windows.Forms.Form
    {

        public StaffScreen()
        {
            InitializeComponent();
        }
        string img = null;
        string connectionString = "Data Source=LAPTOP-78EFFK5G;Initial Catalog= db_salary;Integrated Security=True";
        private void _ShowStaff()
        {
            string query = "SELECT st_id, gender, name, surename, birthday, village, district, province, tel, mail, facebook, pic, dep, pos, qua FROM staff";
           // string query = "SELECT * FROM staff";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void ShowStaff_Click(object sender, EventArgs e)
        {
            _ShowStaff();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffScreen_Load(object sender, EventArgs e)
        {
            // _ShowStaff();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO staff (gender, name, surename, birthday, village, district, province, tel, mail, facebook, dep, pos, qua) " +
               "VALUES (@Gender, @Name, @Surename, @Birthday, @Village, @District, @Province, @Tel, @Mail, @Facebook, @Dep, @Pos, @Qua)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Gender", gender_textbox.Text);
                  //  command.Parameters.AddWithValue("@Name", name_textbox.Text);
                    command.Parameters.AddWithValue("@Surename", surename_textbox.Text);
                    command.Parameters.AddWithValue("@Birthday", birthday_datepicker.Value);
                    command.Parameters.AddWithValue("@Village", village_textbox.Text);
                    command.Parameters.AddWithValue("@District", district_textbox.Text);
               //     command.Parameters.AddWithValue("@Province", province_textbox.Text);
                    command.Parameters.AddWithValue("@Tel", tel_textbox.Text);
                    command.Parameters.AddWithValue("@Mail", mail_textbox.Text);
                    command.Parameters.AddWithValue("@Facebook", facebook_textbox.Text);
                    command.Parameters.AddWithValue("@Picture", picture_box.Image);
               //     command.Parameters.AddWithValue("@Dep", dep_textbox.Text);
                 //   command.Parameters.AddWithValue("@Pos", pos_textbox.Text);
                   // command.Parameters.AddWithValue("@Qua", qua_textbox.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            _ShowStaff();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int staffId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["StaffId"].Value);

                string query = "DELETE FROM staff WHERE st_id = @StaffId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffId", staffId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                _ShowStaff();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int staffId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["StaffId"].Value);

                string query = "UPDATE staff SET gender = @Gender, name = @Name, surename = @Surename, birthday = @Birthday, " +
                    "village = @Village, district = @District, province = @Province, tel = @Tel, mail = @Mail, facebook = @Facebook, " +
                    "pic = @Picture, dep = @Dep, pos = @Pos, qua = @Qua WHERE st_Id = @StaffId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Gender", gender_textbox.Text);
                    //    command.Parameters.AddWithValue("@Name", name_textbox.Text);
                        command.Parameters.AddWithValue("@Surename", surename_textbox.Text);
                        command.Parameters.AddWithValue("@Birthday", birthday_datepicker.Value);
                        command.Parameters.AddWithValue("@Village", village_textbox.Text);
                        command.Parameters.AddWithValue("@District", district_textbox.Text);
                      //  command.Parameters.AddWithValue("@Province", province_textbox.Text);
                        command.Parameters.AddWithValue("@Tel", tel_textbox.Text);
                        command.Parameters.AddWithValue("@Mail", mail_textbox.Text);
                        command.Parameters.AddWithValue("@Facebook", facebook_textbox.Text);
                        command.Parameters.AddWithValue("@Picture", picture_box.Image);
                        //command.Parameters.AddWithValue("@Dep", dep_textbox.Text);
                        //command.Parameters.AddWithValue("@Pos", pos_textbox.Text);
                        //command.Parameters.AddWithValue("@Qua", qua_textbox.Text);
                        command.Parameters.AddWithValue("@StaffId", staffId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                _ShowStaff();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void village_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surename_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_box_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void choose_image_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    img = ofd.FileName;
                    picture_box.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
