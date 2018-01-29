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
    public partial class AboutTeacherForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Teacher selectedAboutTeacher;
        public AboutTeacherForm()
        {
            InitializeComponent();
        }

        private void AboutTeacherForm_Load(object sender, EventArgs e)
        {
            fillDataAboutTeacher();
        }
        private void fillDataAboutTeacher()
        {
            dataGridAboutTeacher.Rows.Clear();
            int i = 0;
            List<Teacher> tchr_list = db.Teachers.ToList();
            foreach (Teacher item in tchr_list)
            {
                dataGridAboutTeacher.Rows.Add();
                dataGridAboutTeacher.Rows[i].Cells[0].Value = item.id;
                dataGridAboutTeacher.Rows[i].Cells[1].Value = item.teacher_name;
                dataGridAboutTeacher.Rows[i].Cells[2].Value = item.teacher_surname;
                dataGridAboutTeacher.Rows[i].Cells[3].Value = item.Gender.gender_name;
                dataGridAboutTeacher.Rows[i].Cells[4].Value = item.teacher_phone;
                dataGridAboutTeacher.Rows[i].Cells[5].Value = item.teacher_email;
                dataGridAboutTeacher.Rows[i].Cells[6].Value = item.teacher_info;
                i++;
            }
        }

        private void export_abt_tch_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridAboutTeacher);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
