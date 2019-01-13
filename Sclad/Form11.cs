using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sclad
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.View1". При необходимости она может быть перемещена или удалена.
            this.view1TableAdapter.Fill(this.magazinDataSet.View1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.View1". При необходимости она может быть перемещена или удалена.
          
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
