using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccAutomation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            DateTime currentTime = DateTime.Now;
            CultureInfo language = new CultureInfo("en-US");
            string thisMonthAsText = currentTime.ToString("MMMM", language);
            button1.Text = "Enter Data For This Month\n(" + thisMonthAsText + ")";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EnterDataForm go = new EnterDataForm();
            go.Show();
            this.Hide();




            DateTime currentTime = DateTime.Now;
            CultureInfo language = new CultureInfo("en-US");

            string dayAsText = currentTime.ToString("dddd", language);
            string monthAsText = currentTime.ToString("MMMM", language);

            int day = currentTime.Day;
            int month = currentTime.Month;
            int year = currentTime.Year;
            int hour = currentTime.Hour;

            //    label1.Text = "Day: " + day.ToString();
            //    label2.Text = "Month: " + month.ToString();
            //    label3.Text = "Year: " + year.ToString();
            //    label4.Text = "Hour: " + hour.ToString();

            //    label5.Text = "Day As Text: " + dayAsText;
            //    label6.Text = "Month As Text: " + monthAsText;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OldDataForm go = new OldDataForm();
            go.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
