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
    public partial class AddGroupTypeForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Group_types selectedGrpType;
        public AddGroupTypeForm()
        {
            InitializeComponent();
        }

        private void AddGroupTypeForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Group_schedule)
            {
                g_schedule.Items.Add(item.group_schedule_name);
            }
            fillDataGrpType();
        }

        private void add_gtype_btn_Click(object sender, EventArgs e)
        {
            int grp_id = db.Group_schedule.Where(g => g.group_schedule_name == g_schedule.Text).First().id;
            Group_types grp_type = new Group_types();
            grp_type.group_type_name = g_type.Text;
            grp_type.group_schedule_id = grp_id;
            db.Group_types.Add(grp_type);
            db.SaveChanges();
            fillDataGrpType();
        }
        private void fillDataGrpType()
        {
            dataGridGrpType.Rows.Clear();
            int i = 0;
            List<Group_types> grptyp_list = db.Group_types.ToList();
            foreach (Group_types item in grptyp_list)
            {
                dataGridGrpType.Rows.Add();
                dataGridGrpType.Rows[i].Cells[0].Value = item.id;
                dataGridGrpType.Rows[i].Cells[1].Value = item.group_type_name;
                dataGridGrpType.Rows[i].Cells[2].Value = item.Group_schedule.group_schedule_name;
                i++;
            }
        }

       

        private void select_grptype(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridGrpType.Rows[e.RowIndex].Cells[0].Value);
            selectedGrpType = db.Group_types.Find(id);
            g_type.Text = selectedGrpType.group_type_name;
            g_schedule.Text = selectedGrpType.Group_schedule.group_schedule_name;
        }
        private void upd_grptype_btn_Click(object sender, EventArgs e)
        {
            int grp_id = db.Group_schedule.Where(g => g.group_schedule_name == g_schedule.Text).First().id;
            
            selectedGrpType.group_type_name = g_type.Text;
            selectedGrpType.group_schedule_id = grp_id;
           
            db.SaveChanges();
            fillDataGrpType();
        }

        private void export_Grptype_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridGrpType);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
