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
    public partial class AboutGroupsForm : Form
        
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();

        public AboutGroupsForm()
        {
            InitializeComponent();
        }

        private void AboutGroupsForm_Load(object sender, EventArgs e)
        {
            fillDataAboutGrp();
        }
        private void fillDataAboutGrp()
        {
            dataGridAboutGrp.Rows.Clear();
            int i = 0;
            List<Group> mnt_list = db.Groups.ToList();
            foreach (Group item in mnt_list)
            {
                dataGridAboutGrp.Rows.Add();
                dataGridAboutGrp.Rows[i].Cells[0].Value = item.id;
                dataGridAboutGrp.Rows[i].Cells[1].Value = item.group_name;
                dataGridAboutGrp.Rows[i].Cells[2].Value = item.Group_types.group_type_name;
                dataGridAboutGrp.Rows[i].Cells[3].Value = item.Teacher.teacher_name;
                dataGridAboutGrp.Rows[i].Cells[4].Value = item.Mentor.mentor_name;
                dataGridAboutGrp.Rows[i].Cells[5].Value = item.group_start_date.ToShortDateString();
                i++;
            }
        }

        private void export_abt_grp_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridAboutGrp);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
