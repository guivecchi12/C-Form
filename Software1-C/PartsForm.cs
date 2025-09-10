using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Software1_C
{
    internal partial class PartsForm : Form
    {
        internal Part? NewPart { get; private set; }

        private bool IsInHouse = false;
        private int ID;
        private string? Name;
        private decimal? Price;
        private int? InStock;
        private int? Min;
        private int? Max;
        private int? MachineID;
        private string? CompanyName;
        internal PartsForm(int id)
        {
            this.ID = id;
            InitializeComponent();
        }


        private void PartsForm_Load(object sender, EventArgs e)
        {
        }


        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.IsInHouse = true;
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.IsInHouse = false;
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            this.Name = nameText.Text;
            this.canSave();
        }

        private void inventoryText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.InStock = int.Parse(inventoryText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Inventory has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.InStock = null;
            }
            this.canSave();
        }

        private void priceText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Price = decimal.Parse(priceText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Price has to be an decimal", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Price = null;
            }
            this.canSave();
        }

        private void maxText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maxText.Text))
                {
                    this.Max = null;
                } else
                {
                    this.Max = int.Parse(priceText.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Max has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Max = null;
            }
            this.canSave();
        }

        private void minText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Min = int.Parse(priceText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Min has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Min = null;
            }
            this.canSave();
        }

        private void partSourceText_TextChanged(object sender, EventArgs e)
        {
           
            if (this.IsInHouse)
            {
                try
                {
                    this.MachineID = int.Parse(partSource.Text);
                    this.CompanyName = null;
                }
                catch (FormatException)
                {
                    MessageBox.Show("MachineID has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.MachineID = null;
                }
            } else
                {
                    this.CompanyName = partSource.Text;
                    this.MachineID = null;
                }
            
            this.canSave();
        }

        private void canSave()
        {
            // all fields are filed out
            if( this.Name != null && this.Price != null && this.InStock != null && this.Min != null && this.Max != null && (this.MachineID != null || this.CompanyName != null))
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saved" + " Name: " + this.Name);
            this.NewPart = this.IsInHouse 
                ? new Inhouse(this.ID, this.Name ?? "NA", this.Price ?? 0, this.InStock ?? 0, this.Min ?? 0, this.Max ?? 0, this.MachineID ?? 0) 
                : new OutSourced(this.ID, this.Name ?? "NA", this.Price ?? 0, this.InStock ?? 0, this.Min ?? 0, this.Max ?? 0, this.CompanyName ?? "NA");
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Cancel");
            MessageBox.Show("Name: " + this.Name);
            this.Close();
        }
    }
}
