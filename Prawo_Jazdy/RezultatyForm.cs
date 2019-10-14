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
    public partial class RezultatyForm : Form
    {

        SqlConnection connection;
        SqlCommand allRecordsCommand;
        SqlCommand allRecordsCommandCount;
        SqlDataReader dataReader;
        BindingSource source;


        public RezultatyForm()
        {
            InitializeComponent();

            connection = new SqlConnection();
            connection.ConnectionString = "data source = (local)\\SQLEXPRESS;database = HistoriaDatabase;integrated security = SSPI";
            connection.Open();

            allRecordsCommand = new SqlCommand("select * from MyResults", connection);
            allRecordsCommandCount = new SqlCommand("select count('Punkty') from MyResults", connection);



            if (Convert.ToInt32(allRecordsCommandCount.ExecuteScalar()) > 0)
            {
                dataReader = allRecordsCommand.ExecuteReader();
                source = new BindingSource();
                source.DataSource = dataReader;
                dataGridView1.DataSource = source;
                dataReader.Close();
            }
        }

        private void RezultatyForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
