using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdKursach
{
    public partial class FormDormList : Form
    {
        public FormDormList()
        {
            InitializeComponent();
        }

        private void FormDormList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "firstDataSet.Dormitory". При необходимости она может быть перемещена или удалена.
            this.dormitoryTableAdapter.Fill(this.firstDataSet.Dormitory);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
