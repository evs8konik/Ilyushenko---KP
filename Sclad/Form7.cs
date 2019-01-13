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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void таблицаГруппыТовараBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.таблицаГруппыТовараBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.ТаблицаГруппыТовара". При необходимости она может быть перемещена или удалена.
            this.таблицаГруппыТовараTableAdapter.Fill(this.magazinDataSet.ТаблицаГруппыТовара);

        }
    }
}
