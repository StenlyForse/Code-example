using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdKursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        v stdadd = new v();
        FormRoomAdd rmadd = new FormRoomAdd();          // формы
        FormStudList stdlist = new FormStudList();
        FormRegAdress regadr = new FormRegAdress();
        FormStudCat stdcat = new FormStudCat();
        FormDormList drmlist = new FormDormList();
        FormRoomList rmlist = new FormRoomList();

        
        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StudAdd_Click(object sender, EventArgs e)
        {
            stdadd.ShowDialog();
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            rmadd.ShowDialog();
        }

        private void StudList_Click(object sender, EventArgs e)
        {
            stdlist.ShowDialog();
        }

        private void RegAgress_Click(object sender, EventArgs e)
        {
            regadr.ShowDialog();
        }

        private void StudCateg_Click(object sender, EventArgs e)
        {
            stdcat.ShowDialog();
        }

        private void DormList_Click(object sender, EventArgs e)
        {
            drmlist.ShowDialog();
        }

        private void RoomList_Click(object sender, EventArgs e)
        {
            rmlist.ShowDialog();
        }

        private void ExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
