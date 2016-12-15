using Faktura.Models;
using FakturaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaDesign
{
    class Queries
    {
        FakturaContext context = new FakturaContext();

        public List<Firm> getAllFirms()
        {
            List<Firm> firmNames = context.Firms.ToList();
            return firmNames;
        }
       
        public Firm getFirmInfo(string name)
        {
            return context.Firms.Select(f => f).Where(f => f.Name == name).FirstOrDefault();
        }

        public List<Product> getAllProducts()
        {
            List<Product> products = context.Products.ToList();
            return products;
        }

        //public Product getProductInfo(string name)
        //{
        //    return context.Products.Select(f => f).Where(f => f.Name == name).FirstOrDefault();
        //}

        public void addProduct(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't add product");
            }
        }

        public void addFirm(Firm firm)
        {
            try
            {
                context.Firms.Add(firm);
                context.SaveChanges();
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't add firm");
            }
        }

        public void removeProductByName(string name)
        {
            
            Product pr = context.Products.Where(p => p.Name == name).First();
            if (pr != null)
            {
                removeProduct(pr);
            }
        }

        public bool checkIfProductExists(string productName)
        {
            var found = context.Products.FirstOrDefault(p => p.Name == productName);
            if (found == null)
            {
                return false;
            }
            return true;
        }

        public int getProductId(string name)
        {
            try
            {
                return context.Products.Where(p => p.Name == name).Select(p => p.Id).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong product Name");
                return 0;
            }
        }

        public Product findProductByName(string name)
        {
            Product pr = null ;
            try
            {
                pr = context.Products.FirstOrDefault(p => p.Name == name);
            }
            catch (Exception)
            {
                
            }
            return pr;
        }

        public void removeProduct(Product product)
        {
            try
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Coudn't remove product");
            }
        }

        public void removeFirm(Firm firm)
        {
            try
            {
                context.Firms.Remove(firm);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't remove firm");
            }


        }

        public Firm findFirmByName(string name)
        {
            return context.Firms.FirstOrDefault(f => f.Name == name);
        }
    }
}
