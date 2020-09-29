using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudicMarinVjezba18
{
    public partial class FormText : Form
    {
        public string Name;
        public string Description;
        public FormText()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Description = textBox2.Text;

        }
    }
}
