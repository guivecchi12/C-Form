using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Software1_C
{
    public partial class ProductForm : Form
    {
        internal Product Product { get; set; }
        private BindingList<Part> AllParts;

        private BindingSource candidateSource = new BindingSource();
        private BindingSource associatedSource = new BindingSource();

        internal ProductForm(int id, BindingList<Part> allParts)
        {
            this.AllParts = allParts;
            this.Product = new Product(id);

            InitializeComponent();
            this.initializeTables();
        }

        internal ProductForm(Product oldProduct, BindingList<Part> allParts)
        {
            this.Product = oldProduct;
            this.AllParts = allParts;

            InitializeComponent();
            this.initializeTables();
            this.populateFields();
        }

        private void populateFields()
        {
            this.idTextBox.Text = this.Product.ProductID.ToString();
            this.nameTextBox.Text = this.Product.Name;
            this.priceTextBox.Text = this.Product.Price.ToString();
            this.inventoryTextBox.Text = this.Product.InStock.ToString();
            this.minTextBox.Text = this.Product.Min.ToString();
            this.maxTextBox.Text = this.Product.Max.ToString();
        }

        private void initializeTables()
        {
            this.initializeCandidateTable();
            this.initializeAssociatedTable();
        }

        private void initializeCandidateTable()
        {
            this.candidateSource.DataSource = this.AllParts;
            this.candidateGridView.DataSource = this.candidateSource;

            this.candidateGridView.Columns["PartID"].HeaderText = "Part ID";
            this.candidateGridView.Columns["InStock"].HeaderText = "Inventory";
            this.candidateGridView.Columns["InStock"].DisplayIndex = 2;
        }

        private void initializeAssociatedTable()
        {
            this.associatedSource.DataSource = this.Product.AssociatedParts;
            this.associatedGridView.DataSource = this.associatedSource;

            this.associatedGridView.Columns["PartID"].HeaderText = "Part ID";
            this.associatedGridView.Columns["InStock"].HeaderText = "Inventory";
            this.associatedGridView.Columns["InStock"].DisplayIndex = 2;
        }

        private void searchCandidate_Click(object sender, EventArgs e)
        {
            string search = this.candidateTextBox.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                this.candidateSource.DataSource = this.AllParts;
            }
            else
            {
                var filteredList = this.AllParts.Where(part => part.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                this.candidateSource.DataSource = new BindingList<Part>(filteredList);
            }
        }

        private void candidateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(candidateTextBox.Text.Trim()))
            {
                this.candidateSource.DataSource = this.AllParts;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Product.Name = nameTextBox.Text;
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = inventoryTextBox.Text;
                if (!string.IsNullOrEmpty(text))
                    Product.InStock = int.Parse(text);
            }
            catch (FormatException)
            {
                {
                    MessageBox.Show("Inventory has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Product.InStock = 0;
                    inventoryTextBox.Text = string.Empty;
                }
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = priceTextBox.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    this.Product.Price = decimal.Parse(priceTextBox.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price has to be an decimal", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Product.Price = 0;
                priceTextBox.Text = string.Empty;
            }
            this.canSave();
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = maxTextBox.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    int temp = int.Parse(text);

                    if (temp >= this.Product.Min)
                    {
                        this.Product.Max = temp;
                    }
                    if (temp < this.Product.Min)
                    {
                        this.Product.Max = this.Product.Min;
                        this.maxTextBox.Text = this.Product.Min.ToString();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Max has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Product.Max = int.MaxValue;
                maxTextBox.Text = string.Empty;
            }
            this.canSave();
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = minTextBox.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    int temp = int.Parse(text);

                    if (temp <= this.Product.Max)
                    {
                        this.Product.Min = temp;
                    }
                    if (temp > this.Product.Max)
                    {
                        this.Product.Min = this.Product.Max;
                        this.minTextBox.Text = this.Product.Max.ToString();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Min has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Product.Min = 0;
                minTextBox.Text = string.Empty;

            }
            this.canSave();
        }

        private void canSave()
        {
            bool emptyName = string.IsNullOrEmpty(this.Product.Name);
            bool emptyInventory = string.IsNullOrEmpty(this.inventoryTextBox.Text);
            bool emptyPrice = string.IsNullOrEmpty(this.priceTextBox.Text);
            bool emptyMax = string.IsNullOrEmpty(this.maxTextBox.Text);
            bool emptyMin = string.IsNullOrEmpty(this.minTextBox.Text);

            bool noEmptyField = !emptyName && !emptyInventory && !emptyPrice && !emptyMax && !emptyMin;

            if (noEmptyField)
            {
                if (this.Product.InStock >= this.Product.Min && this.Product.InStock <= this.Product.Max)
                {
                    saveButton.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Inventory needs to be between Max and Min", "Invalid Quantities", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (candidateGridView.SelectedRows.Count > 0)
            {
                // Get the selected row.
                DataGridViewRow selectedRow = candidateGridView.SelectedRows[0];

                // Get the part.
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                if (Product.lookupAssociatedPart(selectedPart.PartID) == null)
                {
                    Product.addAssociatedPart(selectedPart);
                }

            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (associatedGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = associatedGridView.SelectedRows[0];

                Part selectedPart = (Part)selectedRow.DataBoundItem;

                Product.removeAssociatedPart(selectedPart.PartID);
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
