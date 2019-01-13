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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void таблицаЕдиницыИзмеренияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.таблицаЕдиницыИзмеренияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinDataSet.ТаблицаЕдиницыИзмерения". При необходимости она может быть перемещена или удалена.
            this.таблицаЕдиницыИзмеренияTableAdapter.Fill(this.magazinDataSet.ТаблицаЕдиницыИзмерения);

        }
    }
}
