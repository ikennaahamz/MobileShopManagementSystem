using System;
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
    public partial class DeletePhoneRecord : Form
    {
        public DeletePhoneRecord()
        {
            InitializeComponent();
        }

        private void DeletePhoneRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneDataSet1.Phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.phoneDataSet1.Phones);
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\MobileShopManagementSystem\MobileShopManagementSystem\phone.mdf;Integrated Security=True;User Instance=True"))
            {

                string str = "SELECT * FROM Phones";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\MobileShopManagementSystem\MobileShopManagementSystem\phone.mdf;Integrated Security=True;User Instance=True");
                con.Open();

                string str = "DELETE FROM Phones WHERE phone_id = '" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Phone Record Delete Successfully");

                using (SqlConnection newcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\MobileShopManagementSystem\MobileShopManagementSystem\phone.mdf;Integrated Security=True;User Instance=True"))
                {
                    string str1 = "SELECT * from Phones";
                    SqlCommand cmd1 = new SqlCommand(str1, newcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Please Enter Phone Id..");
            }
        }
    }
}
