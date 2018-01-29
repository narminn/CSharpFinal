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
    public partial class AboutMentorForm : Form
    {
       
        public AboutMentorForm()
        {
            InitializeComponent();
        }

        private void AboutMentorForm_Load(object sender, EventArgs e)
        {
        }

        private void export_abt_mnt_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridAboutMentor);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
