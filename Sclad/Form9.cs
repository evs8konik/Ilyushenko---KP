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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void таблицаДоговорыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.таблицаДоговорыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.ТаблицаДоговоры". При необходимости она может быть перемещена или удалена.
            this.таблицаДоговорыTableAdapter.Fill(this.magazinDataSet.ТаблицаДоговоры);

        }
    }
}
