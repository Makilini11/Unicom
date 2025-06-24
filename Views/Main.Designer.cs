namespace UnicomTICManagementSystem.Views
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.student = new System.Windows.Forms.Button();
            this.courses = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Button();
            this.marks = new System.Windows.Forms.Button();
            this.subjects = new System.Windows.Forms.Button();
            this.exam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.50133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.49867F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.exam, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.subjects, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.marks, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.time, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.courses, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.student, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // student
            // 
            this.student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student.Location = new System.Drawing.Point(3, 3);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(158, 101);
            this.student.TabIndex = 0;
            this.student.Text = "Students";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.button1_Click);
            // 
            // courses
            // 
            this.courses.Dock = System.Windows.Forms.DockStyle.Left;
            this.courses.Location = new System.Drawing.Point(167, 3);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(185, 101);
            this.courses.TabIndex = 1;
            this.courses.Text = "Courses";
            this.courses.UseVisualStyleBackColor = true;
            this.courses.Click += new System.EventHandler(this.courses_Click);
            // 
            // time
            // 
            this.time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time.Location = new System.Drawing.Point(3, 110);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(158, 101);
            this.time.TabIndex = 2;
            this.time.Text = "Timetables";
            this.time.UseVisualStyleBackColor = true;
            // 
            // marks
            // 
            this.marks.Dock = System.Windows.Forms.DockStyle.Left;
            this.marks.Location = new System.Drawing.Point(167, 110);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(185, 101);
            this.marks.TabIndex = 3;
            this.marks.Text = "Marks";
            this.marks.UseVisualStyleBackColor = true;
            // 
            // subjects
            // 
            this.subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjects.Location = new System.Drawing.Point(3, 217);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(158, 101);
            this.subjects.TabIndex = 4;
            this.subjects.Text = "Subjects";
            this.subjects.UseVisualStyleBackColor = true;
            // 
            // exam
            // 
            this.exam.Dock = System.Windows.Forms.DockStyle.Left;
            this.exam.Location = new System.Drawing.Point(167, 217);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(185, 101);
            this.exam.TabIndex = 5;
            this.exam.Text = "Exams";
            this.exam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 123);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rooms";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(377, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 450);
            this.panel2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(148, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(156, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 41);
            this.button3.TabIndex = 19;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this.log);
            this.panel3.Controls.Add(this.close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 450);
            this.panel3.TabIndex = 20;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(328, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(95, 41);
            this.log.TabIndex = 19;
            this.log.Text = "Logout";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Black;
            this.close.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(63, 374);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 41);
            this.close.TabIndex = 18;
            this.close.Text = "Close All";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(261, 374);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 41);
            this.exit.TabIndex = 20;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button marks;
        private System.Windows.Forms.Button time;
        private System.Windows.Forms.Button courses;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button exam;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}