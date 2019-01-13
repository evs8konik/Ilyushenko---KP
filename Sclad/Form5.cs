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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void таблицаПоставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.таблицаПоставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.ТаблицаПоставщики". При необходимости она может быть перемещена или удалена.
            this.таблицаПоставщикиTableAdapter.Fill(this.magazinDataSet.ТаблицаПоставщики);

        }
    }
}
