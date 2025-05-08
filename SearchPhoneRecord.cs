ppusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopManagementSystem
{
    public partial class SearchPhoneRecord : Form
    {
        public SearchPhoneRecord()
        {
            InitializeComponent();
        }

        private void SearchPhoneRecord_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\N\documents\visual studio 2010\Projects\MobileShopManagementSystem\MobileShopManagementSystem\phone.mdf;Integrated Security=True;User Instance=True"))
            {

                string str = "SELECT * FROM Phones";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }

            // TODO: This line of code loads data into the 'phoneDataSet.Phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.phoneDataSet.Phones);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\N\documents\visual studio 2010\Projects\MobileShopManagementSystem\MobileShopManagementSystem\phone.mdf;Integrated Security=True;User Instance=True"))
            {

                string str = "SELECT * FROM Phones WHERE phone_id = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
            
            textBox1.Text = "";
        }
    }
}
