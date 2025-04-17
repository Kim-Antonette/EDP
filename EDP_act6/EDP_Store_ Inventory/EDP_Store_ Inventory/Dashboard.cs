using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Store__Inventory
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            // Open the Products form
            ProductsForm productsForm = new ProductsForm();

            // Add event handler for when ProductsForm is closed
            productsForm.FormClosed += (s, args) =>
            {
                this.Show(); // Show the Dashboard again after ProductsForm is closed
            };

            // Hide the Dashboard and show the ProductsForm
            this.Hide();
            productsForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            // Open the Sales form
            SalesForm salesForm = new SalesForm();
            salesForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Open the Reports form
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
