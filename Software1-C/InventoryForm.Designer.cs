namespace Software1_C
{
    partial class InventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            partsGridView = new DataGridView();
            productsGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            searchParts = new TextBox();
            searchProducts = new TextBox();
            searchPartsButton = new Button();
            searchProductsButton = new Button();
            addParts = new Button();
            modifyParts = new Button();
            deleteParts = new Button();
            deleteProducts = new Button();
            modifyProducts = new Button();
            addProducts = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)partsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // partsGridView
            // 
            partsGridView.AllowUserToAddRows = false;
            partsGridView.AllowUserToDeleteRows = false;
            partsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsGridView.Location = new Point(33, 113);
            partsGridView.Name = "partsGridView";
            partsGridView.ReadOnly = true;
            partsGridView.RowHeadersVisible = false;
            partsGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            partsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsGridView.ShowCellToolTips = false;
            partsGridView.ShowEditingIcon = false;
            partsGridView.Size = new Size(755, 382);
            partsGridView.TabIndex = 0;
            partsGridView.CellContentClick += partsGridView_CellContentClick;
            // 
            // productsGridView
            // 
            productsGridView.AllowUserToAddRows = false;
            productsGridView.AllowUserToDeleteRows = false;
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(869, 113);
            productsGridView.Name = "productsGridView";
            productsGridView.RowHeadersVisible = false;
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGridView.ShowCellToolTips = false;
            productsGridView.ShowEditingIcon = false;
            productsGridView.Size = new Size(838, 382);
            productsGridView.TabIndex = 1;
            productsGridView.CellContentClick += productsGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 89);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 2;
            label1.Text = "Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(869, 89);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 3;
            label2.Text = "Products";
            // 
            // searchParts
            // 
            searchParts.Location = new Point(380, 84);
            searchParts.Name = "searchParts";
            searchParts.Size = new Size(408, 23);
            searchParts.TabIndex = 4;
            searchParts.TextChanged += searchParts_TextChanged;
            // 
            // searchProducts
            // 
            searchProducts.Location = new Point(1265, 84);
            searchProducts.Name = "searchProducts";
            searchProducts.Size = new Size(442, 23);
            searchProducts.TabIndex = 5;
            searchProducts.TextChanged += searchProducts_TextChanged;
            // 
            // searchPartsButton
            // 
            searchPartsButton.BackColor = SystemColors.ActiveBorder;
            searchPartsButton.FlatAppearance.BorderColor = Color.DimGray;
            searchPartsButton.FlatAppearance.BorderSize = 2;
            searchPartsButton.Location = new Point(307, 84);
            searchPartsButton.Margin = new Padding(0);
            searchPartsButton.Name = "searchPartsButton";
            searchPartsButton.Size = new Size(58, 26);
            searchPartsButton.TabIndex = 6;
            searchPartsButton.Tag = "searchParts";
            searchPartsButton.Text = "Search";
            searchPartsButton.UseVisualStyleBackColor = false;
            searchPartsButton.Click += searchPartsButton_Click;
            // 
            // searchProductsButton
            // 
            searchProductsButton.BackColor = SystemColors.ActiveBorder;
            searchProductsButton.FlatAppearance.BorderColor = Color.DimGray;
            searchProductsButton.FlatAppearance.BorderSize = 2;
            searchProductsButton.Location = new Point(1193, 81);
            searchProductsButton.Margin = new Padding(0);
            searchProductsButton.Name = "searchProductsButton";
            searchProductsButton.Size = new Size(58, 26);
            searchProductsButton.TabIndex = 7;
            searchProductsButton.Tag = "searchProducts";
            searchProductsButton.Text = "Search";
            searchProductsButton.UseVisualStyleBackColor = false;
            searchProductsButton.Click += searchProductsButton_Click;
            // 
            // addParts
            // 
            addParts.BackColor = SystemColors.ActiveBorder;
            addParts.Font = new Font("Segoe UI", 11F);
            addParts.Location = new Point(510, 530);
            addParts.Margin = new Padding(0);
            addParts.Name = "addParts";
            addParts.Size = new Size(75, 41);
            addParts.TabIndex = 8;
            addParts.Text = "Add";
            addParts.UseVisualStyleBackColor = false;
            addParts.Click += addParts_Click;
            // 
            // modifyParts
            // 
            modifyParts.BackColor = SystemColors.ActiveBorder;
            modifyParts.Font = new Font("Segoe UI", 11F);
            modifyParts.Location = new Point(613, 530);
            modifyParts.Margin = new Padding(0);
            modifyParts.Name = "modifyParts";
            modifyParts.Size = new Size(75, 41);
            modifyParts.TabIndex = 9;
            modifyParts.Text = "Modify";
            modifyParts.UseVisualStyleBackColor = false;
            modifyParts.Click += modifyParts_Click;
            // 
            // deleteParts
            // 
            deleteParts.BackColor = SystemColors.ActiveBorder;
            deleteParts.Font = new Font("Segoe UI", 11F);
            deleteParts.Location = new Point(713, 530);
            deleteParts.Margin = new Padding(0);
            deleteParts.Name = "deleteParts";
            deleteParts.Size = new Size(75, 41);
            deleteParts.TabIndex = 10;
            deleteParts.Text = "Delete";
            deleteParts.UseVisualStyleBackColor = false;
            deleteParts.Click += DeleteParts_Click;
            // 
            // deleteProducts
            // 
            deleteProducts.BackColor = SystemColors.ActiveBorder;
            deleteProducts.Font = new Font("Segoe UI", 11F);
            deleteProducts.Location = new Point(1634, 530);
            deleteProducts.Margin = new Padding(0);
            deleteProducts.Name = "deleteProducts";
            deleteProducts.Size = new Size(75, 41);
            deleteProducts.TabIndex = 13;
            deleteProducts.Text = "Delete";
            deleteProducts.UseVisualStyleBackColor = false;
            deleteProducts.Click += deleteProducts_Click;
            // 
            // modifyProducts
            // 
            modifyProducts.BackColor = SystemColors.ActiveBorder;
            modifyProducts.Font = new Font("Segoe UI", 11F);
            modifyProducts.Location = new Point(1534, 530);
            modifyProducts.Margin = new Padding(0);
            modifyProducts.Name = "modifyProducts";
            modifyProducts.Size = new Size(75, 41);
            modifyProducts.TabIndex = 12;
            modifyProducts.Text = "Modify";
            modifyProducts.UseVisualStyleBackColor = false;
            modifyProducts.Click += modifyProducts_Click;
            // 
            // addProducts
            // 
            addProducts.BackColor = SystemColors.ActiveBorder;
            addProducts.Font = new Font("Segoe UI", 11F);
            addProducts.Location = new Point(1431, 530);
            addProducts.Margin = new Padding(0);
            addProducts.Name = "addProducts";
            addProducts.Size = new Size(75, 41);
            addProducts.TabIndex = 11;
            addProducts.Text = "Add";
            addProducts.UseVisualStyleBackColor = false;
            addProducts.Click += addProducts_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.ActiveBorder;
            exit.Font = new Font("Segoe UI", 11F);
            exit.Location = new Point(1634, 643);
            exit.Margin = new Padding(0);
            exit.Name = "exit";
            exit.Size = new Size(75, 41);
            exit.TabIndex = 14;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 752);
            Controls.Add(exit);
            Controls.Add(deleteProducts);
            Controls.Add(modifyProducts);
            Controls.Add(addProducts);
            Controls.Add(deleteParts);
            Controls.Add(modifyParts);
            Controls.Add(addParts);
            Controls.Add(searchProductsButton);
            Controls.Add(searchPartsButton);
            Controls.Add(searchProducts);
            Controls.Add(searchParts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productsGridView);
            Controls.Add(partsGridView);
            Name = "InventoryForm";
            Text = "Main Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)partsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView partsGridView;
        private DataGridView productsGridView;
        private Label label1;
        private Label label2;
        private TextBox searchParts;
        private TextBox searchProducts;
        private Button searchPartsButton;
        private Button searchProductsButton;
        private Button addParts;
        private Button modifyParts;
        private Button deleteParts;
        private Button deleteProducts;
        private Button modifyProducts;
        private Button addProducts;
        private FileSystemWatcher fileSystemWatcher1;
        private Button exit;
    }
}
