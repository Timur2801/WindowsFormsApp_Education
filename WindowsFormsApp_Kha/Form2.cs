using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Kha
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_KhamidullinDataSet.Students_Khamidullin". При необходимости она может быть перемещена или удалена.
            this.students_KhamidullinTableAdapter.Fill(this.education_KhamidullinDataSet.Students_Khamidullin);

        }

        private void students_KhamidullinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.students_KhamidullinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_KhamidullinDataSet);

        }

        private StudentsTable studentstable;

        private void button1_Click(object sender, EventArgs e)
        {
            studentstable = new StudentsTable();
            studentstable.Visible = true;
        }

        
    }
}
