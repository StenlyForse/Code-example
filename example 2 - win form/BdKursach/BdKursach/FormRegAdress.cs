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
    public partial class FormRegAdress : Form
    {
        public FormRegAdress()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormRegAdress_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrationDataSet.Registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.registrationDataSet.Registration);

        }
    }
}
