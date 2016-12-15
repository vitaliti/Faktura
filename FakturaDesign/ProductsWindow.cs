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
    public partial class ProducstFrame : Form
    {
        Queries queries = new Queries();

        public ProducstFrame()
        {
            InitializeComponent();
        }

        private void ProducstFrame_Load(object sender, EventArgs e)
        {
            var products = queries.getAllProducts();

            //Searching for firms
            productName.AutoCompleteCustomSource.AddRange(products.Select(f => f.Name).ToArray());

        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {
            var SelectedProductName = productName.Text;
            if (SelectedProductName != "")
            {
                //Complete the rest of the information
                try
                {
                    Product selectedProduct = queries.findProductByName(SelectedProductName);
                    productPrice.Text = selectedProduct.PriceWithoutDDS + "";
                    productProcentegeDDS.Text = selectedProduct.ProcentDDS + "";
                    Barkod.Text = selectedProduct.Barcode;
                }
                catch (Exception)
                {

                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Product product = GetProductInfo(false);
            Product dbProduct = queries.findProductByName(product.Name);

            //There is no product, so it will be added to DB
            if (dbProduct == null)
            {
                queries.addProduct(product);
                productName.AutoCompleteCustomSource.Add(product.Name);
            }
            else if(CompareProducts(dbProduct,product))
            {
                //No changes to the product
                MessageBox.Show("Product already exists");
            }
            else
            {
                //Edit
                queries.removeProduct(dbProduct);
                queries.addProduct(product);
            }
           
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            Product product = GetProductInfo(true);
            if (product != null)
            {
                queries.removeProduct(product);
                ClearFields();
                productName.AutoCompleteCustomSource.Remove(product.Name);
            }
                
        }

        private Product GetProductInfo(bool deleteBtn)
        {
            Product dbProduct = new Product();
            Product product = new Product();
            decimal price = 0;
            int dds = 0;
            //Get input Data
            if (decimal.TryParse(productPrice.Text, out price) &&
                int.TryParse(productProcentegeDDS.Text, out dds))
            {
                product.Name = productName.Text;
                product.PriceWithoutDDS = price;
                product.ProcentDDS = dds;
                product.Barcode = Barkod.Text;
            }
            else
            {
                return null;
            }

           //Get product by name 
            dbProduct = queries.findProductByName(product.Name);

            if (dbProduct == null)
            {
                //return product to be added  product
                return product;
            }
            else if (deleteBtn == false)
            {
                //return product to be edited
                return product;
            }//Compare and check if input Data is modified and not valid
            else if (CompareProducts(product,dbProduct))
            {
                // return product to be removed
                return dbProduct;
            }
            else
            {
                MessageBox.Show("No Such product");
                return null;
            }
            
        }

        private bool CompareProducts(Product first, Product second)
        {
            if (first.PriceWithoutDDS == second.PriceWithoutDDS &&
                first.ProcentDDS == second.ProcentDDS &&
                first.Barcode == second.Barcode &&
                first.Name == second. Name)
            {
                return true;
            }
            return false;
        }

        private void ClearFields()
        {
            productName.Text = "";
            productProcentegeDDS.Text = "";
            productPrice.Text = "";
            Barkod.Text = "";
        }
    }
}
