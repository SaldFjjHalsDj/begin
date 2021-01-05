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

namespace ProjectBegin
{
    public partial class FormNesoverRodstv : Form
    {
        public FormNesoverRodstv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = @"Data Source=ии-пк\SQLEXPRESS; Initial Catalog = PERSONNELSAD;Integrated Security=True";
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "SELECT * FROM [Несовершеннолетние родственники]";
                dataReader = myCommand.ExecuteReader();
            while (dataReader.Read())
                {
                    // Создаем переменные, получаем для них значения из объекта dataReader,
                    //используя метод GetТипДанных
                    string Sotrudnik = dataReader.GetString(0);
                    string VidRod = dataReader.GetString(1);
                    string FamRod = dataReader.GetString(2);
                    string ImyRod = dataReader.GetString(3);
                    string OtchRod = dataReader.GetString(4);
                    int Vozrast = dataReader.GetInt32(5);
                    //Создаем экземпляр item класса ListViewItem для записи в него
                    //данных из dataReader
                    ListViewItem item = new ListViewItem(new
                    string[]{Convert.ToString(dataReader[0]),
                                Convert.ToString(dataReader[1]), Convert.ToString(dataReader[2]),
                                Convert.ToString(dataReader[3]), Convert.ToString(dataReader[4]),
                                Convert.ToString(dataReader[5]) });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
