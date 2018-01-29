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
    public partial class TaskForm : Form
       
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Task selectedTask;
        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Task_types)
            {
                task_type.Items.Add(item.task_type_name);
            }
            foreach (var item in db.Groups)
            {
                task_group.Items.Add(item.group_name);
            }
            foreach (var item in db.Students)

            {
                task_stdt.Items.Add(item.student_name);
            }
            fillDataTasks();
        }

        private void add_task_btn_Click(object sender, EventArgs e)
        {
            int tsk_type_id = db.Task_types.Where(t => t.task_type_name == task_type.Text).First().id;
            int tsk_group_id = db.Groups.Where(g => g.group_name == task_group.Text).First().id;
            int tsk_student_id = db.Students.Where(s => s.student_name == task_stdt.Text).First().id;
            Task tsk = new Task();
            tsk.task_type_id = tsk_type_id;
            tsk.task_start_date = dateTimeStart.Value;
            tsk.task_end_date = dateTimeEnd.Value;
            tsk.task_group_id = tsk_group_id;
            tsk.task_student_id = tsk_student_id;
            tsk.task_source = task_src.Text;
            tsk.task_point=Convert.ToDouble(task_pnt.Text);
            tsk.task_note = task_note.Text;
            db.Tasks.Add(tsk);
            db.SaveChanges();
            fillDataTasks();

        }
        private void fillDataTasks()
        {
            dataGridTask.Rows.Clear();
            int i = 0;
            List<Task> tsk_list = db.Tasks.ToList();
            foreach (Task item in tsk_list)
            {
                dataGridTask.Rows.Add();
                dataGridTask.Rows[i].Cells[0].Value = item.id;
                dataGridTask.Rows[i].Cells[1].Value = item.Task_types.task_type_name;
                dataGridTask.Rows[i].Cells[2].Value = item.task_start_date.ToShortDateString();
                dataGridTask.Rows[i].Cells[3].Value = item.task_end_date.ToShortDateString();
                dataGridTask.Rows[i].Cells[4].Value = item.task_source;
                dataGridTask.Rows[i].Cells[5].Value = item.Group.group_name;
                dataGridTask.Rows[i].Cells[6].Value = item.Student.student_name;
                dataGridTask.Rows[i].Cells[7].Value = item.task_point;
                dataGridTask.Rows[i].Cells[8].Value = item.task_note;
                dataGridTask.Rows[i].Cells[9].Value = item.task_point * item.Task_types.task_type_rate;
                i++;
            }
        }

        private void select_task(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridTask.Rows[e.RowIndex].Cells[0].Value);
            selectedTask = db.Tasks.Find(id);
            task_type.Text = selectedTask.Task_types.task_type_name;
            dateTimeStart.Value = selectedTask.task_start_date;
            dateTimeEnd.Value = selectedTask.task_end_date;
            task_group.Text = selectedTask.Group.group_name;
            task_stdt.Text = selectedTask.Student.student_name;
            task_src.Text = selectedTask.task_source;
            task_pnt.Text = selectedTask.task_point.ToString();
            task_note.Text = selectedTask.task_note;

        }

      

        private void task_update_Click(object sender, EventArgs e)
        {
            int tsk_type_id = db.Task_types.Where(t => t.task_type_name == task_type.Text).First().id;
            int tsk_group_id = db.Groups.Where(g => g.group_name == task_group.Text).First().id;
            int tsk_student_id = db.Students.Where(s => s.student_name == task_stdt.Text).First().id;
            
            selectedTask.task_type_id = tsk_type_id;
            selectedTask.task_start_date = dateTimeStart.Value;
            selectedTask.task_end_date = dateTimeEnd.Value;
            selectedTask.task_group_id = tsk_group_id;
            selectedTask.task_student_id = tsk_student_id;
            selectedTask.task_source = task_src.Text;
            selectedTask.task_point = Convert.ToDouble(task_pnt.Text);
            selectedTask.task_note = task_note.Text;
            
            db.SaveChanges();
            fillDataTasks();
        }

        private void task_delete_Click(object sender, EventArgs e)
        {
            db.Tasks.Remove(selectedTask);
            db.SaveChanges();
            fillDataTasks();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            exportExcel(dataGridTask);
        }
        public void exportExcel(DataGridView _table)
        {
            // creating Excel Application 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < _table.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = _table.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < _table.Rows.Count; i++)
            {
                for (int j = 0; j < _table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = _table.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

       

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
