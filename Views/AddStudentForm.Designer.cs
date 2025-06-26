namespace UnicomTICManagementSystem.Views
{
    partial class AddStudentForm
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
            this.exit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ln);
            this.panel1.Controls.Add(this.dob);
            this.panel1.Controls.Add(this.gen);
            this.panel1.Controls.Add(this.pn);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.photo);
            this.panel1.Controls.Add(this.name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(490, 352);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 41);
            this.exit.TabIndex = 22;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(608, 352);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 41);
            this.add.TabIndex = 21;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(581, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(216, 72);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(198, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 37);
            this.panel2.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(111, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 26);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(14, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(198, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.Location = new System.Drawing.Point(32, 64);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(108, 24);
            this.ln.TabIndex = 6;
            this.ln.Text = "Last Name";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(32, 101);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(132, 24);
            this.dob.TabIndex = 5;
            this.dob.Text = "Date Of Birth";
            // 
            // gen
            // 
            this.gen.AutoSize = true;
            this.gen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen.Location = new System.Drawing.Point(32, 157);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(76, 24);
            this.gen.TabIndex = 4;
            this.gen.Text = "Gender";
            // 
            // pn
            // 
            this.pn.AutoSize = true;
            this.pn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn.Location = new System.Drawing.Point(32, 208);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(144, 24);
            this.pn.TabIndex = 3;
            this.pn.Text = "Phone Number";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(473, 26);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(81, 24);
            this.address.TabIndex = 2;
            this.address.Text = "Address";
            // 
            // photo
            // 
            this.photo.AutoSize = true;
            this.photo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo.Location = new System.Drawing.Point(473, 121);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(64, 24);
            this.photo.TabIndex = 1;
            this.photo.Text = "Photo";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(32, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(110, 24);
            this.name.TabIndex = 0;
            this.name.Text = "First Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 188);
            this.dataGridView1.TabIndex = 23;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label gen;
        private System.Windows.Forms.Label pn;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label photo;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}