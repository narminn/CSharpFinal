using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademyInfoSystem
{
    public partial class AddMentorForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        public string imgSource = "";
        public string imgName = "";
        private Mentor selectedMentor;
        public AddMentorForm()
        {
            InitializeComponent();
        }

        private void AddMentorForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Genders)
            {
                m_gender.Items.Add(item.gender_name);
            }
            fillDataMentors();
        }

        private void browse_m_Click(object sender, EventArgs e)
        {
            //img.ShowDialog();
            //this.pictureBox2.Image = Image.FromFile(img.FileName);
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                imgSource = f.FileName;
                pictureBox2.ImageLocation = f.FileName;
                imgName = DateTime.Now.ToString("yyyyMMddssHHmm") + f.SafeFileName;
            }
        }

        private void m_add_btn_Click(object sender, EventArgs e)
        {
            //string imageName = DateTime.Now.ToString("yyyyMMddssHHmm") + img.SafeFileName;
            //WebClient webclient = new WebClient();
            //string path = @"C:\Users\Dr.Rashad\Desktop\Forza_N_R\CodeAcademyInfoSystem\CodeAcademyInfoSystem\Upload\" + imageName;
            //webclient.DownloadFile(img.FileName, path);
            File.Copy(imgSource, @"../../Images/" + imgName);
            int gender_id = db.Genders.Where(g => g.gender_name == m_gender.Text).First().id;
            Mentor mnt = new Mentor();
            mnt.mentor_name = m_name.Text;
            mnt.mentor_surname = m_surname.Text;
            mnt.mentor_gender_id = gender_id;
            mnt.mentor_phone = m_phone.Text;
            mnt.mentor_email = m_email.Text;
            mnt.mentor_password = m_password.Text;
            mnt.mentor_info = m_info.Text;
            mnt.mentor_photo = imgName;


            db.Mentors.Add(mnt);
            db.SaveChanges();
            fillDataMentors();
        }
        private void fillDataMentors()
        {
            dataGridMentor.Rows.Clear();
            int i = 0;
            List<Mentor> mnt_list = db.Mentors.ToList();
            foreach (Mentor item in mnt_list)
            {
                dataGridMentor.Rows.Add();
                dataGridMentor.Rows[i].Cells[0].Value = item.id;
                dataGridMentor.Rows[i].Cells[1].Value = item.mentor_name;
                dataGridMentor.Rows[i].Cells[2].Value = item.mentor_surname;
                dataGridMentor.Rows[i].Cells[3].Value = item.Gender.gender_name;
                dataGridMentor.Rows[i].Cells[4].Value = item.mentor_phone;
                dataGridMentor.Rows[i].Cells[5].Value = item.mentor_email;
                dataGridMentor.Rows[i].Cells[6].Value = item.mentor_info;
                i++;
            }
        }

        private void select_mentor(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridMentor.Rows[e.RowIndex].Cells[0].Value);
            selectedMentor = db.Mentors.Find(id);
            m_name.Text = selectedMentor.mentor_name;
            m_surname.Text = selectedMentor.mentor_surname;
            m_gender.Text = selectedMentor.Gender.gender_name;
            m_phone.Text = selectedMentor.mentor_phone;
            m_email.Text = selectedMentor.mentor_email;
            m_password.Text = selectedMentor.mentor_password;
            m_info.Text = selectedMentor.mentor_info;

            
        }

        private void m_show_btn_Click(object sender, EventArgs e)
        {
            MentorInfoform mntInfo = new MentorInfoform();
            mntInfo.label_m_name.Text = selectedMentor.mentor_name;
            mntInfo.label_m_surname.Text = selectedMentor.mentor_surname;
            mntInfo.label_m_gender.Text = selectedMentor.Gender.gender_name;
            mntInfo.label_m_phone.Text = selectedMentor.mentor_phone;
            mntInfo.label_m_email.Text = selectedMentor.mentor_email;
            mntInfo.label_m_info.Text = selectedMentor.mentor_info;
            Image image = Image.FromFile(@"../../Images/" + selectedMentor.mentor_photo);
            mntInfo.pictureBoxMentor.Image = image;
            mntInfo.ShowDialog();
        }

        private void m_update_btn_Click(object sender, EventArgs e)
        {
            int gndr_id = db.Genders.Where(n => n.gender_name == m_gender.Text).First().id;

            selectedMentor.mentor_name = m_name.Text;
            selectedMentor.mentor_surname = m_surname.Text;
            selectedMentor.mentor_gender_id = gndr_id;
            selectedMentor.mentor_phone = m_phone.Text;
            selectedMentor.mentor_email = m_email.Text;
            selectedMentor.mentor_password = m_password.Text;
            selectedMentor.mentor_info = m_info.Text;

           
            db.SaveChanges();
            fillDataMentors();
        }

        private void m_delete_btn_Click(object sender, EventArgs e)
        {
            db.Mentors.Remove(selectedMentor);
            db.SaveChanges();
            fillDataMentors();
        }

        private void export_Mentor_btn_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
