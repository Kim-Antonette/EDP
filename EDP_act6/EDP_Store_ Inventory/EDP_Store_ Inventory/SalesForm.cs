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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void lblSalesTitle_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitSale_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            int quantity;
            decimal price;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(productName) ||
                !int.TryParse(txtQuantity.Text, out quantity) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter all fields correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add to DataGridView
            dgvSales.Rows.Add(productName, quantity, price.ToString("C"));

            // Clear inputs
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the DashboardForm
            Dashboard dashboard = new Dashboard();

            // Show the Dashboard form
            dashboard.Show();

            // Hide the SalesForm
            this.Hide();
        }
    }
}
