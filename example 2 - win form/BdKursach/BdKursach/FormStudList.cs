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
    public partial class FormStudList : Form
    {
        public FormStudList()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        
        private async void FormStudList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "finalStudentDataSet2.Studentt". При необходимости она может быть перемещена или удалена.
            this.studenttTableAdapter.Fill(this.finalStudentDataSet2.Studentt);

            string connectoinString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\BdKursach\BdKursach\First.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectoinString);

            await sqlConnection.OpenAsync();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FioDeleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FIODeleteText.Text) && !string.IsNullOrWhiteSpace(FIODeleteText.Text))
            {

                SqlCommand commandDelete = new SqlCommand("DELETE FROM [Studentt] WHERE [FIO]=@FIO",sqlConnection);

                commandDelete.Parameters.AddWithValue("@FIO", FIODeleteText.Text);

                await commandDelete.ExecuteNonQueryAsync();

               // SqlCommand commandUpdate = new SqlCommand("UPDATE [Studentt] SET [FIO]=@FIO,[BirthDate]=@BirthDate,[StudBiletNum]=@StudBiletNum,[PaspNum]=@PaspNum,[Tel]=@Tel,[MomTel]=@MomTel,[DadTel]=@DadTel,[Groupp]=@Groupp,[Room]=@Room,[DormNeed]=@DormNeed,[Debt]=@Debt,[FinePoints]=@FinePoints,[TotalPoints]=@TotalPoints,[SsMember]=@SsMember,[SsPosition]=@SsPosition,[DormNum]=@DormNum");

               

                foreach (Control c in Controls)          //стираем значения текстбоксов
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                    
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SearchText.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
