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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;


        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FormDrives = new Form2();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 FormDrives = new Form3();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void conductorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 FormDrives = new Form4();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 FormDrives = new Form5();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void отработанноеВремяВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 FormDrives = new Form6();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void пробегАвтобусовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 FormDrives = new Form7();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void выручкаКондукторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 FormDrives = new Form8();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void путивыеЛистыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 FormDrives = new Form9();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void путивыеЛистыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 FormDrives = new Form10();
            FormDrives.MdiParent = this;
            FormDrives.Show();

        }

        private void реестрПутёвокВодителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 FormDriversPrint = new Form11();
            FormDriversPrint.Show();
        }

        private void шаблонДоговораНаПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"doc\dogovor_na_postavku.doc");
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Справка.pdf");
        }

        private void оПрограмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AboutBox1 FormAbout = new AboutBox1();
            
            FormAbout.ShowDialog();
        }
    }
}
