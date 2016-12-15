using Faktura.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaDesign
{
    public partial class FirmsFrame : Form
    {
        Queries queries = new Queries();
        public FirmsFrame()
        {
            InitializeComponent();
        }

        private void FirmFrame_Load(object sender, EventArgs e)
        {
            var firms = queries.getAllFirms();

            //Searching for firms and load them
            firmName.AutoCompleteCustomSource.AddRange(firms.Select(f => f.Name).ToArray());

        }

        private void FirmName_TextChanged(object sender, EventArgs e)
        {
            var SelectedFirmName = firmName.Text;
            if (SelectedFirmName != "")
            {
                //Complete the rest of the information
                try
                {
                    var selectedFirm = queries.getFirmInfo(SelectedFirmName);
                    firmBulstat.Text = selectedFirm.Bulstat + "";
                    firmAdress.Text = selectedFirm.Adress;
                    firmMol.Text = selectedFirm.Mol;
                    firmOwned.Checked = selectedFirm.IsMyFirm;
                }
                catch (Exception)
                {

                }
            }  
        }

        private void AddFirmBtn_Click(object sender, EventArgs e)
        {
            Firm firm = GetFirmInfo(false);
            Firm dbFirm = queries.getFirmInfo(firm.Name);

            //There is no firm, so it will be added to DB
            if (dbFirm == null)
            {
                queries.addFirm(firm);
                firmName.AutoCompleteCustomSource.Add(firm.Name);
            }
            else if (CompareFirms(dbFirm, firm))
            {
                //No changes to the firm
                MessageBox.Show("Firm already exists");
            }
            else
            {
                //Edit
                queries.removeFirm(dbFirm);
                queries.addFirm(firm);
            }
        }

        private void ClearFields()
        {
            firmName.Text = "";
            firmAdress.Text = "";
            firmAdress.Text = "";
            firmMol.Text = "";
            firmBulstat.Text = "";
            firmOwned.Checked = false;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            Firm firm = GetFirmInfo(true);
            if (firm != null)
            {
                queries.removeFirm(firm);
                ClearFields();
                firmName.AutoCompleteCustomSource.Remove(firm.Name);
            }

            
        }

        private Firm GetFirmInfo(bool deleteBtn)
        {
            Firm firm = new Firm();
            Firm dbFirm = new Firm();
            long bulstat = 0;

            //Get input Data
            if (long.TryParse(firmBulstat.Text, out bulstat))
            {
                firm.Bulstat = bulstat;
                firm.Name = firmName.Text;
                firm.Adress = firmAdress.Text;
                firm.Mol = firmMol.Text;
                firm.IsMyFirm = firmOwned.Checked;
            }
            else
            {
                return null;
            }

            //Get firm by name 
            dbFirm = queries.findFirmByName(firm.Name);

            //Compare and check if input Data is modified and not valid
            if (dbFirm == null)
            {
                //add product
                return firm;
            }
            else if (deleteBtn == false)
            {
                //return product to be edited
                return firm;
            }
            else if (CompareFirms(dbFirm,firm))
            {
                // return product to be removed
                return dbFirm;
            }
            else
            {
                MessageBox.Show("No Such Firm");
                return null;
            }
        }

        private bool CompareFirms(Firm first, Firm second)
        {
            if (first.Adress == second.Adress &&
                first.Bulstat == second.Bulstat &&
                first.IsMyFirm == second.IsMyFirm &&
                first.Mol == second.Mol &&
                first.Name == second.Name)
            {
                return true;
            }
            return false;
        }
    }
}
