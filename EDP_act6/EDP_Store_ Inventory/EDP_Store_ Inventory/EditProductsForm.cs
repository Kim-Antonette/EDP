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
    public partial class EditProductsForm : Form
    {
        // Store the product to be edited
        public Product EditedProduct { get; private set; }

        // Constructor to initialize the form with a product to edit
        public EditProductsForm(Product productToEdit)
        {
            InitializeComponent();

            // Populate the textboxes with the product data
            txtName.Text = productToEdit.ProductName;
            txtCategory.Text = productToEdit.Category;
            txtPrice.Text = productToEdit.Price.ToString();
            txtQuantity.Text = productToEdit.Quantity.ToString();

            // Store the product to edit
            EditedProduct = productToEdit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Attempt to parse and update the product with the values entered in the textboxes
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Update the product
            EditedProduct.ProductName = txtName.Text;
            EditedProduct.Category = txtCategory.Text;
            EditedProduct.Price = price;
            EditedProduct.Quantity = quantity;

            // Show a confirmation message
            MessageBox.Show("Product has been successfully updated!", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form and return DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        // Optional: Handle the form load if needed
        private void EditProductsForm_Load(object sender, EventArgs e)
        {
            // Initialization code can go here if necessary
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Attempt to parse and update the product with the values entered in the textboxes
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Update the product
            EditedProduct.ProductName = txtName.Text;
            EditedProduct.Category = txtCategory.Text;
            EditedProduct.Price = price;
            EditedProduct.Quantity = quantity;

            // Show confirmation message here 👇
            MessageBox.Show("Product updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form and return DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
