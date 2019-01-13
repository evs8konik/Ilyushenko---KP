using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Sclad
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public string ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Magazin.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public void ShowData()
        {


            SqlConnection Connection = new SqlConnection(ConnectionString);

            Connection.Open();

            SqlCommand comm = new SqlCommand("SELECT count(Артикул) FROM View1", Connection);
            Int32 kol = (Int32)comm.ExecuteScalar();
            label5.Text = "всего записей - " + Convert.ToString(kol);
            if (kol > 0)
                dataGridView1.RowCount = kol;
            else dataGridView1.RowCount = 1;

            SqlCommand comm1 = new SqlCommand("SELECT * FROM View1", Connection);
            SqlDataReader myReader = comm1.ExecuteReader(CommandBehavior.CloseConnection);

            int i = 0;
            while (myReader.Read())
            {
                for (int j = 0; j < 9; j++)
                {

                    dataGridView1[j, i].Value = Convert.ToString(myReader[j]);

                }
                i++;

            }


            Connection.Close();
        }
        private void таблицаСкладBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
            this.tableAdapterManager.UpdateAll(this.magazinDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.ТаблицаТовар". При необходимости она может быть перемещена или удалена.
            this.таблицаТоварTableAdapter.Fill(this.magazinDataSet.ТаблицаТовар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.View1". При необходимости она может быть перемещена или удалена.
            this.view1TableAdapter.Fill(this.magazinDataSet.View1);
      
            ShowData();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            dataGridView1.Rows.Clear();

            int len = textBox1.Text.Length;

            string s = textBox1.Text;

            Connection.Open();

            SqlCommand comm = new SqlCommand("SELECT count(Артикул) FROM View1 ", Connection);
            Int32 kol = (Int32)comm.ExecuteScalar();
            label5.Text = "всего записей - " + Convert.ToString(kol);
            if (kol > 0)
                dataGridView1.RowCount = kol;
            else dataGridView1.RowCount = 1;

            //  dataGridView1.Rows.Clear();

            len = textBox1.Text.Length;

            s = textBox1.Text;
            string co = "";

            if (len > 0) co = "SELECT * FROM View1 WHERE substring(Артикул,1," + len + " ) = '" + s + "' ";
            else co = "SELECT * FROM View1";


            SqlCommand comm1 = new SqlCommand(co, Connection);
            SqlDataReader myReader = comm1.ExecuteReader(CommandBehavior.CloseConnection);

            int i = 0;
            while (myReader.Read())
            {
                for (int j = 0; j < 9; j++)
                {

                    dataGridView1[j, i].Value = Convert.ToString(myReader[j]);

                }
                i++;

            }


            Connection.Close();
        }
    }
}
