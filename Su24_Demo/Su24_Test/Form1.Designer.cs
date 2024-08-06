namespace Su24_Test
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cur_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cur_course = new System.Windows.Forms.TextBox();
            this.tb_pre_course = new System.Windows.Forms.TextBox();
            this.label_cur_course = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_save_to_file = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 58;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.full_name,
            this.Phone,
            this.Email,
            this.cur_course,
            this.pre_course});
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1554, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.Width = 95;
            // 
            // full_name
            // 
            this.full_name.HeaderText = "Full Name";
            this.full_name.MinimumWidth = 12;
            this.full_name.Name = "full_name";
            this.full_name.Width = 197;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 12;
            this.Phone.Name = "Phone";
            this.Phone.Width = 151;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 12;
            this.Email.Name = "Email";
            this.Email.Width = 140;
            // 
            // cur_course
            // 
            this.cur_course.HeaderText = "Current Course";
            this.cur_course.MinimumWidth = 12;
            this.cur_course.Name = "cur_course";
            this.cur_course.Width = 260;
            // 
            // pre_course
            // 
            this.pre_course.HeaderText = "Previous Course";
            this.pre_course.MinimumWidth = 12;
            this.pre_course.Name = "pre_course";
            this.pre_course.Width = 277;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(33, 123);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(271, 38);
            this.tb_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(32, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(31, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(33, 226);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(271, 38);
            this.tb_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(338, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telephone";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(344, 123);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(261, 38);
            this.tb_phone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(342, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(344, 226);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(261, 38);
            this.tb_email.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_cur_course);
            this.groupBox1.Controls.Add(this.tb_pre_course);
            this.groupBox1.Controls.Add(this.label_cur_course);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 264);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Previous Course";
            // 
            // tb_cur_course
            // 
            this.tb_cur_course.Location = new System.Drawing.Point(629, 99);
            this.tb_cur_course.Name = "tb_cur_course";
            this.tb_cur_course.Size = new System.Drawing.Size(261, 38);
            this.tb_cur_course.TabIndex = 11;
            // 
            // tb_pre_course
            // 
            this.tb_pre_course.Location = new System.Drawing.Point(629, 202);
            this.tb_pre_course.Name = "tb_pre_course";
            this.tb_pre_course.Size = new System.Drawing.Size(261, 38);
            this.tb_pre_course.TabIndex = 13;
            // 
            // label_cur_course
            // 
            this.label_cur_course.AutoSize = true;
            this.label_cur_course.Location = new System.Drawing.Point(627, 60);
            this.label_cur_course.Name = "label_cur_course";
            this.label_cur_course.Size = new System.Drawing.Size(206, 32);
            this.label_cur_course.TabIndex = 12;
            this.label_cur_course.Text = "Current Course";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.bt_save_to_file);
            this.groupBox2.Controls.Add(this.bt_delete);
            this.groupBox2.Controls.Add(this.bt_edit);
            this.groupBox2.Controls.Add(this.bt_add);
            this.groupBox2.Location = new System.Drawing.Point(1045, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 264);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // bt_save_to_file
            // 
            this.bt_save_to_file.Location = new System.Drawing.Point(250, 162);
            this.bt_save_to_file.Name = "bt_save_to_file";
            this.bt_save_to_file.Size = new System.Drawing.Size(212, 57);
            this.bt_save_to_file.TabIndex = 12;
            this.bt_save_to_file.Text = "Save";
            this.bt_save_to_file.UseVisualStyleBackColor = true;
            this.bt_save_to_file.Click += new System.EventHandler(this.bt_save_to_file_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(23, 162);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(212, 57);
            this.bt_delete.TabIndex = 12;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(250, 70);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(212, 57);
            this.bt_edit.TabIndex = 11;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(23, 70);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(212, 57);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 890);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Su24-Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_save_to_file;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cur_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_course;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cur_course;
        private System.Windows.Forms.TextBox tb_pre_course;
        private System.Windows.Forms.Label label_cur_course;
    }
}

