namespace OurClass
{
    partial class SeeStudentInfo
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.comboSelectStudent = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.dgvStudentsLessons = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStudents.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(913, 124);
            this.dgvStudents.TabIndex = 0;
            // 
            // comboSelectStudent
            // 
            this.comboSelectStudent.FormattingEnabled = true;
            this.comboSelectStudent.Location = new System.Drawing.Point(292, 160);
            this.comboSelectStudent.Name = "comboSelectStudent";
            this.comboSelectStudent.Size = new System.Drawing.Size(149, 21);
            this.comboSelectStudent.TabIndex = 1;
            this.comboSelectStudent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStudentName.Location = new System.Drawing.Point(150, 152);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(125, 34);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Select Student";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // dgvStudentsLessons
            // 
            this.dgvStudentsLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentsLessons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudentsLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsLessons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudentsLessons.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStudentsLessons.Location = new System.Drawing.Point(0, 212);
            this.dgvStudentsLessons.Name = "dgvStudentsLessons";
            this.dgvStudentsLessons.ReadOnly = true;
            this.dgvStudentsLessons.Size = new System.Drawing.Size(913, 153);
            this.dgvStudentsLessons.TabIndex = 3;
            this.dgvStudentsLessons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsLessons_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 158);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(511, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SeeStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvStudentsLessons);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.comboSelectStudent);
            this.Controls.Add(this.dgvStudents);
            this.Name = "SeeStudentInfo";
            this.Text = "SeeStudentInfo";
            this.Load += new System.EventHandler(this.SeeStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsLessons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox comboSelectStudent;
        private System.Windows.Forms.Label lblStudentName;
        public System.Windows.Forms.DataGridView dgvStudentsLessons;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}