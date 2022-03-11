using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FurnitureStoreManagementSystemCSharp
{
    public partial class SearchSalesProducts : Form
    {
        public SearchSalesProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicolaus\Desktop\FurnitureStoreManagementSystemCSharp\FurnitureStoreManagementSystemCSharp\furniture.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM sale_f where c_id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void SearchSalesProducts_Load(object sender, EventArgs e)
        {
            
            this.sale_fTableAdapter.Fill(this.furnitureDataSet5.sale_f);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicolaus\Desktop\FurnitureStoreManagementSystemCSharp\FurnitureStoreManagementSystemCSharp\furniture.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM sale_f";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
