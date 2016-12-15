using Faktura.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FakturaDesign
{
    public partial class MainFrame : Form
    {
        Queries queries = new Queries();

        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllFirms();
        }

        private void ListAllFirms()
        {
            supName.Items.Clear();
            recName.Items.Clear();
           //Listing all Firms
           var firms = queries.getAllFirms();

            foreach (var firm in firms)
            {
                if (firm.IsMyFirm == true)
                {
                    supName.Items.Add(firm.Name);
                }
                else
                {
                    recName.Items.Add(firm.Name);
                }
            }
            //Searching for firms
            supName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            supName.AutoCompleteSource = AutoCompleteSource.ListItems;

            recName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            recName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedCells.Count > 1)
            {
                List<int> rows = new List<int>();
                foreach (DataGridViewTextBoxCell item in dataGridView1.SelectedCells)
                {
                    if (item.RowIndex != -1)
                    {
                        dataGridView1.Rows.RemoveAt(item.RowIndex);
                    }
                }   
            }
            else if(dataGridView1.SelectedCells.Count == 1)
            {
                int row = dataGridView1.SelectedCells[0].RowIndex;
                if (dataGridView1.Rows.Count > row)
                {
                    dataGridView1.Rows.RemoveAt(row);
                }     
            }

            SetNumbering();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            SetNumbering();
        }

        private void FirmBtn_Click(object sender, EventArgs e)
        {
            FirmsFrame firmWindow = new FirmsFrame();
            firmWindow.Show();
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            ProducstFrame productsWindow = new ProducstFrame();
            productsWindow.Show();
        }

        private void SetNumbering()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetNumbering();
        }

        private void DataGridView1_CellEndEdit(object sender, EventArgs e)
        {
           
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Product pr = queries.findProductByName(name);
                if (pr != null)
                {
                    dataGridView1.CurrentRow.Cells[1].Value = pr.Name;
                    dataGridView1.CurrentRow.Cells[2].Value = "br.";
                    dataGridView1.CurrentRow.Cells[3].Value = 0;
                    dataGridView1.CurrentRow.Cells[4].Value = pr.PriceWithoutDDS;
                    dataGridView1.CurrentRow.Cells[5].Value = 0;
                }
            }
            else if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                int qunatity = 0;
                double price = 0;
                if (int.TryParse(dataGridView1.CurrentRow.Cells[3].Value.ToString(), out qunatity) &&
                    double.TryParse(dataGridView1.CurrentRow.Cells[4].Value.ToString(), out price))
                {
                    dataGridView1.CurrentRow.Cells[5].Value = qunatity * price;
                }
            }
        }

        private void SupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string suplierName = supName.SelectedItem.ToString();
            Firm f = queries.getFirmInfo(suplierName);
            supName.Text = f.Name;
            textBox8.Text = f.Adress;
            textBox7.Text = f.Bulstat.ToString();
            textBox6.Text = f.Mol;
           // listAllFirms();            
        }

        private void RecName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string recieverName = recName.SelectedItem.ToString();
            Firm f = queries.getFirmInfo(recieverName);
            recName.Text = f.Name;
            textBox1.Text = f.Adress;
            textBox2.Text = f.Bulstat.ToString();
            textBox3.Text = f.Mol;
           // listAllFirms();
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AllProductsSum();
            double procentage = double.Parse(comboBox1.SelectedItem.ToString());
            double sum = double.Parse(label16.Text.ToString());
            sum = sum * (procentage / 100) + sum;
            label22.Text = string.Format("{0:0.00}", sum);
        }

        private void AllProductsSum()
        {
            double sum = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[5].Value != null)
                {
                    sum += Double.Parse(item.Cells[5].Value.ToString());
                }
                
            }
            label16.Text = string.Format("{0:0.00}", sum);
        }
 
    }
}
