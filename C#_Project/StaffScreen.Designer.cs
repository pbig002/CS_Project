namespace C__Project
{
    partial class StaffScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.ShowStaff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.birthday_datepicker = new System.Windows.Forms.DateTimePicker();
            this.gender_textbox = new System.Windows.Forms.TextBox();
            this.surename_textbox = new System.Windows.Forms.TextBox();
            this.village_textbox = new System.Windows.Forms.TextBox();
            this.district_textbox = new System.Windows.Forms.TextBox();
            this.province_textbox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.village = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.choose_image = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.mail_textbox = new System.Windows.Forms.TextBox();
            this.facebook_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dep_textbox = new System.Windows.Forms.TextBox();
            this.pos_textbox = new System.Windows.Forms.TextBox();
            this.qua_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.ShowStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(671, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(21, 184);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(21, 135);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(21, 84);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // ShowStaff
            // 
            this.ShowStaff.Location = new System.Drawing.Point(21, 33);
            this.ShowStaff.Name = "ShowStaff";
            this.ShowStaff.Size = new System.Drawing.Size(82, 32);
            this.ShowStaff.TabIndex = 0;
            this.ShowStaff.Text = "Show Table";
            this.ShowStaff.UseVisualStyleBackColor = true;
            this.ShowStaff.Click += new System.EventHandler(this.ShowStaff_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.choose_image);
            this.panel3.Controls.Add(this.picture_box);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.birthday_datepicker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 251);
            this.panel3.TabIndex = 2;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(80, 36);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // birthday_datepicker
            // 
            this.birthday_datepicker.Location = new System.Drawing.Point(465, 135);
            this.birthday_datepicker.Name = "birthday_datepicker";
            this.birthday_datepicker.Size = new System.Drawing.Size(200, 20);
            this.birthday_datepicker.TabIndex = 1;
            // 
            // gender_textbox
            // 
            this.gender_textbox.Location = new System.Drawing.Point(80, 3);
            this.gender_textbox.Name = "gender_textbox";
            this.gender_textbox.Size = new System.Drawing.Size(100, 20);
            this.gender_textbox.TabIndex = 2;
            this.gender_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // surename_textbox
            // 
            this.surename_textbox.Location = new System.Drawing.Point(80, 75);
            this.surename_textbox.Name = "surename_textbox";
            this.surename_textbox.Size = new System.Drawing.Size(100, 20);
            this.surename_textbox.TabIndex = 3;
            this.surename_textbox.TextChanged += new System.EventHandler(this.surename_textbox_TextChanged);
            // 
            // village_textbox
            // 
            this.village_textbox.Location = new System.Drawing.Point(97, 3);
            this.village_textbox.Name = "village_textbox";
            this.village_textbox.Size = new System.Drawing.Size(100, 20);
            this.village_textbox.TabIndex = 4;
            this.village_textbox.TextChanged += new System.EventHandler(this.village_textbox_TextChanged);
            // 
            // district_textbox
            // 
            this.district_textbox.Location = new System.Drawing.Point(97, 37);
            this.district_textbox.Name = "district_textbox";
            this.district_textbox.Size = new System.Drawing.Size(100, 20);
            this.district_textbox.TabIndex = 5;
            // 
            // province_textbox
            // 
            this.province_textbox.Location = new System.Drawing.Point(97, 77);
            this.province_textbox.Name = "province_textbox";
            this.province_textbox.Size = new System.Drawing.Size(100, 20);
            this.province_textbox.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.surename_textbox);
            this.panel4.Controls.Add(this.name_textbox);
            this.panel4.Controls.Add(this.gender_textbox);
            this.panel4.Location = new System.Drawing.Point(12, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sure name";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.village);
            this.panel5.Controls.Add(this.village_textbox);
            this.panel5.Controls.Add(this.district_textbox);
            this.panel5.Controls.Add(this.province_textbox);
            this.panel5.Location = new System.Drawing.Point(231, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 8;
            // 
            // village
            // 
            this.village.AutoSize = true;
            this.village.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.village.Location = new System.Drawing.Point(23, 9);
            this.village.Name = "village";
            this.village.Size = new System.Drawing.Size(37, 13);
            this.village.TabIndex = 7;
            this.village.Text = "village";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(26, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "district";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(26, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "province";
            // 
            // picture_box
            // 
            this.picture_box.BackColor = System.Drawing.Color.Honeydew;
            this.picture_box.Location = new System.Drawing.Point(527, 9);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(124, 92);
            this.picture_box.TabIndex = 9;
            this.picture_box.TabStop = false;
            this.picture_box.Click += new System.EventHandler(this.picture_box_Click);
            // 
            // choose_image
            // 
            this.choose_image.Location = new System.Drawing.Point(554, 107);
            this.choose_image.Name = "choose_image";
            this.choose_image.Size = new System.Drawing.Size(75, 23);
            this.choose_image.TabIndex = 10;
            this.choose_image.Text = "button1";
            this.choose_image.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.facebook_textbox);
            this.panel6.Controls.Add(this.mail_textbox);
            this.panel6.Controls.Add(this.tel_textbox);
            this.panel6.Location = new System.Drawing.Point(12, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 11;
            // 
            // tel_textbox
            // 
            this.tel_textbox.Location = new System.Drawing.Point(80, 13);
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(100, 20);
            this.tel_textbox.TabIndex = 0;
            // 
            // mail_textbox
            // 
            this.mail_textbox.Location = new System.Drawing.Point(80, 42);
            this.mail_textbox.Name = "mail_textbox";
            this.mail_textbox.Size = new System.Drawing.Size(100, 20);
            this.mail_textbox.TabIndex = 1;
            // 
            // facebook_textbox
            // 
            this.facebook_textbox.Location = new System.Drawing.Point(80, 69);
            this.facebook_textbox.Name = "facebook_textbox";
            this.facebook_textbox.Size = new System.Drawing.Size(100, 20);
            this.facebook_textbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(17, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "facebook";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.qua_textbox);
            this.panel7.Controls.Add(this.pos_textbox);
            this.panel7.Controls.Add(this.dep_textbox);
            this.panel7.Location = new System.Drawing.Point(257, 144);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 12;
            // 
            // dep_textbox
            // 
            this.dep_textbox.Location = new System.Drawing.Point(89, 13);
            this.dep_textbox.Name = "dep_textbox";
            this.dep_textbox.Size = new System.Drawing.Size(100, 20);
            this.dep_textbox.TabIndex = 0;
            // 
            // pos_textbox
            // 
            this.pos_textbox.Location = new System.Drawing.Point(89, 40);
            this.pos_textbox.Name = "pos_textbox";
            this.pos_textbox.Size = new System.Drawing.Size(100, 20);
            this.pos_textbox.TabIndex = 1;
            // 
            // qua_textbox
            // 
            this.qua_textbox.Location = new System.Drawing.Point(89, 68);
            this.qua_textbox.Name = "qua_textbox";
            this.qua_textbox.Size = new System.Drawing.Size(100, 20);
            this.qua_textbox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(4, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(21, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "position";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(27, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "quality";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 199);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // StaffScreen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StaffScreen";
            this.Load += new System.EventHandler(this.StaffScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox gender_textbox;
        private System.Windows.Forms.DateTimePicker birthday_datepicker;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox district_textbox;
        private System.Windows.Forms.TextBox village_textbox;
        private System.Windows.Forms.TextBox surename_textbox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox province_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label village;
        private System.Windows.Forms.Button choose_image;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox facebook_textbox;
        private System.Windows.Forms.TextBox mail_textbox;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox qua_textbox;
        private System.Windows.Forms.TextBox pos_textbox;
        private System.Windows.Forms.TextBox dep_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}