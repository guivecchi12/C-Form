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
        }

        private void initializeTables()
        {
            this.candidateSource.DataSource = this.AllParts;
            this.candidateGridView.DataSource = this.candidateSource;

            this.associatedSource.DataSource = this.Product;
            this.associatedGridView.DataSource = this.associatedSource;
        }

        private void searchCandidate_Click(object sender, EventArgs e)
        {

        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Product.Name = nameTextBox.Text;
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

               Product.InStock = int.Parse(this.inventoryTextBox.Text);
            }
            catch (FormatException) {
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
                this.Product.Price = decimal.Parse(priceTextBox.Text);
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
                int temp = int.Parse(maxTextBox.Text);

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
                int temp = int.Parse(minTextBox.Text);

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
            if (this.Product.Name != string.Empty && this.Product.InStock > 0 && this.Product.Price > 0 && this.Product.Max > 0)
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


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

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
