// Do not change this file

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Su24_Test
{
    public partial class Form1 : Form
    {
        // Declare a student list
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Student student in students)
            {
                dataGridView1.Rows.Add(student.ID, student.FullName, student.Phone, student.Email, student.CurrentCourses, student.PreviousCourses);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_id.Text);
            string fullName = tb_name.Text;
            string phone = tb_phone.Text;
            string email = tb_email.Text;
            string currentCourses = tb_cur_course.Text;
            string previousCourses = tb_pre_course.Text;

            Student student;

            if (string.IsNullOrEmpty(currentCourses) && string.IsNullOrEmpty(previousCourses))
            {
                student = new Student(id, fullName, phone, email);
            }
            else if (string.IsNullOrEmpty(currentCourses))
            {
                student = new Student(id, fullName, phone, email, previousCourses);
            }
            else if (string.IsNullOrEmpty(previousCourses))
            {
                student = new Student(id, fullName, phone, email, currentCourses, string.Empty);
            }
            else
            {
                student = new Student(id, fullName, phone, email, currentCourses, previousCourses);
            }

            students.Add(student);
            UpdateDataGridView();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                Student student = students.FirstOrDefault(s => s.ID == id);
                if (student != null)
                {
                    student.FullName = tb_name.Text;
                    student.Phone = tb_phone.Text;
                    student.Email = tb_email.Text;
                    student.CurrentCourses = tb_cur_course.Text;
                    student.PreviousCourses = tb_pre_course.Text;

                    UpdateDataGridView();
                }
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                Student student = students.FirstOrDefault(s => s.ID == id);
                if (student != null)
                {
                    students.Remove(student);
                    UpdateDataGridView();
                }
            }
        }

        private void bt_save_to_file_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"student.txt"))
            {
                foreach (Student student in students)
                {
                    file.WriteLine($"{student.ID},{student.FullName},{student.Phone},{student.Email},{student.CurrentCourses},{student.PreviousCourses}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"student.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"student.txt");
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    Student student = new Student
                    {
                        ID = int.Parse(data[0]),
                        FullName = data[1],
                        Phone = data[2],
                        Email = data[3],
                        CurrentCourses = data[4],
                        PreviousCourses = data[5]
                    };
                    students.Add(student);
                }
                UpdateDataGridView();
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                tb_id.Text = selectedRow.Cells[0].Value.ToString();
                tb_name.Text = selectedRow.Cells[1].Value.ToString();
                tb_phone.Text = selectedRow.Cells[2].Value.ToString();
                tb_email.Text = selectedRow.Cells[3].Value.ToString();
                tb_cur_course.Text = selectedRow.Cells[4].Value.ToString();
                tb_pre_course.Text = selectedRow.Cells[5].Value.ToString();
            }
        }
    }
}
