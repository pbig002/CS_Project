namespace C__Project
{
    partial class MianScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MianScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pos_button = new System.Windows.Forms.Button();
            this.dep_button = new System.Windows.Forms.Button();
            this.staffShow_button = new System.Windows.Forms.Button();
            this.panelController = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.db_salaryDataSet = new C__Project.db_salaryDataSet();
            this.dbsalaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelController.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_salaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalaryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pos_button);
            this.panel1.Controls.Add(this.dep_button);
            this.panel1.Controls.Add(this.staffShow_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 530);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 130);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "  Qualification";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pos_button
            // 
            this.pos_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.pos_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pos_button.FlatAppearance.BorderSize = 2;
            this.pos_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.pos_button.Image = ((System.Drawing.Image)(resources.GetObject("pos_button.Image")));
            this.pos_button.Location = new System.Drawing.Point(12, 198);
            this.pos_button.Name = "pos_button";
            this.pos_button.Size = new System.Drawing.Size(221, 79);
            this.pos_button.TabIndex = 2;
            this.pos_button.Text = "  position";
            this.pos_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pos_button.UseVisualStyleBackColor = false;
            this.pos_button.Click += new System.EventHandler(this.pos_button_Click);
            // 
            // dep_button
            // 
            this.dep_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.dep_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dep_button.FlatAppearance.BorderSize = 2;
            this.dep_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dep_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.dep_button.Image = ((System.Drawing.Image)(resources.GetObject("dep_button.Image")));
            this.dep_button.Location = new System.Drawing.Point(12, 101);
            this.dep_button.Name = "dep_button";
            this.dep_button.Size = new System.Drawing.Size(221, 79);
            this.dep_button.TabIndex = 1;
            this.dep_button.Text = "department";
            this.dep_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dep_button.UseVisualStyleBackColor = false;
            this.dep_button.Click += new System.EventHandler(this.dep_button_Click);
            // 
            // staffShow_button
            // 
            this.staffShow_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.staffShow_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.staffShow_button.FlatAppearance.BorderSize = 2;
            this.staffShow_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffShow_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffShow_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.staffShow_button.Image = ((System.Drawing.Image)(resources.GetObject("staffShow_button.Image")));
            this.staffShow_button.Location = new System.Drawing.Point(12, 6);
            this.staffShow_button.Name = "staffShow_button";
            this.staffShow_button.Size = new System.Drawing.Size(221, 79);
            this.staffShow_button.TabIndex = 0;
            this.staffShow_button.Text = "   Staff";
            this.staffShow_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staffShow_button.UseVisualStyleBackColor = false;
            this.staffShow_button.Click += new System.EventHandler(this.teacher_show_btn_Click);
            // 
            // panelController
            // 
            this.panelController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panelController.Controls.Add(this.panel1);
            this.panelController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelController.Location = new System.Drawing.Point(0, 97);
            this.panelController.Name = "panelController";
            this.panelController.Size = new System.Drawing.Size(1066, 530);
            this.panelController.TabIndex = 2;
            this.panelController.Paint += new System.Windows.Forms.PaintEventHandler(this.panelController_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exit_button);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 97);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Salary \r\nCompany";
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.Location = new System.Drawing.Point(988, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 69);
            this.exit_button.TabIndex = 4;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 88);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(661, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 97);
            this.button4.TabIndex = 2;
            this.button4.Text = "   Issue salary";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(483, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "   List";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(325, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "  Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // db_salaryDataSet
            // 
            this.db_salaryDataSet.DataSetName = "db_salaryDataSet";
            this.db_salaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbsalaryDataSetBindingSource
            // 
            this.dbsalaryDataSetBindingSource.DataSource = this.db_salaryDataSet;
            this.dbsalaryDataSetBindingSource.Position = 0;
            // 
            // MianScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 627);
            this.Controls.Add(this.panelController);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MianScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MianScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelController.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_salaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalaryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button staffShow_button;
        private System.Windows.Forms.Panel panelController;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource dbsalaryDataSetBindingSource;
        private db_salaryDataSet db_salaryDataSet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pos_button;
        private System.Windows.Forms.Button dep_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

