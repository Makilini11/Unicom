namespace UnicomTICManagementSystem.Views
{
    partial class AttendenceForm
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
            this.textusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textusername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(227, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 165);
            this.panel1.TabIndex = 2;
            // 
            // textusername
            // 
            this.textusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusername.Location = new System.Drawing.Point(125, 18);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(159, 29);
            this.textusername.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(0, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(108, 26);
            this.username.TabIndex = 4;
            this.username.Text = "Student ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // AttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AttendenceForm";
            this.Text = "AttendenceForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}