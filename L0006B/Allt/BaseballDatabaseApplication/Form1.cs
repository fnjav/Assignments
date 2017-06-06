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

namespace BaseballDatabaseApplication
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballModel.Players' table. You can move, or remove it, as needed.
            playersTableAdapter.Fill(this.baseballModel.Players);

            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchPlayer(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchPlayerByBA(textBox2.Text, textBox3.Text);
        }

        private void searchPlayer(string name)
        {
            string sqlQuery = string.Format("SELECT * FROM Players WHERE LastName='{0}'", name);
            doSql(sqlQuery);
        }

        private void searchPlayerByBA(string min, string max)
        {
            if (min.Equals(""))
                min = "0.000";
            if (max.Equals(""))
                max = "1.000";

            string sqlQuery = string.Format("SELECT * FROM Players WHERE BattingAverage BETWEEN {0} AND {1}", min, max);
            doSql(sqlQuery);
        }

        private void doSql(string sqlQuery)
        {
            try
            {
                string path = Application.StartupPath.ToString() + @"\Baseball.mdf";
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                var dataAdapter = new SqlDataAdapter(sqlQuery, conn);
                var cmd = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception e)
            {
                //Tidigare använt för testning
                MessageBox.Show("Nu blev det fel! Felkod: " + e, "Järnspikar",    
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
           

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }       
    
}
