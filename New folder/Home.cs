using System;
using System.Windows.Forms;

namespace FurnitureStoreManagementSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products obj = new FurnitureStoreManagementSystemCSharp.Products();
            obj.ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer obj = new FurnitureStoreManagementSystemCSharp.Customer();
            obj.ShowDialog();
        }

        private void addPurchasedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase obj = new FurnitureStoreManagementSystemCSharp.Purchase();
            obj.ShowDialog();
        }

        private void searchDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPurchasedProducts obj = new FurnitureStoreManagementSystemCSharp.SearchPurchasedProducts();
            obj.ShowDialog();
        }

        private void addSaledDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale obj = new FurnitureStoreManagementSystemCSharp.Sale();
            obj.ShowDialog();
        }

        private void searchDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchSalesProducts obj = new FurnitureStoreManagementSystemCSharp.SearchSalesProducts();
            obj.ShowDialog();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProduct obj = new FurnitureStoreManagementSystemCSharp.SearchProduct();
            obj.ShowDialog();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomers obj = new FurnitureStoreManagementSystemCSharp.ViewCustomers();
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new FurnitureStoreManagementSystemCSharp.Form1();
            obj.ShowDialog();
        }
    }
}
