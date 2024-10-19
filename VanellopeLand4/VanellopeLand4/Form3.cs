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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\zeyne\\OneDrive\\Belgeler\\VanellopeLand.accdb");

        private void Form3_Load(object sender, EventArgs e)
        {
            Conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT gameName, gameFee FROM Form2", Conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["gameName"].Points.AddXY(reader[0].ToString(), reader[1].ToString());
            }
            Conn.Close();
        }
    }
}
