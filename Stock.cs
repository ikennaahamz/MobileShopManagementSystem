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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\MobileShopManagementSystem\MobileShopManagementSystem\phone.mdf;Integrated Security=True;User Instance=True");             
            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select model,ram,istorage,estorage,display,rearc,frontc,finger,sim,network,price from Phones where phone_id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label13.Text = dr.GetValue(0).ToString();
                        label14.Text = dr.GetValue(1).ToString();
                        label15.Text = dr.GetValue(2).ToString();
                        label16.Text = dr.GetValue(3).ToString();
                        label17.Text = dr.GetValue(4).ToString();
                        label18.Text = dr.GetValue(5).ToString();
                        label19.Text = dr.GetValue(6).ToString();
                        label20.Text = dr.GetValue(7).ToString();
                        label21.Text = dr.GetValue(8).ToString();
                        label22.Text = dr.GetValue(9).ToString();
                        label23.Text = dr.GetValue(10).ToString();
                    }
                    else
                    {
                        MessageBox.Show(" Sorry !! This Phone ID, " + textBox1.Text + " is INVALID. Please Check Phone Id.. ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }
    }
}
