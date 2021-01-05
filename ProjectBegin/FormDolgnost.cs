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
    public partial class FormDolgnost : Form
    {
        public FormDolgnost()
        {
            InitializeComponent();
        }

        private void FormDolgnost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pERSONNELSADDataSet.ДОЛЖНОСТИ". При необходимости она может быть перемещена или удалена.
            this.дОЛЖНОСТИTableAdapter.Fill(this.pERSONNELSADDataSet.ДОЛЖНОСТИ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pERSONNELSADDataSet.ДОЛЖНОСТИ". При необходимости она может быть перемещена или удалена.
            this.дОЛЖНОСТИTableAdapter.Fill(this.pERSONNELSADDataSet.ДОЛЖНОСТИ);

        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cm = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
                if (cm.Count > 0)
                    if (MessageBox.Show("Удалить текущую строку?", "???",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        cm.RemoveAt(cm.Position);
                дОЛЖНОСТИTableAdapter.Update(pERSONNELSADDataSet);
            }
            catch
            {
                MessageBox.Show("Удаление запрещено - Вы пытаетесь удалить связанную запись.");
            }
        }


    }
}
