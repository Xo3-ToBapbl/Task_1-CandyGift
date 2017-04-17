using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Demostration
{
    public partial class DemostrationForm : Form
    {
        public DemostrationForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CandyNameTextBox.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = TypeComboBox.Text;
                dataGridView1.Rows[n].Cells[1].Value = CandyNameTextBox.Text;
                dataGridView1.Rows[n].Cells[2].Value = SugarNumericUpDown.Value;
                dataGridView1.Rows[n].Cells[3].Value = ToppingComboBox.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
