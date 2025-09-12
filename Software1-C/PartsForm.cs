using System.CodeDom.Compiler;

namespace Software1_C
{
    internal partial class PartsForm : Form
    {
        internal Part? NewPart { get; private set; }

        private bool IsInHouse = true;
        private int ID;
        private string? NewName;
        private decimal? Price;
        private int? InStock;
        private int Min = 0;
        private int Max = int.MaxValue;
        private int? MachineID;
        private string? NewCompanyName;

        internal PartsForm(int id)
        {
            this.ID = id;
            InitializeComponent();
        }

        internal PartsForm(Part oldPart)
        {
            if(oldPart is Inhouse inhousePart)
            {
                this.IsInHouse = true;
                this.MachineID = inhousePart.MachineID;
            }
            if(oldPart is OutSourced outSourcedPart)
            {
                this.IsInHouse = false;
                this.NewCompanyName = outSourcedPart.CompanyName;
            }

            this.ID = oldPart.PartID;
            this.NewName = oldPart.Name;
            this.Price = oldPart.Price;
            this.InStock = oldPart.InStock;
            this.Min = oldPart.Min;
            this.Max = oldPart.Max;

            InitializeComponent();
            this.populateFields();
        }

        private void populateFields()
        {
            if (IsInHouse)
            {
                this.inHouseRadioButton.Checked = true;
                this.outsourcedRadioButton.Checked = false;

                this.partSource.Text = "Machine ID";
                this.partSourceText.Text = this.MachineID?.ToString();
            } else
            {
                this.inHouseRadioButton.Checked = false;
                this.outsourcedRadioButton.Checked = true;

                this.partSource.Text = "Company Name";
                this.partSourceText.Text = this.NewCompanyName?.ToString();
            }

            this.idText.Text = this.ID.ToString();
            this.nameText.Text = this.NewName;
            this.inventoryText.Text = this.InStock.ToString();
            this.priceText.Text = this.Price.ToString();
            this.maxText.Text = this.Max.ToString();
            this.minText.Text = this.Min.ToString();
        }

        private void PartsForm_Load(object sender, EventArgs e)
        {
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.IsInHouse = true;
            this.partSource.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.IsInHouse = false;
            this.partSource.Text = "Company Name";
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            this.NewName = nameText.Text;
            this.canSave();
        }

        private void inventoryText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = int.Parse(inventoryText.Text);

                if(temp < this.Min)
                {
                    this.InStock = this.Min;
                    this.inventoryText.Text = this.Min.ToString();
                }
                if(temp > this.Max)
                {
                    this.InStock = this.Max;
                    this.inventoryText.Text = this.Max.ToString();
                }

                if (temp >= this.Min && temp <= this.Max)
                {
                    this.InStock = temp;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Inventory has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.InStock = null;
                inventoryText.Text = string.Empty;
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
                priceText.Text = string.Empty;
            }
            this.canSave();
        }

        private void maxText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = int.Parse(maxText.Text);

                if (temp >= this.Min)
                {
                    this.Max = temp;
                }
                if (temp < this.Min)
                {
                    this.Max = this.Min;
                    this.maxText.Text = this.Min.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Max has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Max = int.MaxValue;
                maxText.Text = string.Empty;
            }
            this.canSave();
        }

        private void minText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = int.Parse(minText.Text);

                if(temp <= this.Max)
                {
                    this.Min = temp;
                }
                if(temp > this.Max)
                {
                    this.Min = this.Max;
                    this.minText.Text = this.Max.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Min has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Min = 0;
                minText.Text = string.Empty;

            }
            this.canSave();
        }

        private void partSourceText_TextChanged(object sender, EventArgs e)
        {

            if (this.IsInHouse)
            {
                try
                {
                    this.MachineID = int.Parse(partSourceText.Text);
                    this.NewCompanyName = null;
                }
                catch (FormatException)
                {
                    MessageBox.Show("MachineID has to be an integer", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.MachineID = null;
                    partSourceText.Text = string.Empty;
                }
            }
            else
            {
                this.NewCompanyName = partSourceText.Text;
                this.MachineID = null;
            }

            this.canSave();
        }

        private void canSave()
        {
            // all fields are filed out
            if (this.NewName != null && this.Price != null && this.InStock != null && (this.MachineID != null || this.NewCompanyName != null))
            {
                if (this.InStock >= this.Min && this.InStock <= this.Max)
                {
                    saveButton.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Inventory needs to be between Max and Min", "Invalid Quantities", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 

            saveButton.Enabled = false;
        }

        private Part createInHousePart() {
            return new Inhouse(this.ID, this.NewName ?? "NA", this.Price ?? 0, this.InStock ?? 0, this.Min, this.Max, this.MachineID ?? 0);
        }
        private Part createOutSourcedPart()
        {
            return new OutSourced(this.ID, this.NewName ?? "NA", this.Price ?? 0, this.InStock ?? 0, this.Min, this.Max, this.NewCompanyName ?? "NA");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.NewPart = this.IsInHouse
                ? createInHousePart()
                : createOutSourcedPart();

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
