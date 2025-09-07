using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Software1_C
{
    public partial class InventoryManagement : Form
    {
        private DataGridView dataGridView;
        private Button addButton;
        private Button modifyButton;
        private Button deleteButton;
        private DataTable partsTable;
        private DataTable productsTable;
        private Button exit;
        public InventoryManagement()
        {
            // Initialize Controls
            InitializeComponent();
        }

        private void InitializePartsTable()
        {
            partsTable = new DataTable("MyData");

            partsTable.Columns.Add("Part ID");
            partsTable.Columns.Add("Name");
            partsTable.Columns.Add("Inventory");
            partsTable.Columns.Add("Price");
            partsTable.Columns.Add("Min");
            partsTable.Columns.Add("Max");

            partsTable.Rows.Add(0, "Wheel", 15, 12.11, 5, 25);
            partsTable.Rows.Add(1, "Pedal", 11, 8.22, 5, 25);
            partsTable.Rows.Add(2, "Chain", 12, 8.33, 5, 25);
            partsTable.Rows.Add(3, "Seat", 8, 4.55, 2, 15);

            partsGridView.DataSource = partsTable;

        }

        private void InitializeProductsTable()
        {
            productsTable = new DataTable("MyData");

            productsTable.Columns.Add("Part ID");
            productsTable.Columns.Add("Name");
            productsTable.Columns.Add("Inventory");
            productsTable.Columns.Add("Price");
            productsTable.Columns.Add("Min");
            productsTable.Columns.Add("Max");

            productsTable.Rows.Add(0, "Red Bicycle", 15, 11.44, 1, 25);
            productsTable.Rows.Add(1, "Yellow Bicycle", 19, 9.66, 1, 20);
            productsTable.Rows.Add(2, "Blue Bicycle", 5, 12.77, 1, 25);

            productsGridView.DataSource = productsTable;
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
            Part partForm = new Part();

            if (partForm.ShowDialog() == DialogResult.OK) { 
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
