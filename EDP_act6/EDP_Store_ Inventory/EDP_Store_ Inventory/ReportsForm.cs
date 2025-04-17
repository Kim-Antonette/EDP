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
    public partial class ReportsForm : Form
    {
        // Sample list of sales data (replace this with actual data from your database or another source)
        private List<Sale> salesData = new List<Sale>
        {
            new Sale { ProductName = "Laptop", Quantity = 2, Price = 1000, Category = "Electronics" },
            new Sale { ProductName = "Sofa", Quantity = 1, Price = 500, Category = "Furniture" },
            new Sale { ProductName = "T-Shirt", Quantity = 3, Price = 20, Category = "Clothing" },
            new Sale { ProductName = "Smartphone", Quantity = 5, Price = 600, Category = "Electronics" }
        };

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Adding items to the ComboBox
            cmbCategory.Items.Add("All Categories");
            cmbCategory.Items.Add("Electronics");
            cmbCategory.Items.Add("Furniture");
            cmbCategory.Items.Add("Clothing");

            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Get the selected category
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            List<Sale> filteredSales;

            if (selectedCategory == "All Categories")
            {
                // If "All Categories" is selected, show all sales
                filteredSales = GetAllSalesData();
            }
            else
            {
                // Filter sales by the selected category
                filteredSales = GetSalesByCategory(selectedCategory);
            }

            // Update DataGridView with filtered sales data
            dgvReports.DataSource = filteredSales;
        }

        // Get all sales data
        private List<Sale> GetAllSalesData()
        {
            return salesData; // Return the complete sales data
        }

        // Get sales data filtered by category
        private List<Sale> GetSalesByCategory(string category)
        {
            return salesData.Where(s => s.Category == category).ToList(); // Filter sales by category
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current ReportsForm
            Dashboard dashboard = new Dashboard(); // Create an instance of the Dashboard
            dashboard.Show(); // Show the dashboard
        }
    }

    // Sale class definition
    public class Sale
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}

