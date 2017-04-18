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

namespace XMLData
{
    public partial class XMLDataForm : Form
    {
        public XMLDataForm()
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
                int n = DataGridView.Rows.Add();
                DataGridView.Rows[n].Cells[0].Value = TypeComboBox.Text;
                DataGridView.Rows[n].Cells[1].Value = CandyNameTextBox.Text;
                DataGridView.Rows[n].Cells[2].Value = ToppingComboBox.Text;
                DataGridView.Rows[n].Cells[3].Value = SugarNumericUpDown.Value;
                DataGridView.Rows[n].Cells[4].Value = MassNumericUpDown.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet data_set = new DataSet(); // empty cache
                DataTable data_table = new DataTable(); // empty table
                data_table.TableName = "Candies";
                data_table.Columns.Add("Type");
                data_table.Columns.Add("Name");
                data_table.Columns.Add("Topping");
                data_table.Columns.Add("Sugar");
                data_table.Columns.Add("Mass");
                data_set.Tables.Add(data_table); 

                foreach (DataGridViewRow data_grid_row in DataGridView.Rows)
                {
                    DataRow data_row = data_set.Tables["Candies"].NewRow();
                    data_row["Type"] = data_grid_row.Cells[0].Value;
                    data_row["Name"] = data_grid_row.Cells[1].Value;
                    data_row["Topping"] = data_grid_row.Cells[2].Value;
                    data_row["Sugar"] = data_grid_row.Cells[3].Value;
                    data_row["Mass"] = data_grid_row.Cells[4].Value;
                    data_set.Tables["Candies"].Rows.Add(data_row);
                }
                data_set.WriteXml(@"d:\Programing\C#\Studying\EPAM\Task_1[CandyGift]\CandiesData.xml");
                MessageBox.Show("CandiesData.xml successfully saved.");
            }
            catch (Exception)
            {
                MessageBox.Show("Can't save file.");
            }
        }

        private void XMLDataForm_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
