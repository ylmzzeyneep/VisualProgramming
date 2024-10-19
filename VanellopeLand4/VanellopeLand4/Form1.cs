using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanellopeLand4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\zeyne\\OneDrive\\Belgeler\\VanellopeLand.accdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (loginVerification(userName, password))
            {
                MessageBox.Show("Giriş başarılı!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre. Lütfen tekrar deneyin.");
            }
        }

        private bool loginVerification(string userName, string password)
        {
            try
            {
                Conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Form1 WHERE userName=@userName AND password=@password", Conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);

                OleDbDataReader reader = cmd.ExecuteReader();
                return reader.Read();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
            finally
            {
                Conn.Close();
            }

        }
    }
}
