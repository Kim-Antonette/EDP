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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string action = dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value);

                if (action == "Edit")
                {
                    // Create a dummy product for now — later, fetch from your actual list
                    Product selectedProduct = new Product
                    {
                        ID = productId,
                        ProductName = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Category = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        Price = Convert.ToDecimal(dgvProducts.Rows[e.RowIndex].Cells[3].Value),
                        Quantity = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[4].Value)
                    };

                    EditProductsForm editForm = new EditProductsForm(selectedProduct);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update DataGridView with new values
                        dgvProducts.Rows[e.RowIndex].Cells[1].Value = selectedProduct.ProductName;
                        dgvProducts.Rows[e.RowIndex].Cells[2].Value = selectedProduct.Category;
                        dgvProducts.Rows[e.RowIndex].Cells[3].Value = selectedProduct.Price;
                        dgvProducts.Rows[e.RowIndex].Cells[4].Value = selectedProduct.Quantity;

                        MessageBox.Show("Product updated!");
                    }
                }
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            List<Product> products = GetProducts(); // Or however you fetch data

            foreach (var product in products)
            {
                dgvProducts.Rows.Add(product.ID, product.ProductName, product.Category, product.Price, product.Quantity, "Edit", "Delete");
            }
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
    {
        new Product { ID = 1, ProductName = "Laptop", Quantity = 5, Price = 89.99m, Category = "Laptop" },
        new Product { ID = 2, ProductName = "Mouse", Quantity = 10, Price = 25.50m, Category = "Electronics" },
        new Product { ID = 3, ProductName = "Keyboard", Quantity = 40, Price = 120.00m, Category = "Electronics" }
    };
        }
    }
}
