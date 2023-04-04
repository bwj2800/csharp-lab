namespace CodeFirst
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_studentid = new System.Windows.Forms.TextBox();
            this.textBox_studentname = new System.Windows.Forms.TextBox();
            this.textBox_registeredon = new System.Windows.Forms.TextBox();
            this.textBox_phonenum = new System.Windows.Forms.TextBox();
            this.textBox_courseid = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.textBox_coursename = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTime_birth = new System.Windows.Forms.DateTimePicker();
            this.dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.button_addStudent = new System.Windows.Forms.Button();
            this.button_deleteStudent = new System.Windows.Forms.Button();
            this.button_editStudent = new System.Windows.Forms.Button();
            this.button_editCourse = new System.Windows.Forms.Button();
            this.button_deleteCourse = new System.Windows.Forms.Button();
            this.button_addCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Course Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Table";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code First Approach";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 356);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(571, 151);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(571, 153);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox_studentid
            // 
            this.textBox_studentid.Location = new System.Drawing.Point(730, 92);
            this.textBox_studentid.Name = "textBox_studentid";
            this.textBox_studentid.Size = new System.Drawing.Size(159, 25);
            this.textBox_studentid.TabIndex = 10;
            // 
            // textBox_studentname
            // 
            this.textBox_studentname.Location = new System.Drawing.Point(730, 123);
            this.textBox_studentname.Name = "textBox_studentname";
            this.textBox_studentname.Size = new System.Drawing.Size(159, 25);
            this.textBox_studentname.TabIndex = 11;
            // 
            // textBox_registeredon
            // 
            this.textBox_registeredon.Location = new System.Drawing.Point(730, 154);
            this.textBox_registeredon.Name = "textBox_registeredon";
            this.textBox_registeredon.Size = new System.Drawing.Size(159, 25);
            this.textBox_registeredon.TabIndex = 12;
            // 
            // textBox_phonenum
            // 
            this.textBox_phonenum.Location = new System.Drawing.Point(730, 186);
            this.textBox_phonenum.Name = "textBox_phonenum";
            this.textBox_phonenum.Size = new System.Drawing.Size(159, 25);
            this.textBox_phonenum.TabIndex = 13;
            // 
            // textBox_courseid
            // 
            this.textBox_courseid.Location = new System.Drawing.Point(725, 288);
            this.textBox_courseid.Name = "textBox_courseid";
            this.textBox_courseid.Size = new System.Drawing.Size(164, 25);
            this.textBox_courseid.TabIndex = 14;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(727, 356);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(162, 61);
            this.textBox_desc.TabIndex = 15;
            // 
            // textBox_coursename
            // 
            this.textBox_coursename.Location = new System.Drawing.Point(727, 320);
            this.textBox_coursename.Name = "textBox_coursename";
            this.textBox_coursename.Size = new System.Drawing.Size(162, 25);
            this.textBox_coursename.TabIndex = 16;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(727, 492);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(162, 25);
            this.textBox_price.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Student Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Registered On:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Birthday:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Course ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(618, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Description:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Course Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(618, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Start Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(618, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "End Date:";
            // 
            // dateTime_birth
            // 
            this.dateTime_birth.Location = new System.Drawing.Point(689, 217);
            this.dateTime_birth.Name = "dateTime_birth";
            this.dateTime_birth.Size = new System.Drawing.Size(200, 25);
            this.dateTime_birth.TabIndex = 30;
            // 
            // dateTime_start
            // 
            this.dateTime_start.Location = new System.Drawing.Point(701, 423);
            this.dateTime_start.Name = "dateTime_start";
            this.dateTime_start.Size = new System.Drawing.Size(188, 25);
            this.dateTime_start.TabIndex = 31;
            // 
            // dateTime_end
            // 
            this.dateTime_end.Location = new System.Drawing.Point(701, 457);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.Size = new System.Drawing.Size(188, 25);
            this.dateTime_end.TabIndex = 32;
            // 
            // button_addStudent
            // 
            this.button_addStudent.Location = new System.Drawing.Point(917, 92);
            this.button_addStudent.Name = "button_addStudent";
            this.button_addStudent.Size = new System.Drawing.Size(99, 46);
            this.button_addStudent.TabIndex = 33;
            this.button_addStudent.Text = "Add Student";
            this.button_addStudent.UseVisualStyleBackColor = true;
            this.button_addStudent.Click += new System.EventHandler(this.button_addStudent_Click);
            // 
            // button_deleteStudent
            // 
            this.button_deleteStudent.Location = new System.Drawing.Point(917, 196);
            this.button_deleteStudent.Name = "button_deleteStudent";
            this.button_deleteStudent.Size = new System.Drawing.Size(99, 46);
            this.button_deleteStudent.TabIndex = 34;
            this.button_deleteStudent.Text = "Delete Student";
            this.button_deleteStudent.UseVisualStyleBackColor = true;
            this.button_deleteStudent.Click += new System.EventHandler(this.button_deleteStudent_Click);
            // 
            // button_editStudent
            // 
            this.button_editStudent.Location = new System.Drawing.Point(917, 144);
            this.button_editStudent.Name = "button_editStudent";
            this.button_editStudent.Size = new System.Drawing.Size(99, 46);
            this.button_editStudent.TabIndex = 35;
            this.button_editStudent.Text = "Edit Student";
            this.button_editStudent.UseVisualStyleBackColor = true;
            this.button_editStudent.Click += new System.EventHandler(this.button_editStudent_Click);
            // 
            // button_editCourse
            // 
            this.button_editCourse.Location = new System.Drawing.Point(917, 423);
            this.button_editCourse.Name = "button_editCourse";
            this.button_editCourse.Size = new System.Drawing.Size(99, 46);
            this.button_editCourse.TabIndex = 38;
            this.button_editCourse.Text = "Edit Course";
            this.button_editCourse.UseVisualStyleBackColor = true;
            this.button_editCourse.Click += new System.EventHandler(this.button_editCourse_Click);
            // 
            // button_deleteCourse
            // 
            this.button_deleteCourse.Location = new System.Drawing.Point(917, 475);
            this.button_deleteCourse.Name = "button_deleteCourse";
            this.button_deleteCourse.Size = new System.Drawing.Size(99, 46);
            this.button_deleteCourse.TabIndex = 37;
            this.button_deleteCourse.Text = "Delete Course";
            this.button_deleteCourse.UseVisualStyleBackColor = true;
            this.button_deleteCourse.Click += new System.EventHandler(this.button_deleteCourse_Click);
            // 
            // button_addCourse
            // 
            this.button_addCourse.Location = new System.Drawing.Point(917, 371);
            this.button_addCourse.Name = "button_addCourse";
            this.button_addCourse.Size = new System.Drawing.Size(99, 46);
            this.button_addCourse.TabIndex = 36;
            this.button_addCourse.Text = "Add Course";
            this.button_addCourse.UseVisualStyleBackColor = true;
            this.button_addCourse.Click += new System.EventHandler(this.button_addCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 551);
            this.Controls.Add(this.button_editCourse);
            this.Controls.Add(this.button_deleteCourse);
            this.Controls.Add(this.button_addCourse);
            this.Controls.Add(this.button_editStudent);
            this.Controls.Add(this.button_deleteStudent);
            this.Controls.Add(this.button_addStudent);
            this.Controls.Add(this.dateTime_end);
            this.Controls.Add(this.dateTime_start);
            this.Controls.Add(this.dateTime_birth);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_coursename);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_courseid);
            this.Controls.Add(this.textBox_phonenum);
            this.Controls.Add(this.textBox_registeredon);
            this.Controls.Add(this.textBox_studentname);
            this.Controls.Add(this.textBox_studentid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_studentid;
        private System.Windows.Forms.TextBox textBox_studentname;
        private System.Windows.Forms.TextBox textBox_registeredon;
        private System.Windows.Forms.TextBox textBox_phonenum;
        private System.Windows.Forms.TextBox textBox_courseid;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.TextBox textBox_coursename;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTime_birth;
        private System.Windows.Forms.DateTimePicker dateTime_start;
        private System.Windows.Forms.DateTimePicker dateTime_end;
        private System.Windows.Forms.Button button_addStudent;
        private System.Windows.Forms.Button button_deleteStudent;
        private System.Windows.Forms.Button button_editStudent;
        private System.Windows.Forms.Button button_editCourse;
        private System.Windows.Forms.Button button_deleteCourse;
        private System.Windows.Forms.Button button_addCourse;
    }
}

