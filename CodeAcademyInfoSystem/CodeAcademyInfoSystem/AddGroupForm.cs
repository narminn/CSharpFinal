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

    public partial class AddGroupForm : Form
    {

        private CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Group selectedGroup;
        public AddGroupForm()
        {
            InitializeComponent();

        }

        private void AddGroupForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Group_types.ToList())
            {
                g_type.Items.Add(item.group_type_name);
            }
            foreach (var item in db.Teachers.ToList())
            {
                g_teacher.Items.Add(item.teacher_name);
            }
            foreach (var item in db.Mentors.ToList())
            {
                g_mentor.Items.Add(item.mentor_name);
            }
            fillDataGroups();
        }

        private void g_add_btn_Click(object sender, EventArgs e)
        {
            int group_id = db.Group_types.Where(g => g.group_type_name == g_type.Text).First().id;
            int teacher_id = db.Teachers.Where(t => t.teacher_name == g_teacher.Text).First().id;
            int mentor_id = db.Mentors.Where(m => m.mentor_name == g_mentor.Text).First().id;
            Group grp = new Group();
            grp.group_name = g_name.Text;
            grp.group_type_id = group_id;
            grp.group_techer_id = teacher_id;
            grp.group_mentor_id = mentor_id;
            grp.group_start_date = g_start_data.Value;
            db.Groups.Add(grp);
            db.SaveChanges();
            fillDataGroups();
        }
        private void fillDataGroups()
        {
            dataGridGroup.Rows.Clear();
            int i = 0;
            List<Group> mnt_list = db.Groups.ToList();
            foreach (Group item in mnt_list)
            {
                dataGridGroup.Rows.Add();
                dataGridGroup.Rows[i].Cells[0].Value = item.id;
                dataGridGroup.Rows[i].Cells[1].Value = item.group_name;
                dataGridGroup.Rows[i].Cells[2].Value = item.Group_types.group_type_name;
                dataGridGroup.Rows[i].Cells[3].Value = item.Teacher.teacher_name;
                dataGridGroup.Rows[i].Cells[4].Value = item.Mentor.mentor_name;
                dataGridGroup.Rows[i].Cells[5].Value = item.group_start_date.ToShortDateString();
                i++;
            }
        }

        

        private void select_group(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridGroup.Rows[e.RowIndex].Cells[0].Value);
            selectedGroup = db.Groups.Find(id);
            g_name.Text = selectedGroup.group_name;
            g_type.Text = selectedGroup.Group_types.group_type_name;
            g_teacher.Text = selectedGroup.Teacher.teacher_name;
            g_mentor.Text = selectedGroup.Mentor.mentor_name;
            g_start_data.Value = selectedGroup.group_start_date;
        }
        private void t_update_btn_Click(object sender, EventArgs e)
        {
            int group_id = db.Group_types.Where(g => g.group_type_name == g_type.Text).First().id;
            int teacher_id = db.Teachers.Where(t => t.teacher_name == g_teacher.Text).First().id;
            int mentor_id = db.Mentors.Where(m => m.mentor_name == g_mentor.Text).First().id;

            selectedGroup.group_name = g_name.Text;
            selectedGroup.group_type_id = group_id;
            selectedGroup.group_techer_id = teacher_id;
            selectedGroup.group_mentor_id = mentor_id;
            selectedGroup.group_start_date = g_start_data.Value;

            db.SaveChanges();
            fillDataGroups();
        }

        private void t_delete_btn_Click(object sender, EventArgs e)
        {
            db.Groups.Remove(selectedGroup);
            db.SaveChanges();
            fillDataGroups();
        }

        private void export_group_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridGroup);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
