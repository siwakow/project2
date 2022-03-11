using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FurnitureStoreManagementSystemCSharp
{
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            
            this.custTableAdapter.Fill(this.furnitureDataSet6.cust);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicolaus\Desktop\FurnitureStoreManagementSystemCSharp\FurnitureStoreManagementSystemCSharp\furniture.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM cust";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
