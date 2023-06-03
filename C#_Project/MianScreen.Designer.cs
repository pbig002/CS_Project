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
            this.staffShow_btn = new System.Windows.Forms.Button();
            this.panelController = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.db_salaryDataSet = new C__Project.db_salaryDataSet();
            this.dbsalaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_salaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalaryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.staffShow_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 527);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // staffShow_btn
            // 
            this.staffShow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffShow_btn.Location = new System.Drawing.Point(13, 119);
            this.staffShow_btn.Name = "staffShow_btn";
            this.staffShow_btn.Size = new System.Drawing.Size(75, 23);
            this.staffShow_btn.TabIndex = 0;
            this.staffShow_btn.Text = "Staff";
            this.staffShow_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffShow_btn.UseVisualStyleBackColor = true;
            this.staffShow_btn.Click += new System.EventHandler(this.teacher_show_btn_Click);
            // 
            // panelController
            // 
            this.panelController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelController.Location = new System.Drawing.Point(120, 35);
            this.panelController.Name = "panelController";
            this.panelController.Size = new System.Drawing.Size(839, 492);
            this.panelController.TabIndex = 2;
            this.panelController.Paint += new System.Windows.Forms.PaintEventHandler(this.panelController_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(120, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 35);
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
            // MianScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 527);
            this.Controls.Add(this.panelController);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MianScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_salaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalaryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button staffShow_btn;
        private System.Windows.Forms.Panel panelController;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource dbsalaryDataSetBindingSource;
        private db_salaryDataSet db_salaryDataSet;
    }
}

