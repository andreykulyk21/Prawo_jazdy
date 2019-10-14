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

namespace Prawo_jazdy
{
    public partial class Kategoria_A : Form
    {

        static int prawidloweOdpowiedzi = 0;
        public Kategoria_A()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = -1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Odpowiedzi programa = new Odpowiedzi();
            programa.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            prawidloweOdpowiedzi = 0;

            if (comboBox1.Text.Equals("C. Na drodze oblodzonej."))
            {
                prawidloweOdpowiedzi++;
            }

            if (comboBox2.Text.Equals("B. 5 m."))
            {
                prawidloweOdpowiedzi++;
            }
            if (comboBox3.Text.Equals("C. Zatrzymać się, wezwać pomoc medyczną i udzielić pierwszej pomocy poszkodowanemu."))
            {
                prawidloweOdpowiedzi++;
            }
            if (comboBox4.Text.Equals("B. Na upewnieniu się, że operator przyjął całą informację o wypadku."))
            {
                prawidloweOdpowiedzi++;
            }

            MessageBox.Show("Prawidlowych odpowiedzi: " + prawidloweOdpowiedzi + "/4");

            string cmdString = "INSERT INTO MyResults (Punkty) VALUES (@val1)";
            string connString = "data source = (local)\\SQLEXPRESS;database = HistoriaDatabase;integrated security = SSPI";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = (local)\\SQLEXPRESS;database = HistoriaDatabase;integrated security = SSPI";
            connection.Open();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand(cmdString, connection))
                {
                    comm.Connection = conn;
                    comm.Parameters.AddWithValue("@val1", prawidloweOdpowiedzi);

                    conn.Open();
                    comm.ExecuteNonQuery();

                    this.Close();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
