
using AccAutomation;
using System.Data.SqlClient;

namespace AccAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
      public static  SqlConnection baglanti = new SqlConnection(@"YourSQLcode");
        
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("Username required to log in!");
            }
            else if (textBox2.Text == "" && textBox1.Text != "")
            {
                MessageBox.Show("Password required to log in!");
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Username and password required to log in!");
            }
            else
            {
                baglanti.Open();
                string user;
                string pass;
                user = textBox1.Text;
                pass = textBox2.Text;

                SqlCommand komut = new SqlCommand("select * from LOGIN_TABLE_NAME where username='" + user + "' and password='" + pass + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    Form2 go = new Form2();
                    go.Show();
                    this.Hide();
                    oku.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is wrong!");
                }

            
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = checkBox1.Checked;

        }
    }
}

