using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Software1_C
{
    public partial class InventoryForm : Form
    {
        private Inventory inventory = new Inventory();
        private DataTable partsTable = new DataTable("partsTable");
        private DataTable productsTable = new DataTable("productsTable");

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

            this.partsTable.Columns.Add("Part ID");
            this.partsTable.Columns.Add("Name");
            this.partsTable.Columns.Add("Inventory");
            this.partsTable.Columns.Add("Price");
            this.partsTable.Columns.Add("Min");
            this.partsTable.Columns.Add("Max");


            foreach (Part part in inventory.AllParts)
            {
                this.partsTable.Rows.Add(part.PartID, part.Name, part.InStock, part.Price, part.Min, part.Max);
            }

            partsGridView.DataSource = this.partsTable;

        }

        private void InitializeProductsTable()
        {
            this.productsTable.Columns.Add("Product ID");
            this.productsTable.Columns.Add("Name");
            this.productsTable.Columns.Add("Inventory");
            this.productsTable.Columns.Add("Price");
            this.productsTable.Columns.Add("Min");
            this.productsTable.Columns.Add("Max");

            foreach (Product product in inventory.Products)
            {
                this.productsTable.Rows.Add(product.ProductID, product.Name, product.InStock, product.Price, product.Min, product.Max);
            }

            productsGridView.DataSource = this.productsTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializePartsTable();
            InitializeProductsTable();

        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {

        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {

        }

        private void searchParts_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchProducts_TextChanged(object sender, EventArgs e)
        {

        }

        private void partsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addParts_Click(object sender, EventArgs e)
        {
            PartsForm partForm = new PartsForm();

            if (partForm.ShowDialog() == DialogResult.OK)
            {
                partsGridView.Rows.Add(partForm);
            }
        }

        private void modifyParts_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count > 0) { }
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

                // Get the corresponding DataRow from the DataTable.
                DataRow dataRow = ((DataRowView)selectedRow.DataBoundItem).Row;

                // Remove the row from the DataTable. This will automatically update the DataGridView.
                dataRow.Delete();

                MessageBox.Show("Row deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
