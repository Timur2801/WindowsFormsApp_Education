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
    public partial class Uspev : Form
    {
        public Uspev()
        {
            InitializeComponent();
        }

        private void uspev_KhamidullinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uspev_KhamidullinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_KhamidullinDataSet);

        }

        private void Uspev_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_KhamidullinDataSet.Subjects_Khamidullin". При необходимости она может быть перемещена или удалена.
            this.subjects_KhamidullinTableAdapter.Fill(this.education_KhamidullinDataSet.Subjects_Khamidullin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_KhamidullinDataSet.Students_Khamidullin". При необходимости она может быть перемещена или удалена.
            this.students_KhamidullinTableAdapter.Fill(this.education_KhamidullinDataSet.Students_Khamidullin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_KhamidullinDataSet.Students_uspev". При необходимости она может быть перемещена или удалена.
            this.students_uspevTableAdapter.Fill(this.education_KhamidullinDataSet.Students_uspev);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_KhamidullinDataSet.Uspev_Khamidullin". При необходимости она может быть перемещена или удалена.
            this.uspev_KhamidullinTableAdapter.Fill(this.education_KhamidullinDataSet.Uspev_Khamidullin);

        }
    }
}
