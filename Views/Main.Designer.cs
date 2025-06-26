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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timetablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this.log);
            this.panel3.Controls.Add(this.close);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(674, 409);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 41);
            this.exit.TabIndex = 20;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Transparent;
            this.log.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.Black;
            this.log.Location = new System.Drawing.Point(705, 0);
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
            this.close.Location = new System.Drawing.Point(553, 409);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 41);
            this.close.TabIndex = 18;
            this.close.Text = "Close All";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.marksToolStripMenuItem,
            this.examsToolStripMenuItem,
            this.attendancesToolStripMenuItem,
            this.timetablesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentsToolStripMenuItem,
            this.studentsListToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.manageStudentsFormToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // addNewStudentsToolStripMenuItem
            // 
            this.addNewStudentsToolStripMenuItem.Name = "addNewStudentsToolStripMenuItem";
            this.addNewStudentsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addNewStudentsToolStripMenuItem.Text = "Add New Students";
            this.addNewStudentsToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentsToolStripMenuItem_Click);
            // 
            // studentsListToolStripMenuItem
            // 
            this.studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            this.studentsListToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.studentsListToolStripMenuItem.Text = "Students List";
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.staticsToolStripMenuItem.Text = "Statics";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // manageStudentsFormToolStripMenuItem
            // 
            this.manageStudentsFormToolStripMenuItem.Name = "manageStudentsFormToolStripMenuItem";
            this.manageStudentsFormToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.manageStudentsFormToolStripMenuItem.Text = "Manage Students Form";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // marksToolStripMenuItem
            // 
            this.marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            this.marksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.marksToolStripMenuItem.Text = "Marks";
            this.marksToolStripMenuItem.Click += new System.EventHandler(this.marksToolStripMenuItem_Click);
            // 
            // examsToolStripMenuItem
            // 
            this.examsToolStripMenuItem.Name = "examsToolStripMenuItem";
            this.examsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.examsToolStripMenuItem.Text = "Exams";
            this.examsToolStripMenuItem.Click += new System.EventHandler(this.examsToolStripMenuItem_Click);
            // 
            // attendancesToolStripMenuItem
            // 
            this.attendancesToolStripMenuItem.Name = "attendancesToolStripMenuItem";
            this.attendancesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.attendancesToolStripMenuItem.Text = "Attendances";
            this.attendancesToolStripMenuItem.Click += new System.EventHandler(this.attendancesToolStripMenuItem_Click);
            // 
            // timetablesToolStripMenuItem
            // 
            this.timetablesToolStripMenuItem.Name = "timetablesToolStripMenuItem";
            this.timetablesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.timetablesToolStripMenuItem.Text = "Timetables";
            this.timetablesToolStripMenuItem.Click += new System.EventHandler(this.timetablesToolStripMenuItem_Click);
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
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timetablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}