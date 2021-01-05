using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBegin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void сПРАВКАToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SPRAVKA Form2 = new SPRAVKA();
            Form2.Show();
        }

        private void вЫХОДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void дОЛЖНОСТИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDolgnost Form2 = new FormDolgnost();
            Form2.Show();
        }

        private void нЕСОВЕРШЕННОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNesoverRodstv Form2 = new FormNesoverRodstv();
            Form2.Show();
        }
    }
}
