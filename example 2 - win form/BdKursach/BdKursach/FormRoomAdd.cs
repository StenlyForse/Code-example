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
    public partial class FormRoomAdd : Form
    {
        string[] RoomTypeArr = { "Коридорный", "Блочный" };
        public FormRoomAdd()
        {
            InitializeComponent();
            RoomTypeCombo.Items.AddRange(RoomTypeArr);
        }

        SqlConnection sqlConnection;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private async void FormRoomAdd_Load(object sender, EventArgs e)
        {
            string connectoinString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\BdKursach\BdKursach\First.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectoinString);

            await sqlConnection.OpenAsync();
        }


        private async void RoomAddButton_Click(object sender, EventArgs e)
        {
            SqlCommand commandRoom = new SqlCommand("INSERT INTO[Room1](RoomNum,LiverAmount,RoomType,Repair,Refregirator,Meters)VALUES(@RoomNum,@LiverAmount,@RoomType,@Repair,@Refregirator,@Meters) ",sqlConnection);


            if (!string.IsNullOrEmpty(RoomNumText.Text)&&!string.IsNullOrWhiteSpace(RoomNumText.Text)&&
                !string.IsNullOrEmpty(LiversAmountText.Text)&&!string.IsNullOrWhiteSpace(LiversAmountText.Text)&&
                !string.IsNullOrEmpty(Meters.Text)&&!string.IsNullOrWhiteSpace(Meters.Text)&&
                RoomTypeCombo.SelectedItem!=null)
            {
                commandRoom.Parameters.AddWithValue("@RoomNum", RoomNumText.Text);
                commandRoom.Parameters.AddWithValue("@LiverAmount", LiversAmountText.Text);
                commandRoom.Parameters.AddWithValue("@Meters", Meters.Text);
                commandRoom.Parameters.AddWithValue("@RoomType", RoomTypeCombo.SelectedItem);


                if (RepairCheck.Checked)
                    commandRoom.Parameters.AddWithValue("@Repair", 1);
                else
                    commandRoom.Parameters.AddWithValue("@Repair", 0);

                if (RefregiratorCheck.Checked)
                    commandRoom.Parameters.AddWithValue("@Refregirator", 1);
                else
                    commandRoom.Parameters.AddWithValue("@Refregirator", 0);




                await commandRoom.ExecuteNonQueryAsync();
                


                MessageBox.Show(
                    "Отлично",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );

                foreach (Control c in Controls)          //стираем значения текстбоксов
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                    RepairCheck.Checked = false;
                    RefregiratorCheck.Checked = false;
                    RoomTypeCombo.SelectedItem = null;
                }


            }

            else
            {
                MessageBox.Show(
                    "Заполните все строки",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );
            }
        }

        private void FormRoomAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
