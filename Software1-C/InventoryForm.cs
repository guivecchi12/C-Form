using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Software1_C
{
    public partial class InventoryForm : Form
    {
        private readonly Inventory inventory = new Inventory();
        private BindingSource partsBindingSource = new BindingSource();
        private BindingSource productsBindingSource = new BindingSource();

        public InventoryForm()
        {
            // Initialize Controls
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Add a couple initial parts
            Inhouse part1 = new Inhouse(0, "Wheel", 12.11M, 15, 5, 25, 1);
            OutSourced part2 = new OutSourced(1, "Pedal", 8.22M, 11, 5, 25, "Company1");
            Inhouse part3 = new Inhouse(2, "Chain", 8.33M, 12, 5, 25, 2);
            OutSourced part4 = new OutSourced(3, "Seat", 4.55M, 8, 2, 15, "Company1");

            this.inventory.addPart(part1);
            this.inventory.addPart(part2);
            this.inventory.addPart(part3);
            this.inventory.addPart(part4);

            // Add a couple initial products
            Product redBike = new Product(0, "Red Bicycle", 11.44M, 15, 1, 25);
            redBike.addAssociatedPart(part2);
            redBike.addAssociatedPart(part4);

            Product yellowBike = new Product(1, "Yellow Bicycle", 9.66M, 19, 1, 20);
            yellowBike.addAssociatedPart(part1);
            yellowBike.addAssociatedPart(part3);

            Product blueBike = new Product(2, "Blue Bicycle", 12.77M, 5, 1, 25);

            this.inventory.addProduct(redBike);
            this.inventory.addProduct(yellowBike);
            this.inventory.addProduct(blueBike);
        }
        private void InitializePartsTable()
        {
            this.partsBindingSource.DataSource = this.inventory.AllParts;
            this.partsGridView.DataSource = this.partsBindingSource;
            this.partsGridView.Columns["PartID"].HeaderText = "Part ID";
            this.partsGridView.Columns["InStock"].HeaderText = "Inventory";
            this.partsGridView.Columns["InStock"].DisplayIndex = 2;
        }

        private void InitializeProductsTable()
        {
            this.productsBindingSource.DataSource = this.inventory.Products;
            this.productsGridView.DataSource = this.productsBindingSource;
            this.productsGridView.Columns["ProductID"].HeaderText = "Product ID";
            this.productsGridView.Columns["InStock"].HeaderText = "Inventory";
            this.productsGridView.Columns["InStock"].DisplayIndex = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializePartsTable();
            InitializeProductsTable();
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            string search = this.searchParts.Text.Trim();

            if (string.IsNullOrEmpty(search)) {
                this.partsBindingSource.DataSource = this.inventory.AllParts;
            }
            else
            {
                var filteredList = this.inventory.AllParts.Where(part =>  part.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                this.partsBindingSource.DataSource = new BindingList<Part>(filteredList);
            }
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            string search = this.searchParts.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                this.productsBindingSource.DataSource = this.inventory.Products;
            }
            else
            {
                var filteredList = this.inventory.Products.Where(part => part.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                this.productsBindingSource.DataSource = new BindingList<Product>(filteredList);
            }
        }


        private void addParts_Click(object sender, EventArgs e)
        {

            PartsForm partForm = new PartsForm(this.inventory.nextAvailablePartID());

            if (partForm.ShowDialog() == DialogResult.OK && partForm.NewPart != null)
            {
                this.inventory.addPart(partForm.NewPart);
            }
        }


        private void modifyParts_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count > 0) {
                // Get the selected row.
                DataGridViewRow selectedRow = partsGridView.SelectedRows[0];

                // Get the part.
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                PartsForm partForm = new PartsForm(selectedPart);

                if (partForm.ShowDialog() == DialogResult.OK && partForm.NewPart != null)
                {
                    Part newPart = partForm.NewPart;
                    int id = newPart.PartID;

                    this.inventory.updatePart(id, newPart);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DeleteParts_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count > 0)
            {
                // Get the selected row.
                DataGridViewRow selectedRow = partsGridView.SelectedRows[0];

                // Get the part.
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                inventory.deletePart(selectedPart);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addProducts_Click(object sender, EventArgs e)
        {

        }

        private void modifyProducts_Click(object sender, EventArgs e)
        {

        }

        private void deleteProducts_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
