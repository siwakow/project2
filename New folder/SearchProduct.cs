using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FurnitureStoreManagementSystemCSharp
{
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicolaus\Desktop\FurnitureStoreManagementSystemCSharp\FurnitureStoreManagementSystemCSharp\furniture.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM product where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furnitureDataSet3.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.furnitureDataSet3.product);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicolaus\Desktop\FurnitureStoreManagementSystemCSharp\FurnitureStoreManagementSystemCSharp\furniture.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM product";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
