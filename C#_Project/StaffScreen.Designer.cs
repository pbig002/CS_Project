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
            this.ShowStaff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.qua_textbox = new System.Windows.Forms.TextBox();
            this.pos_textbox = new System.Windows.Forms.TextBox();
            this.dep_textbox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.facebook_textbox = new System.Windows.Forms.TextBox();
            this.mail_textbox = new System.Windows.Forms.TextBox();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.choose_image = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.village = new System.Windows.Forms.Label();
            this.village_textbox = new System.Windows.Forms.TextBox();
            this.district_textbox = new System.Windows.Forms.TextBox();
            this.province_textbox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surename_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.gender_textbox = new System.Windows.Forms.TextBox();
            this.birthday_datepicker = new System.Windows.Forms.DateTimePicker();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.delete_button = new Guna.UI2.WinForms.Guna2Button();
            this.update_button = new Guna.UI2.WinForms.Guna2Button();
            this.save_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.ShowStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(887, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 725);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ShowStaff
            // 
            this.ShowStaff.Location = new System.Drawing.Point(56, 313);
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
            this.panel2.Size = new System.Drawing.Size(1086, 725);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(229)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 474);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
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
            this.panel3.Size = new System.Drawing.Size(887, 251);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.qua_textbox);
            this.panel7.Controls.Add(this.pos_textbox);
            this.panel7.Controls.Add(this.dep_textbox);
            this.panel7.Location = new System.Drawing.Point(492, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(147, 100);
            this.panel7.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label11.Location = new System.Drawing.Point(27, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "quality";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label10.Location = new System.Drawing.Point(21, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label9.Location = new System.Drawing.Point(4, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "department";
            // 
            // qua_textbox
            // 
            this.qua_textbox.Location = new System.Drawing.Point(89, 68);
            this.qua_textbox.Name = "qua_textbox";
            this.qua_textbox.Size = new System.Drawing.Size(100, 20);
            this.qua_textbox.TabIndex = 2;
            // 
            // pos_textbox
            // 
            this.pos_textbox.Location = new System.Drawing.Point(89, 40);
            this.pos_textbox.Name = "pos_textbox";
            this.pos_textbox.Size = new System.Drawing.Size(100, 20);
            this.pos_textbox.TabIndex = 1;
            // 
            // dep_textbox
            // 
            this.dep_textbox.Location = new System.Drawing.Point(89, 13);
            this.dep_textbox.Name = "dep_textbox";
            this.dep_textbox.Size = new System.Drawing.Size(100, 20);
            this.dep_textbox.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.facebook_textbox);
            this.panel6.Controls.Add(this.mail_textbox);
            this.panel6.Controls.Add(this.tel_textbox);
            this.panel6.Location = new System.Drawing.Point(732, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 100);
            this.panel6.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label8.Location = new System.Drawing.Point(17, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "facebook";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tel";
            // 
            // facebook_textbox
            // 
            this.facebook_textbox.Location = new System.Drawing.Point(80, 69);
            this.facebook_textbox.Name = "facebook_textbox";
            this.facebook_textbox.Size = new System.Drawing.Size(100, 20);
            this.facebook_textbox.TabIndex = 2;
            // 
            // mail_textbox
            // 
            this.mail_textbox.Location = new System.Drawing.Point(80, 42);
            this.mail_textbox.Name = "mail_textbox";
            this.mail_textbox.Size = new System.Drawing.Size(100, 20);
            this.mail_textbox.TabIndex = 1;
            // 
            // tel_textbox
            // 
            this.tel_textbox.Location = new System.Drawing.Point(80, 13);
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(100, 20);
            this.tel_textbox.TabIndex = 0;
            // 
            // choose_image
            // 
            this.choose_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_image.Location = new System.Drawing.Point(244, 135);
            this.choose_image.Name = "choose_image";
            this.choose_image.Size = new System.Drawing.Size(75, 23);
            this.choose_image.TabIndex = 10;
            this.choose_image.Text = "button1";
            this.choose_image.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.village);
            this.panel5.Controls.Add(this.village_textbox);
            this.panel5.Controls.Add(this.district_textbox);
            this.panel5.Controls.Add(this.province_textbox);
            this.panel5.Location = new System.Drawing.Point(240, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 100);
            this.panel5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label6.Location = new System.Drawing.Point(26, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "province";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label5.Location = new System.Drawing.Point(26, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "district";
            // 
            // village
            // 
            this.village.AutoSize = true;
            this.village.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.village.Location = new System.Drawing.Point(23, 9);
            this.village.Name = "village";
            this.village.Size = new System.Drawing.Size(37, 13);
            this.village.TabIndex = 7;
            this.village.Text = "village";
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
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.surename_textbox);
            this.panel4.Controls.Add(this.name_textbox);
            this.panel4.Controls.Add(this.gender_textbox);
            this.panel4.Location = new System.Drawing.Point(12, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 100);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sure name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "gender";
            // 
            // surename_textbox
            // 
            this.surename_textbox.Location = new System.Drawing.Point(80, 75);
            this.surename_textbox.Name = "surename_textbox";
            this.surename_textbox.Size = new System.Drawing.Size(100, 20);
            this.surename_textbox.TabIndex = 3;
            this.surename_textbox.TextChanged += new System.EventHandler(this.surename_textbox_TextChanged);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(80, 36);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // gender_textbox
            // 
            this.gender_textbox.Location = new System.Drawing.Point(80, 3);
            this.gender_textbox.Name = "gender_textbox";
            this.gender_textbox.Size = new System.Drawing.Size(100, 20);
            this.gender_textbox.TabIndex = 2;
            this.gender_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // birthday_datepicker
            // 
            this.birthday_datepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthday_datepicker.Location = new System.Drawing.Point(377, 174);
            this.birthday_datepicker.Name = "birthday_datepicker";
            this.birthday_datepicker.Size = new System.Drawing.Size(200, 20);
            this.birthday_datepicker.TabIndex = 1;
            // 
            // picture_box
            // 
            this.picture_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(229)))));
            this.picture_box.Location = new System.Drawing.Point(73, 135);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(124, 92);
            this.picture_box.TabIndex = 9;
            this.picture_box.TabStop = false;
            this.picture_box.Click += new System.EventHandler(this.picture_box_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(201)))));
            this.delete_button.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.delete_button.BorderRadius = 8;
            this.delete_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.Black;
            this.delete_button.Image = global::C__Project.Properties.Resources.delete;
            this.delete_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.delete_button.ImageSize = new System.Drawing.Size(30, 30);
            this.delete_button.IndicateFocus = true;
            this.delete_button.Location = new System.Drawing.Point(7, 202);
            this.delete_button.Name = "delete_button";
            this.delete_button.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.delete_button.Size = new System.Drawing.Size(180, 75);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "DELETE";
            this.delete_button.TextFormatNoPrefix = true;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(201)))));
            this.update_button.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.update_button.BorderRadius = 8;
            this.update_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.update_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.Black;
            this.update_button.Image = global::C__Project.Properties.Resources.changes;
            this.update_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.update_button.ImageSize = new System.Drawing.Size(30, 30);
            this.update_button.IndicateFocus = true;
            this.update_button.Location = new System.Drawing.Point(7, 111);
            this.update_button.Name = "update_button";
            this.update_button.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.update_button.Size = new System.Drawing.Size(180, 75);
            this.update_button.TabIndex = 10;
            this.update_button.Text = "UPDATE";
            this.update_button.TextFormatNoPrefix = true;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(187)))), ((int)(((byte)(201)))));
            this.save_button.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.save_button.BorderRadius = 8;
            this.save_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.save_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.save_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.save_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.save_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.Black;
            this.save_button.Image = global::C__Project.Properties.Resources.download;
            this.save_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.save_button.ImageSize = new System.Drawing.Size(30, 30);
            this.save_button.IndicateFocus = true;
            this.save_button.Location = new System.Drawing.Point(7, 12);
            this.save_button.Name = "save_button";
            this.save_button.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.save_button.Size = new System.Drawing.Size(180, 75);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "SAVE";
            this.save_button.TextFormatNoPrefix = true;
            // 
            // StaffScreen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1086, 725);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Name = "StaffScreen";
            this.Load += new System.EventHandler(this.StaffScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowStaff;
        private System.Windows.Forms.Panel panel2;
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
        private Guna.UI2.WinForms.Guna2Button delete_button;
        private Guna.UI2.WinForms.Guna2Button update_button;
        private Guna.UI2.WinForms.Guna2Button save_button;
    }
}