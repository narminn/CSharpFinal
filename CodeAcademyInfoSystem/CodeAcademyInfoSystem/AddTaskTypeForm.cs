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
    public partial class AddTaskTypeForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Task_types selectedTaskType;
        public AddTaskTypeForm()
        {
            InitializeComponent();
        }

        private void AddTaskTypeForm_Load(object sender, EventArgs e)
        {
            fillDataTaskType();
        }

        private void add_tsktype_btn_Click(object sender, EventArgs e)
        {
            Task_types task_type = new Task_types();
            task_type.task_type_name = tsk_type.Text;
            task_type.task_type_rate = Convert.ToDouble(tsk_typ_rate.Text);
            db.Task_types.Add(task_type);
            db.SaveChanges();
            fillDataTaskType();
        }
        private void fillDataTaskType()
        {
            dataGridTaskType.Rows.Clear();
            int i = 0;
            List<Task_types> tsk_typ_list = db.Task_types.ToList();
            foreach (Task_types item in tsk_typ_list)
            {
                dataGridTaskType.Rows.Add();
                dataGridTaskType.Rows[i].Cells[0].Value = item.id;
                dataGridTaskType.Rows[i].Cells[1].Value = item.task_type_name;
                dataGridTaskType.Rows[i].Cells[2].Value = item.task_type_rate;
                i++;
            }
        }

        private void select_task_type(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridTaskType.Rows[e.RowIndex].Cells[0].Value);
            selectedTaskType = db.Task_types.Find(id);
            tsk_type.Text = selectedTaskType.task_type_name;
            tsk_typ_rate.Text = selectedTaskType.task_type_rate.ToString();
        }

        private void upd_tsktype_btn_Click(object sender, EventArgs e)
        {
            selectedTaskType.task_type_name = tsk_type.Text;
            selectedTaskType.task_type_rate = Convert.ToDouble(tsk_typ_rate.Text);
            
            db.SaveChanges();
            fillDataTaskType();
        }

        private void export_Tsktyp_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridTaskType);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
