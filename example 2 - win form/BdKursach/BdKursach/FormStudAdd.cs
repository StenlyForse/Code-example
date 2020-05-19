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
    public partial class v : Form
    {
        string[] DormArr = {"1 общежитие", "2 общежитие", "3 общежитие", "4 общежитие", "5 общежитие", "6 общежитие", "7 общежитие"};
        string[] CatArr = { "Бюджетник", "Платник", "Льготник" };
        public v()
        {
            InitializeComponent();
            DormNumCombo.Items.AddRange(DormArr);
            CategoryCombo.Items.AddRange(CatArr);
        }

        public string FIO, Tel, MomTel, DadTel, Room, SsPosition, DormNum, Country, City, Street, Category,BirthDate,PaspNum;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PaspNumText_TextChanged(object sender, EventArgs e)
        {

        }

        public int StudBiletNum, Group, TotalPoints, House, Appartment;


        SqlConnection sqlConnection;

        private async void v_Load(object sender, EventArgs e)
        {
            string connectoinString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\BdKursach\BdKursach\First.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectoinString);

            await  sqlConnection.OpenAsync();

           // SqlDataReader sqlReader = null;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DormNumCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DormNumCombo.Items.AddRange(DormArr);
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            /*    FIO = Convert.ToString(FioText.Text);     // конвертируем значения
                Tel = Convert.ToString(TelNumText.Text);
                MomTel = Convert.ToString(MomTelText.Text);
                DadTel = Convert.ToString(DadTelText.Text);
                Room = Convert.ToString(RoomNumText.Text);
                SsPosition = Convert.ToString(SsPostText.Text);
                Country = Convert.ToString(CountryText.Text);
                City = Convert.ToString(CityText.Text);
                Street = Convert.ToString(StreetText.Text);
               // Category = Convert.ToString(CategoryCombo.Text);
                //DormNum = Convert.ToString(DormNumCombo.Text);
               // BirthDate = Convert.ToString(BirthDateText.Text);

                StudBiletNum = Convert.ToInt32(StudNumText.Text);
                PaspNum = Convert.ToInt32(PaspNumText.Text);
                Group = Convert.ToInt32(GroupNumText.Text);
                TotalPoints = Convert.ToInt32(TotalPointsText.Text);
                House = Convert.ToInt32(HouseText.Text);
                Appartment = Convert.ToInt32(AppartmentText.Text); */

            PaspNum = Convert.ToString(PaspNumText.Text);



            SqlCommand commandStd = new SqlCommand("INSERT INTO [Studentt](FIO,BirthDate,StudBiletNum,PaspNum,Tel,MomTel,DadTel,Groupp,Room,DormNeed,Debt,FinePoints,TotalPoints,SsMember,SsPosition,DormNum)VALUES(@FIO,@BirthDate,@StudBiletNum,@PaspNum,@Tel,@MomTel,@DadTel,@Groupp,@Room,@DormNeed,@Debt,@FinePoints,@TotalPoints,@SsMember,@SsPosition,@DormNum);",sqlConnection);

            SqlCommand commandReg = new SqlCommand("INSERT INTO [Registration](PaspNum,Country,City,Street,House,Appartment)VALUES(@paspNum,@Country,@City,@Street,@House,@Appartment);",sqlConnection);

            SqlCommand commandCat = new SqlCommand("INSERT INTO [StudCategory](StudBiletNum,Category)VALUES(@StudBiletNum,@Category);",sqlConnection);




            if (

                !string.IsNullOrEmpty(FioText.Text) && !string.IsNullOrWhiteSpace(FioText.Text) &&                // проверка на пустоту строк
                !string.IsNullOrEmpty(BirthDateText.Text) && !string.IsNullOrWhiteSpace(BirthDateText.Text) &&
                !string.IsNullOrEmpty(StudNumText.Text) && !string.IsNullOrWhiteSpace(StudNumText.Text) &&
                !string.IsNullOrEmpty(PaspNumText.Text) && !string.IsNullOrWhiteSpace(PaspNumText.Text) &&
                !string.IsNullOrEmpty(TelNumText.Text) && !string.IsNullOrWhiteSpace(TelNumText.Text) &&
                !string.IsNullOrEmpty(GroupNumText.Text) && !string.IsNullOrWhiteSpace(GroupNumText.Text) &&
                !string.IsNullOrEmpty(RoomNumText.Text) && !string.IsNullOrWhiteSpace(RoomNumText.Text) &&
                !string.IsNullOrEmpty(TotalPointsText.Text) && !string.IsNullOrWhiteSpace(TotalPointsText.Text) &&
                !string.IsNullOrEmpty(CountryText.Text) && !string.IsNullOrWhiteSpace(CountryText.Text) &&
                !string.IsNullOrEmpty(CityText.Text) && !string.IsNullOrWhiteSpace(CityText.Text) &&
                !string.IsNullOrEmpty(StreetText.Text) && !string.IsNullOrWhiteSpace(StreetText.Text) &&
                !string.IsNullOrEmpty(HouseText.Text) && !string.IsNullOrWhiteSpace(HouseText.Text) &&
                DormNumCombo.SelectedItem!=null&&CategoryCombo.SelectedItem!=null
                

                )
            {

                commandStd.Parameters.AddWithValue("@FIO", FioText.Text);               // пересылка значений в БД
                commandStd.Parameters.AddWithValue("@BirthDate", BirthDateText.Text);   // таблица студент
                commandStd.Parameters.AddWithValue("@StudBiletNum",StudNumText.Text);
                commandStd.Parameters.AddWithValue("@PaspNum", PaspNum);
                commandStd.Parameters.AddWithValue("@Tel", TelNumText.Text);
                commandStd.Parameters.AddWithValue("@MomTel",MomTelText.Text);
                commandStd.Parameters.AddWithValue("@DadTel", DadTelText.Text);
                commandStd.Parameters.AddWithValue("@Groupp", GroupNumText.Text);
                commandStd.Parameters.AddWithValue("@Room", RoomNumText.Text);
                commandStd.Parameters.AddWithValue("@TotalPoints", TotalPointsText.Text);
                commandStd.Parameters.AddWithValue("@DormNum", DormNumCombo.SelectedItem);



                if (NeedDormCheck.Checked)                                                 // проверка и пересылка значений чекбоксов
                    commandStd.Parameters.AddWithValue("@DormNeed", 1);
                else
                    commandStd.Parameters.AddWithValue("@DormNeed", 0);


                if (DebtCheck.Checked)
                    commandStd.Parameters.AddWithValue("@Debt", 1);
                else
                    commandStd.Parameters.AddWithValue("@Debt", 0);

                if (FinePointCheck.Checked)
                    commandStd.Parameters.AddWithValue("@FinePoints", 1);
                else
                    commandStd.Parameters.AddWithValue("@FinePoints", 0);

                if (SsMemberCheck.Checked)
                    commandStd.Parameters.AddWithValue("@SsMember", 1);
                else
                    commandStd.Parameters.AddWithValue("@SsMember", 0);

                commandStd.Parameters.AddWithValue("@SsPosition", SsPostText.Text);


                commandReg.Parameters.AddWithValue("@PaspNum", PaspNumText.Text);       //регистрация
                commandReg.Parameters.AddWithValue("@Country", CountryText.Text);
                commandReg.Parameters.AddWithValue("@City", CityText.Text);
                commandReg.Parameters.AddWithValue("@Street", StreetText.Text);
                commandReg.Parameters.AddWithValue("@House", HouseText.Text);
                commandReg.Parameters.AddWithValue("@Appartment", AppartmentText.Text);


                commandCat.Parameters.AddWithValue("@StudBiletNum", StudNumText.Text);  // категория
                commandCat.Parameters.AddWithValue("@Category", CategoryCombo.SelectedItem);


                await commandStd.ExecuteNonQueryAsync();
                await commandReg.ExecuteNonQueryAsync();
                await commandCat.ExecuteNonQueryAsync();


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
                    NeedDormCheck.Checked = true;
                    DebtCheck.Checked = false;
                    FinePointCheck.Checked = false;
                    SsMemberCheck.Checked = false;
                    DormNumCombo.SelectedItem = null;
                    CategoryCombo.SelectedItem = null;
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


        private void v_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
