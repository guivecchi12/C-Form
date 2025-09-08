namespace Software1_C
{
    partial class PartsForm
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
            inHouseRadioButton = new RadioButton();
            OutsourcedRadioButton = new RadioButton();
            idText = new TextBox();
            nameText = new TextBox();
            inventoryText = new TextBox();
            priceText = new TextBox();
            maxText = new TextBox();
            partSourceText = new TextBox();
            minText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            partSource = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // inHouseRadioButton
            // 
            inHouseRadioButton.AutoSize = true;
            inHouseRadioButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            inHouseRadioButton.Location = new Point(141, 21);
            inHouseRadioButton.Name = "inHouseRadioButton";
            inHouseRadioButton.Size = new Size(91, 24);
            inHouseRadioButton.TabIndex = 1;
            inHouseRadioButton.TabStop = true;
            inHouseRadioButton.Text = "In-House";
            inHouseRadioButton.UseVisualStyleBackColor = true;
            inHouseRadioButton.CheckedChanged += inHouseRadioButton_CheckedChanged;
            // 
            // OutsourcedRadioButton
            // 
            OutsourcedRadioButton.AutoSize = true;
            OutsourcedRadioButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            OutsourcedRadioButton.Location = new Point(256, 21);
            OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            OutsourcedRadioButton.Size = new Size(108, 24);
            OutsourcedRadioButton.TabIndex = 2;
            OutsourcedRadioButton.TabStop = true;
            OutsourcedRadioButton.Text = "Outsourced";
            OutsourcedRadioButton.UseVisualStyleBackColor = true;
            OutsourcedRadioButton.CheckedChanged += OutsourcedRadioButton_CheckedChanged_1;
            // 
            // idText
            // 
            idText.BackColor = SystemColors.ControlLight;
            idText.BorderStyle = BorderStyle.FixedSingle;
            idText.Enabled = false;
            idText.Location = new Point(182, 85);
            idText.Name = "idText";
            idText.Size = new Size(197, 23);
            idText.TabIndex = 3;
            // 
            // nameText
            // 
            nameText.Location = new Point(182, 127);
            nameText.Name = "nameText";
            nameText.Size = new Size(197, 23);
            nameText.TabIndex = 4;
            nameText.TextChanged += nameText_TextChanged;
            // 
            // inventoryText
            // 
            inventoryText.Location = new Point(182, 169);
            inventoryText.Name = "inventoryText";
            inventoryText.Size = new Size(197, 23);
            inventoryText.TabIndex = 5;
            inventoryText.TextChanged += inventoryText_TextChanged;
            // 
            // priceText
            // 
            priceText.Location = new Point(182, 211);
            priceText.Name = "priceText";
            priceText.Size = new Size(197, 23);
            priceText.TabIndex = 6;
            priceText.TextChanged += priceText_TextChanged;
            // 
            // maxText
            // 
            maxText.Location = new Point(182, 257);
            maxText.Name = "maxText";
            maxText.Size = new Size(88, 23);
            maxText.TabIndex = 7;
            maxText.TextChanged += maxText_TextChanged;
            // 
            // partSourceText
            // 
            partSourceText.Location = new Point(182, 299);
            partSourceText.Name = "partSourceText";
            partSourceText.Size = new Size(197, 23);
            partSourceText.TabIndex = 8;
            partSourceText.TextChanged += partSourceText_TextChanged;
            // 
            // minText
            // 
            minText.Location = new Point(394, 257);
            minText.Name = "minText";
            minText.Size = new Size(88, 23);
            minText.TabIndex = 9;
            minText.TextChanged += minText_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(141, 88);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(116, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(95, 172);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(81, 214);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 13;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(345, 260);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 14;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(128, 260);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 15;
            label7.Text = "Max";
            // 
            // partSource
            // 
            partSource.AutoSize = true;
            partSource.Enabled = false;
            partSource.Font = new Font("Segoe UI", 11F);
            partSource.Location = new Point(81, 302);
            partSource.Name = "partSource";
            partSource.Size = new Size(84, 20);
            partSource.TabIndex = 16;
            partSource.Text = "Machine ID";
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ControlDark;
            saveButton.Enabled = false;
            saveButton.Font = new Font("Segoe UI", 11F);
            saveButton.Location = new Point(256, 373);
            saveButton.Name = "saveButton";
            saveButton.Padding = new Padding(3);
            saveButton.Size = new Size(75, 36);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.ControlDark;
            cancelButton.Font = new Font("Segoe UI", 11F);
            cancelButton.Location = new Point(367, 373);
            cancelButton.Name = "cancelButton";
            cancelButton.Padding = new Padding(3);
            cancelButton.Size = new Size(75, 36);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(886, 566);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(partSource);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(minText);
            Controls.Add(partSourceText);
            Controls.Add(maxText);
            Controls.Add(priceText);
            Controls.Add(inventoryText);
            Controls.Add(nameText);
            Controls.Add(idText);
            Controls.Add(OutsourcedRadioButton);
            Controls.Add(inHouseRadioButton);
            Controls.Add(label1);
            Name = "Part";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addPart";
            Load += PartsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton inHouseRadioButton;
        private RadioButton OutsourcedRadioButton;
        private TextBox idText;
        private TextBox nameText;
        private TextBox inventoryText;
        private TextBox priceText;
        private TextBox maxText;
        private TextBox partSourceText;
        private TextBox minText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label partSource;
        private Button saveButton;
        private Button cancelButton;
    }
}