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
            this.staffShow_button = new System.Windows.Forms.Button();
            this.panelController = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.db_salaryDataSet = new C__Project.db_salaryDataSet();
            this.dbsalaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dep_button = new System.Windows.Forms.Button();
            this.pos_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_salaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalaryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pos_button);
            this.panel1.Controls.Add(this.dep_button);
            this.panel1.Controls.Add(this.staffShow_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // staffShow_button
            // 
            this.staffShow_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.staffShow_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffShow_button.Location = new System.Drawing.Point(38, 70);
            this.staffShow_button.Name = "staffShow_button";
            this.staffShow_button.Size = new System.Drawing.Size(90, 40);
            this.staffShow_button.TabIndex = 0;
            this.staffShow_button.Text = "Staff";
            this.staffShow_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffShow_button.UseVisualStyleBackColor = false;
            this.staffShow_button.Click += new System.EventHandler(this.teacher_show_btn_Click);
            // 
            // panelController
            // 
            this.panelController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panelController.Controls.Add(this.panel1);
            this.panelController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelController.Location = new System.Drawing.Point(0, 89);
            this.panelController.Name = "panelController";
            this.panelController.Size = new System.Drawing.Size(959, 438);
            this.panelController.TabIndex = 2;
            this.panelController.Paint += new System.Windows.Forms.PaintEventHandler(this.panelController_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 89);
            this.panel2.TabIndex = 1;
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
            // dep_button
            // 
            this.dep_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.dep_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dep_button.Location = new System.Drawing.Point(38, 138);
            this.dep_button.Name = "dep_button";
            this.dep_button.Size = new System.Drawing.Size(90, 40);
            this.dep_button.TabIndex = 1;
            this.dep_button.Text = "department";
            this.dep_button.UseVisualStyleBackColor = false;
            this.dep_button.Click += new System.EventHandler(this.dep_button_Click);
            // 
            // pos_button
            // 
            this.pos_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.pos_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos_button.Location = new System.Drawing.Point(38, 204);
            this.pos_button.Name = "pos_button";
            this.pos_button.Size = new System.Drawing.Size(90, 40);
            this.pos_button.TabIndex = 2;
            this.pos_button.Text = "position";
            this.pos_button.UseVisualStyleBackColor = false;
            this.pos_button.Click += new System.EventHandler(this.pos_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(38, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "qualification";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MianScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 527);
            this.Controls.Add(this.panelController);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MianScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panelController.ResumeLayout(false);
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
    }
}

