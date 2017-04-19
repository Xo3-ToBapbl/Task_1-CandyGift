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

namespace XMLDataCreater
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
                data_table.Columns.Add("CandyName");
                data_table.Columns.Add("Topping");
                data_table.Columns.Add("Sugar");
                data_table.Columns.Add("Mass");
                data_set.Tables.Add(data_table); 

                foreach (DataGridViewRow data_grid_row in DataGridView.Rows)
                {
                    DataRow data_row = data_set.Tables["Candies"].NewRow();
                    data_row["Type"] = data_grid_row.Cells[0].Value;
                    data_row["CandyName"] = data_grid_row.Cells[1].Value;
                    data_row["Topping"] = data_grid_row.Cells[2].Value;
                    data_row["Sugar"] = data_grid_row.Cells[3].Value;
                    data_row["Mass"] = data_grid_row.Cells[4].Value;
                    data_set.Tables["Candies"].Rows.Add(data_row);
                }
                data_set.WriteXml("CandiesData.xml");
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

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count > 0)
            {
                MessageBox.Show("Clean table please.");
            }
            else
            {
                if (File.Exists("CandiesData.xml"))
                {
                    DataSet data_set = new DataSet();
                    data_set.ReadXml("CandiesData.xml");

                    foreach (DataRow data_row in data_set.Tables["Candies"].Rows)
                    {
                        int n = DataGridView.Rows.Add();
                        DataGridView.Rows[n].Cells["Type"].Value = data_row["Type"];
                        DataGridView.Rows[n].Cells["CandyName"].Value = data_row["CandyName"];
                        DataGridView.Rows[n].Cells["Topping"].Value = data_row["Topping"];
                        DataGridView.Rows[n].Cells["Sugar"].Value = data_row["Sugar"];
                        DataGridView.Rows[n].Cells["Mass"].Value = data_row["Mass"];
                    }
                }
                else
                {
                    MessageBox.Show("File is not exist or injured");
                }
            }
        }

        private void DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                TypeComboBox.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                CandyNameTextBox.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                ToppingComboBox.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                SugarNumericUpDown.Value = Convert.ToInt32(DataGridView.SelectedRows[0].Cells[3].Value);
                MassNumericUpDown.Value = Convert.ToInt32(DataGridView.SelectedRows[0].Cells[4].Value);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(DataGridView.SelectedRows.Count > 0)
            {
                DataGridView.Rows.RemoveAt(DataGridView.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Select row.");
            }
        }

        private void CustomizeButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                int n = DataGridView.SelectedRows[0].Index;
                DataGridView.Rows[n].Cells[0].Value = TypeComboBox.Text;
                DataGridView.Rows[n].Cells[1].Value = CandyNameTextBox.Text;
                DataGridView.Rows[n].Cells[2].Value = ToppingComboBox.Text;
                DataGridView.Rows[n].Cells[3].Value = SugarNumericUpDown.Value;
                DataGridView.Rows[n].Cells[4].Value = MassNumericUpDown.Value;
            }
            else
            {
                MessageBox.Show("Select row.");
            }
        }

        private void ClearAllbutton_Click(object sender, EventArgs e)
        {
            if(DataGridView.Rows.Count > 0)
            {
                DataGridView.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Table already clean.");
            }
        }
    }
}
