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
    
    public partial class MentorInfoform : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        public int id;
        private Mentor selectedMntr;
        public MentorInfoform()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            AboutGroupsForm abtgrp = new AboutGroupsForm();
            abtgrp.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            AboutStudentsForm abtstd = new AboutStudentsForm();

            abtstd.dataGridAboutStd.Rows.Clear();
            int i = 0;
            List<Student> std_list = db.Students.Where(d => d.Group.group_mentor_id == id).ToList();
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

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_pswrd_Click(object sender, EventArgs e)
        {
            panelPassword.Visible = true;
        }

        private void chng_pswr_btn_Click(object sender, EventArgs e)
        {
            int mntId = db.Mentors.Where(n => n.mentor_name == label_m_name.Text).First().id;
            selectedMntr = db.Mentors.Find(mntId);
            if (old_password.Text == selectedMntr.mentor_password)
            {
                selectedMntr.mentor_password = new_password.Text;
                db.SaveChanges();
            }
            else
            {
                wrong_psw.Visible = true;
            }
        }
    }
}
