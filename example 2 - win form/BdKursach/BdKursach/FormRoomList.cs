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
    public partial class FormRoomList : Form
    {
        public FormRoomList()
        {
            InitializeComponent();
        }

        private void FormRoomList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "room11DataSet.Room1". При необходимости она может быть перемещена или удалена.
            this.room1TableAdapter1.Fill(this.room11DataSet.Room1);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
