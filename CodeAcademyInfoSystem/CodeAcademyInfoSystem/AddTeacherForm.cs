using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodeAcademyInfoSystem
{
    public partial class AddTeacherForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        //OpenFileDialog img = new OpenFileDialog();
        private Teacher selectedTeacher;
        public string imgSource = "";
        public string imgName = "";
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Genders)
            {
                t_gender.Items.Add(item.gender_name);
            }
            fillDataTeachers();
        }
        private void browse_Click(object sender, EventArgs e)
        {
            //img.ShowDialog();
            //this.pictureBox1.Image = Image.FromFile(img.FileName);
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                imgSource = f.FileName;
                pictureBox1.ImageLocation = f.FileName;
                imgName = DateTime.Now.ToString("yyyyMMddssHHmm") + f.SafeFileName;
            }
        }

        private void t_add_btn_Click(object sender, EventArgs e)
        {
            //string imageName = DateTime.Now.ToString("yyyyMMddssHHmm") + img.SafeFileName;
            //WebClient webclient = new WebClient();
            //string path = @"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + imageName;
            //webclient.DownloadFile(img.FileName, path);
            File.Copy(imgSource, @"../../Images/" + imgName);

            int gender_id = db.Genders.Where(g => g.gender_name == t_gender.Text).First().id;
            Teacher tch = new Teacher();
            tch.teacher_name = t_name.Text;
            tch.teacher_surname = t_surname.Text;
            tch.teacher_gender_id = gender_id;
            tch.teacher_phone = t_phone.Text;
            tch.teacher_email = t_email.Text;
            tch.teacher_password = t_password.Text;
            tch.teacher_info = t_info.Text;
            tch.teacher_photo= imgName;
           
           
            db.Teachers.Add(tch);
            db.SaveChanges();
            fillDataTeachers();
        }
        private void fillDataTeachers()
        {
            dataGridTeacher.Rows.Clear();
            int i = 0;
            List<Teacher> tchr_list = db.Teachers.ToList();
            foreach (Teacher item in tchr_list)
            {
                dataGridTeacher.Rows.Add();
                dataGridTeacher.Rows[i].Cells[0].Value = item.id;
                dataGridTeacher.Rows[i].Cells[1].Value = item.teacher_name;
                dataGridTeacher.Rows[i].Cells[2].Value = item.teacher_surname;
                dataGridTeacher.Rows[i].Cells[3].Value = item.Gender.gender_name;
                dataGridTeacher.Rows[i].Cells[4].Value = item.teacher_phone;
                dataGridTeacher.Rows[i].Cells[5].Value = item.teacher_email;
                dataGridTeacher.Rows[i].Cells[6].Value = item.teacher_info;
                i++;
            }
        }

        private void select_teacher(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridTeacher.Rows[e.RowIndex].Cells[0].Value);
            selectedTeacher = db.Teachers.Find(id);
            t_name.Text = selectedTeacher.teacher_name;
            t_surname.Text = selectedTeacher.teacher_surname;
            t_gender.Text = selectedTeacher.Gender.gender_name;
            t_phone.Text = selectedTeacher.teacher_phone;
            t_email.Text = selectedTeacher.teacher_email;
            t_password.Text = selectedTeacher.teacher_password;
            t_info.Text = selectedTeacher.teacher_info;
            //pictureBox1.Image = Image.FromFile(selectedTeacher.teacher_photo);
        }

        private void t_show_btn_Click(object sender, EventArgs e)
        {
            TeacherInfoForm tchInfo = new TeacherInfoForm();
            tchInfo.label_t_name.Text = selectedTeacher.teacher_name;
            tchInfo.label_t_surname.Text = selectedTeacher.teacher_surname;
            tchInfo.label_t_gender.Text = selectedTeacher.Gender.gender_name;
            tchInfo.label_t_phone.Text = selectedTeacher.teacher_phone;
            tchInfo.label_t_email.Text = selectedTeacher.teacher_email;
            tchInfo.label_t_info.Text = selectedTeacher.teacher_info;
            Image image = Image.FromFile(@"../../Images/" + selectedTeacher.teacher_photo);
            
            tchInfo.pictureBoxTeacher.Image = image;
            tchInfo.ShowDialog();
        }

        private void t_update_btn_Click(object sender, EventArgs e)
        {
            int gender_id = db.Genders.Where(g => g.gender_name == t_gender.Text).First().id;
            
            selectedTeacher.teacher_name = t_name.Text;
            selectedTeacher.teacher_surname = t_surname.Text;
            selectedTeacher.teacher_gender_id = gender_id;
            selectedTeacher.teacher_phone = t_phone.Text;
            selectedTeacher.teacher_email = t_email.Text;
            selectedTeacher.teacher_password = t_password.Text;
            selectedTeacher.teacher_info = t_info.Text;
            db.SaveChanges();
            fillDataTeachers();
        }

        private void t_delete_btn_Click(object sender, EventArgs e)
        {
            db.Teachers.Remove(selectedTeacher);
            db.SaveChanges();
            fillDataTeachers();
        }

        private void export_teacher_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridTeacher);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
