using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademyInfoSystem
{
    public partial class TeacherInfoForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        public int id;
        private Teacher selectedTchr;
        public TeacherInfoForm()
        {
            InitializeComponent();
        }

        private void add_task_Click(object sender, EventArgs e)
        {
            TaskForm tskfrm = new TaskForm();
            tskfrm.ShowDialog();
            
        }

        private void about_mentor_Click(object sender, EventArgs e)
        {
            AboutMentorForm abtmnt = new AboutMentorForm();
            abtmnt.dataGridAboutMentor.Rows.Clear();
            int i = 0;
            List<Mentor> mnt_list = db.Mentors.ToList();
            foreach (Mentor item in mnt_list)
            {
                abtmnt.dataGridAboutMentor.Rows.Add();
                abtmnt.dataGridAboutMentor.Rows[i].Cells[0].Value = item.id;
                abtmnt.dataGridAboutMentor.Rows[i].Cells[1].Value = item.mentor_name;
                abtmnt.dataGridAboutMentor.Rows[i].Cells[2].Value = item.mentor_surname;
                abtmnt.dataGridAboutMentor.Rows[i].Cells[3].Value = item.Gender.gender_name;
                abtmnt.dataGridAboutMentor.Rows[i].Cells[4].Value = item.mentor_phone;
                abtmnt.dataGridAboutMentor.Rows[i].Cells[5].Value = item.mentor_email;
                abtmnt.dataGridAboutMentor.Rows[i].Cells[6].Value = item.mentor_info;
                i++;
            }
            abtmnt.ShowDialog();

        }

        private void about_student_Click(object sender, EventArgs e)
        {
            AboutStudentsForm abtstd = new AboutStudentsForm();
           
            abtstd.dataGridAboutStd.Rows.Clear();
            int i = 0;
            List<Student> std_list = db.Students.Where(d=>d.Group.group_techer_id==id).ToList();
            foreach (Student selectedStnd in std_list)
            {

                abtstd.dataGridAboutStd.Rows.Add();
                abtstd.dataGridAboutStd.Rows[i].Cells[0].Value = selectedStnd.id;
                abtstd.dataGridAboutStd.Rows[i].Cells[1].Value = selectedStnd.student_surname;
                abtstd.dataGridAboutStd.Rows[i].Cells[2].Value = selectedStnd.student_name;
                abtstd.dataGridAboutStd.Rows[i].Cells[3].Value = selectedStnd.Gender.gender_name;
                abtstd.dataGridAboutStd.Rows[i].Cells[4].Value = selectedStnd.Group.group_name;
                abtstd.dataGridAboutStd.Rows[i].Cells[5].Value = selectedStnd.student_phone;
                abtstd.dataGridAboutStd.Rows[i].Cells[6].Value = selectedStnd.student_email;
                abtstd.dataGridAboutStd.Rows[i].Cells[7].Value = selectedStnd.student_github_account;
                abtstd.dataGridAboutStd.Rows[i].Cells[8].Value = selectedStnd.student_cap_point;
                abtstd.dataGridAboutStd.Rows[i].Cells[9].Value = selectedStnd.student_info;
                i++;
            }
            
            abtstd.ShowDialog();
        }

        private void about_group_Click(object sender, EventArgs e)
        {
            AboutGroupsForm abtgrp = new AboutGroupsForm();
            abtgrp.dataGridAboutGrp.Rows.Clear();
            int i = 0;
            List<Group> mnt_list = db.Groups.ToList();
            foreach (Group item in mnt_list)
            {
                abtgrp.dataGridAboutGrp.Rows.Add();
                abtgrp.dataGridAboutGrp.Rows[i].Cells[0].Value = item.id;
                abtgrp.dataGridAboutGrp.Rows[i].Cells[1].Value = item.group_name;
                abtgrp.dataGridAboutGrp.Rows[i].Cells[2].Value = item.Group_types.group_type_name;
                abtgrp.dataGridAboutGrp.Rows[i].Cells[3].Value = item.Teacher.teacher_name;
                abtgrp.dataGridAboutGrp.Rows[i].Cells[4].Value = item.Mentor.mentor_name;
                abtgrp.dataGridAboutGrp.Rows[i].Cells[5].Value = item.group_start_date;
                i++;
            }
            abtgrp.ShowDialog();
        }

        private void add_task_type_Click(object sender, EventArgs e)
        {
            AddTaskTypeForm addtsktype = new AddTaskTypeForm();

            addtsktype.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_pswrd_Click(object sender, EventArgs e)
        {
            panelPassword.Visible = true;
        }

        private void chng_pswr_btn_Click(object sender, EventArgs e)
        {
            int tchId = db.Teachers.Where(c=>c.teacher_name == label_t_name.Text).First().id;
            selectedTchr = db.Teachers.Find(tchId);
            if (old_password.Text == selectedTchr.teacher_password)
            {
                selectedTchr.teacher_password = new_password.Text;
                db.SaveChanges();
            }
            else
            {
                wrong_psw.Visible = true;
            }
        }
    }
}
