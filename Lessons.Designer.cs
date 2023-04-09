namespace OurClass
{
    partial class Lessons
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
            this.btnAddLessons = new System.Windows.Forms.Button();
            this.lblLessons = new System.Windows.Forms.Label();
            this.comboLesson = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddLessons
            // 
            this.btnAddLessons.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLessons.Location = new System.Drawing.Point(375, 135);
            this.btnAddLessons.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLessons.Name = "btnAddLessons";
            this.btnAddLessons.Size = new System.Drawing.Size(160, 39);
            this.btnAddLessons.TabIndex = 0;
            this.btnAddLessons.Text = "Add Lessons";
            this.btnAddLessons.UseVisualStyleBackColor = false;
            this.btnAddLessons.Click += new System.EventHandler(this.btnAddLessons_Click);
            // 
            // lblLessons
            // 
            this.lblLessons.BackColor = System.Drawing.SystemColors.Control;
            this.lblLessons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessons.Location = new System.Drawing.Point(212, 65);
            this.lblLessons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(139, 24);
            this.lblLessons.TabIndex = 1;
            this.lblLessons.Text = "Choose Lesson";
            this.lblLessons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLessons.Click += new System.EventHandler(this.lblLessons_Click);
            // 
            // comboLesson
            // 
            this.comboLesson.FormattingEnabled = true;
            this.comboLesson.Location = new System.Drawing.Point(375, 66);
            this.comboLesson.Name = "comboLesson";
            this.comboLesson.Size = new System.Drawing.Size(192, 24);
            this.comboLesson.TabIndex = 2;
            this.comboLesson.SelectedIndexChanged += new System.EventHandler(this.comboLesson_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(818, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboLesson);
            this.Controls.Add(this.lblLessons);
            this.Controls.Add(this.btnAddLessons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lessons";
            this.Text = "Lessons";
            this.Load += new System.EventHandler(this.Lessons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddLessons;
        private System.Windows.Forms.Label lblLessons;
        private System.Windows.Forms.ComboBox comboLesson;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}