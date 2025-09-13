namespace Software1_C
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            priceTextBox = new TextBox();
            maxTextBox = new TextBox();
            minTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            associatedGridView = new DataGridView();
            candidateGridView = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            searchCandidate = new Button();
            textBox5 = new TextBox();
            addButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)associatedGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candidateGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(114, 185);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(186, 23);
            idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(114, 228);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(186, 23);
            nameTextBox.TabIndex = 2;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(114, 272);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(186, 23);
            inventoryTextBox.TabIndex = 3;
            inventoryTextBox.TextChanged += inventoryTextBox_TextChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(114, 314);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(186, 23);
            priceTextBox.TabIndex = 4;
            priceTextBox.TextChanged += priceTextBox_TextChanged;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(88, 361);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(81, 23);
            maxTextBox.TabIndex = 5;
            maxTextBox.TextChanged += maxTextBox_TextChanged;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(261, 361);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(81, 23);
            minTextBox.TabIndex = 6;
            minTextBox.TextChanged += minTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(36, 188);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(36, 231);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(36, 275);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(36, 317);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(36, 364);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 11;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(206, 364);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 12;
            label7.Text = "Min";
            // 
            // associatedGridView
            // 
            associatedGridView.AllowUserToAddRows = false;
            associatedGridView.AllowUserToDeleteRows = false;
            associatedGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            associatedGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedGridView.Location = new Point(630, 523);
            associatedGridView.Name = "associatedGridView";
            associatedGridView.ReadOnly = true;
            associatedGridView.RowHeadersVisible = false;
            associatedGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            associatedGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedGridView.ShowCellToolTips = false;
            associatedGridView.ShowEditingIcon = false;
            associatedGridView.Size = new Size(612, 289);
            associatedGridView.TabIndex = 13;
            // 
            // candidateGridView
            // 
            candidateGridView.AllowUserToAddRows = false;
            candidateGridView.AllowUserToDeleteRows = false;
            candidateGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            candidateGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidateGridView.Location = new Point(630, 129);
            candidateGridView.Name = "candidateGridView";
            candidateGridView.ReadOnly = true;
            candidateGridView.RowHeadersVisible = false;
            candidateGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            candidateGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candidateGridView.ShowCellToolTips = false;
            candidateGridView.ShowEditingIcon = false;
            candidateGridView.Size = new Size(612, 291);
            candidateGridView.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(630, 96);
            label8.Name = "label8";
            label8.Size = new Size(153, 21);
            label8.TabIndex = 15;
            label8.Text = "All candidate Parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(641, 487);
            label9.Name = "label9";
            label9.Size = new Size(268, 21);
            label9.TabIndex = 16;
            label9.Text = "Parts Associated with this Product";
            // 
            // searchCandidate
            // 
            searchCandidate.BackColor = SystemColors.ActiveBorder;
            searchCandidate.Location = new Point(893, 67);
            searchCandidate.Name = "searchCandidate";
            searchCandidate.Size = new Size(75, 31);
            searchCandidate.TabIndex = 17;
            searchCandidate.Text = "Search";
            searchCandidate.UseVisualStyleBackColor = false;
            searchCandidate.Click += searchCandidate_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(986, 72);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(256, 23);
            textBox5.TabIndex = 18;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ActiveBorder;
            addButton.Location = new Point(1167, 435);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 31);
            addButton.TabIndex = 19;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ActiveBorder;
            deleteButton.Location = new Point(1167, 833);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 31);
            deleteButton.TabIndex = 20;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ActiveBorder;
            saveButton.Enabled = false;
            saveButton.Location = new Point(1081, 889);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 31);
            saveButton.TabIndex = 21;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.ActiveBorder;
            cancelButton.Location = new Point(1167, 889);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 31);
            cancelButton.TabIndex = 22;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 995);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(textBox5);
            Controls.Add(searchCandidate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(candidateGridView);
            Controls.Add(associatedGridView);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(minTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)associatedGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)candidateGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox inventoryTextBox;
        private TextBox priceTextBox;
        private TextBox maxTextBox;
        private TextBox minTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView associatedGridView;
        private DataGridView candidateGridView;
        private Label label8;
        private Label label9;
        private Button searchCandidate;
        private TextBox textBox5;
        private Button addButton;
        private Button deleteButton;
        private Button saveButton;
        private Button cancelButton;
    }
}