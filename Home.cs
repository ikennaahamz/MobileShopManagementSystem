husing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPhone obj1 = new NewPhone();
            obj1.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers obj2 = new Customers();
            obj2.ShowDialog();
        }

        private void viewPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock obj3 = new Stock();
            obj3.ShowDialog();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 obj4 = new Form2();
            obj4.ShowDialog();
        }

        private void deletePhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePhoneRecord obj6 = new DeletePhoneRecord();
            obj6.ShowDialog();
        }

        private void searchPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPhoneRecord obj7 = new SearchPhoneRecord();
            obj7.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            
        }
    }
}
