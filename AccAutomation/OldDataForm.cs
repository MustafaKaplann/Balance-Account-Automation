using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace AccAutomation
{
    public partial class OldDataForm : Form
    {
        public OldDataForm()
        {
            InitializeComponent();
        }



        private void OldDataForm_Load(object sender, EventArgs e)
        {
            var connection2 = Form1.baglanti;

            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM table_olddata", connection2);


            SqlDataReader reader = command.ExecuteReader();

            dt.Load((reader));

            dataGridView1.DataSource = dt;
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 go = new Form2();
            go.Show();
            this.Hide();
        }


        //verileri silecek olan event
        private void button2_Click(object sender, EventArgs e)
        {
            var connection2 = Form1.baglanti;

            
            SqlCommand command = new SqlCommand("DELETE FROM table_olddata",connection2);
            command.ExecuteNonQuery();

            SqlCommand command2 = new SqlCommand("SELECT * FROM table_olddata", connection2);
            SqlDataReader reader2 = command2.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load((reader2));

            dataGridView1.DataSource = dt;
            reader2.Close();
        }
    }
}


/*        void oncekiData()
        {
                       SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-0SPOTJ5; Initial Catalog = DB_AccAutomation; Integrated Security = SSPI");

                        baglanti.Open();

                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM table_prev_balance", baglanti);
                        // SqlCommand komut = new SqlCommand("select * from table_prev-balance where balance_amount", baglanti);

                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;

                        baglanti.Close();
        }*/