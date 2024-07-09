using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AccAutomation
{
    public partial class EnterDataForm : Form
    {
        public EnterDataForm()
        {
            InitializeComponent();
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            DateTime currentTime = DateTime.Now;
            CultureInfo language = new CultureInfo("en-US");

            string dayAsText = currentTime.ToString("dddd", language);
            string monthAsText = currentTime.ToString("MMMM", language);



            int day = currentTime.Day;
            int month = currentTime.Month;
            int year = currentTime.Year;
            //   string dateInDataGridRow = day.ToString() + "/" + month.ToString() + "/" + year.ToString();

            //    label1.Text = "Day: " + day.ToString();

            label2.Text = year.ToString();
            label4.Text = monthAsText;
            label6.Text = dayAsText;
            /*            label11.Text = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            */

            
        }


        private void EnterDataForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            int day = currentTime.Day;
            int month = currentTime.Month;
            int year = currentTime.Year;
            string dateInDataGridRow = day.ToString() + "/" + month.ToString() + "/" + year.ToString();

            string revenueDescription = textBox3.Text;
            string revenueAmount = maskedTextBox1.Text;


            if (!string.IsNullOrWhiteSpace(revenueDescription) && !string.IsNullOrWhiteSpace(revenueAmount) && int.TryParse(revenueAmount, out int numericValue))
            {
                dataGridView1.Rows.Add(revenueDescription, numericValue, dateInDataGridRow);

                textBox3.Clear();
                maskedTextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid data in both fields.");
            }

        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.ControlText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.IndianRed;
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.ControlText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            int day = currentTime.Day;
            int month = currentTime.Month;
            int year = currentTime.Year;

            string expenseDescription = textBox5.Text;
            string expenseAmount = maskedTextBox2.Text;
            string dateInDataGridRow = day.ToString() + "/" + month.ToString() + "/" + year.ToString();



            if (!string.IsNullOrWhiteSpace(expenseDescription) && !string.IsNullOrWhiteSpace(expenseAmount) && int.TryParse(expenseAmount, out int numericValue))
            {
                dataGridView1.Rows.Add(expenseDescription, "-" + numericValue, dateInDataGridRow);

                textBox5.Clear();
                maskedTextBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid data in both fields.");
            }
        }






        private void button5_Click(object sender, EventArgs e)
        {
            int columnSum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null && int.TryParse(row.Cells[1].Value.ToString(), out int cellValue))
                {
                    columnSum += cellValue;
                }
            }
            dataGridView2.Rows[0].Cells[0].Value = columnSum;
            dataGridView1.Rows.Clear();
        }

       



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 go = new Form2();
            go.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CultureInfo language = new CultureInfo("en-US");
            var date = DateTime.Now.ToString("MMMM", language);
            int cellValue = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value);
            int columnSum = cellValue;

            var connection = Form1.baglanti;

            SqlCommand command = new SqlCommand(@"INSERT INTO table_olddata (Months,Sum) VALUES (@p1,@p2)" , connection);

            command.Parameters.AddWithValue("@p1",date);
            command.Parameters.AddWithValue("@p2",columnSum);

            command.ExecuteNonQuery();


            OldDataForm oldDataForm = new OldDataForm();

            oldDataForm.Show();
        }
    }
}
