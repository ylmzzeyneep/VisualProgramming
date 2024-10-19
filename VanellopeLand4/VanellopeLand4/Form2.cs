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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VanellopeLand4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\zeyne\\OneDrive\\Belgeler\\VanellopeLand.accdb");

        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.form2TableAdapter.Fill(this.vanellopeLandDataSet1.Form2);
            try
            {
                Conn.Open();
                string sqlText = "SELECT * FROM Form2";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlText, Conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

        }

        //Save button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                string sqlText = "INSERT INTO Form2 (gameName, gameType, ageRestriction, gameFee, gameDescription) VALUES(@gameName, @gameType, @ageRestriction, @gameFee, @gameDescription)";

                OleDbCommand AccessCommand = new OleDbCommand(sqlText, Conn);
                AccessCommand.Parameters.AddWithValue("@gameName", textBox1.Text);
                AccessCommand.Parameters.AddWithValue("@gameType", textBox2.Text);
                AccessCommand.Parameters.AddWithValue("@ageRestriction", textBox3.Text);
                AccessCommand.Parameters.AddWithValue("@gameFee", textBox4.Text);
                AccessCommand.Parameters.AddWithValue("@gameDescription", textBox5.Text);

                AccessCommand.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        //Delete button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                OleDbCommand Comm = new OleDbCommand();
                Comm.Connection = Conn;

                string sqlText = "DELETE FROM Form2 WHERE ID = @ID";
                Comm.CommandText = sqlText;
                Comm.Parameters.AddWithValue("@ID", textBox6.Text);
                Comm.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarıyla silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Conn.Close();
                textBox6.Clear();
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                Conn.Open();
                string sqlText = "SELECT * FROM Form2";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlText, Conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }


        //View button
        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }


        int i = 0;
        //Update button
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                string sqlText = "UPDATE Form2 SET gameName = @gameName, gameType = @gameType, ageRestriction = @ageRestriction, gameFee = @gameFee, gameDescription = @gameDescription WHERE ID = @ID";

                OleDbCommand AccessCommand = new OleDbCommand(sqlText, Conn);
                AccessCommand.Parameters.AddWithValue("@gameName", textBox1.Text);
                AccessCommand.Parameters.AddWithValue("@gameType", textBox2.Text);
                AccessCommand.Parameters.AddWithValue("@ageRestriction", textBox3.Text);
                AccessCommand.Parameters.AddWithValue("@gameFee", textBox4.Text);
                AccessCommand.Parameters.AddWithValue("@gameDescription", textBox5.Text);
                AccessCommand.Parameters.AddWithValue("@ID", dataGridView1.Rows[i].Cells[0].Value);

                AccessCommand.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarıyla güncellendi.");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }
    }
}

