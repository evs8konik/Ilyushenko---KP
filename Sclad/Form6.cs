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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void таблицаОтделыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.таблицаОтделыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.ТаблицаОтделы". При необходимости она может быть перемещена или удалена.
            this.таблицаОтделыTableAdapter.Fill(this.magazinDataSet.ТаблицаОтделы);

        }
    }
}
