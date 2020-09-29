using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudicMarinVjezba18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void messegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme","Obavještenje ",MessageBoxButtons.YesNoCancel );
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (program.SelectedItem == "Paint") Process.Start("mspaint.exe");
            else Process.Start("notepad.exe");
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormText frm=new FormText();
            frm.Show();
           

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dig=MessageBox.Show("Dali ste sigurni da želite izaći iz programa", "Obavjesti", MessageBoxButtons.YesNo);
            if (dig == DialogResult.Yes) this.Close();
        }
    }
}
