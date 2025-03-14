namespace Homework1
{
    partial class BestOil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestOil));
            gasStationBox = new GroupBox();
            gasStationTotalGroupBox = new GroupBox();
            gasStationTotalValueTypeLabel = new Label();
            gasStationTotalValueLabel = new Label();
            AmountOrSumGroupBox = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            sumTextBox = new TextBox();
            amountTextBox = new TextBox();
            sumRadioButton = new RadioButton();
            amountRadioButton = new RadioButton();
            label3 = new Label();
            gasPriceTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gasTypeComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            miniCafeToPayLabel = new Label();
            label8 = new Label();
            cocacolaTextBox = new TextBox();
            cocacolaPriceTextBox = new TextBox();
            frenchFriesTextBox = new TextBox();
            frenchFriesPriceTextBox = new TextBox();
            hamburgerTextBox = new TextBox();
            hamburgerPriceTextBox = new TextBox();
            hotdogTextBox = new TextBox();
            hotdogPriceTextBox = new TextBox();
            cocacolaCheckBox = new CheckBox();
            frenchfriesCheckBox = new CheckBox();
            hamburgerCheckBox = new CheckBox();
            hotdogCheckBox = new CheckBox();
            groupBox4 = new GroupBox();
            calculateButton = new Button();
            pictureBox1 = new PictureBox();
            groupBox5 = new GroupBox();
            label11 = new Label();
            totalPriceLabel = new Label();
            groupBox2 = new GroupBox();
            mainMessageLabel = new Label();
            gasStationBox.SuspendLayout();
            gasStationTotalGroupBox.SuspendLayout();
            AmountOrSumGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gasStationBox
            // 
            gasStationBox.Controls.Add(gasStationTotalGroupBox);
            gasStationBox.Controls.Add(AmountOrSumGroupBox);
            gasStationBox.Controls.Add(label3);
            gasStationBox.Controls.Add(gasPriceTextBox);
            gasStationBox.Controls.Add(label2);
            gasStationBox.Controls.Add(label1);
            gasStationBox.Controls.Add(gasTypeComboBox);
            gasStationBox.Location = new Point(12, 12);
            gasStationBox.Name = "gasStationBox";
            gasStationBox.Size = new Size(224, 311);
            gasStationBox.TabIndex = 0;
            gasStationBox.TabStop = false;
            gasStationBox.Text = "Gas Station";
            // 
            // gasStationTotalGroupBox
            // 
            gasStationTotalGroupBox.Controls.Add(gasStationTotalValueTypeLabel);
            gasStationTotalGroupBox.Controls.Add(gasStationTotalValueLabel);
            gasStationTotalGroupBox.Location = new Point(6, 213);
            gasStationTotalGroupBox.Name = "gasStationTotalGroupBox";
            gasStationTotalGroupBox.Size = new Size(212, 92);
            gasStationTotalGroupBox.TabIndex = 6;
            gasStationTotalGroupBox.TabStop = false;
            gasStationTotalGroupBox.Text = "To pay:";
            // 
            // gasStationTotalValueTypeLabel
            // 
            gasStationTotalValueTypeLabel.AutoSize = true;
            gasStationTotalValueTypeLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gasStationTotalValueTypeLabel.Location = new Point(176, 54);
            gasStationTotalValueTypeLabel.Name = "gasStationTotalValueTypeLabel";
            gasStationTotalValueTypeLabel.Size = new Size(30, 13);
            gasStationTotalValueTypeLabel.TabIndex = 1;
            gasStationTotalValueTypeLabel.Text = "UAH";
            // 
            // gasStationTotalValueLabel
            // 
            gasStationTotalValueLabel.AutoSize = true;
            gasStationTotalValueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gasStationTotalValueLabel.Location = new Point(80, 35);
            gasStationTotalValueLabel.Name = "gasStationTotalValueLabel";
            gasStationTotalValueLabel.Size = new Size(45, 32);
            gasStationTotalValueLabel.TabIndex = 0;
            gasStationTotalValueLabel.Text = "0,0";
            // 
            // AmountOrSumGroupBox
            // 
            AmountOrSumGroupBox.Controls.Add(label5);
            AmountOrSumGroupBox.Controls.Add(label4);
            AmountOrSumGroupBox.Controls.Add(sumTextBox);
            AmountOrSumGroupBox.Controls.Add(amountTextBox);
            AmountOrSumGroupBox.Controls.Add(sumRadioButton);
            AmountOrSumGroupBox.Controls.Add(amountRadioButton);
            AmountOrSumGroupBox.Location = new Point(6, 107);
            AmountOrSumGroupBox.Name = "AmountOrSumGroupBox";
            AmountOrSumGroupBox.Size = new Size(212, 100);
            AmountOrSumGroupBox.TabIndex = 5;
            AmountOrSumGroupBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(182, 67);
            label5.Name = "label5";
            label5.Size = new Size(30, 13);
            label5.TabIndex = 5;
            label5.Text = "UAH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 24);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 4;
            label4.Text = "L";
            // 
            // sumTextBox
            // 
            sumTextBox.Enabled = false;
            sumTextBox.Location = new Point(99, 60);
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Size = new Size(82, 23);
            sumTextBox.TabIndex = 3;
            sumTextBox.TextChanged += SumTextBox_TextChanged;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(99, 18);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(82, 23);
            amountTextBox.TabIndex = 2;
            amountTextBox.TextChanged += AmountTextBox_TextChanged;
            // 
            // sumRadioButton
            // 
            sumRadioButton.AutoSize = true;
            sumRadioButton.Location = new Point(6, 64);
            sumRadioButton.Name = "sumRadioButton";
            sumRadioButton.Size = new Size(49, 19);
            sumRadioButton.TabIndex = 1;
            sumRadioButton.Text = "Sum";
            sumRadioButton.UseVisualStyleBackColor = true;
            sumRadioButton.Click += SumRadioButton_Click;
            // 
            // amountRadioButton
            // 
            amountRadioButton.AutoSize = true;
            amountRadioButton.Checked = true;
            amountRadioButton.Location = new Point(6, 22);
            amountRadioButton.Name = "amountRadioButton";
            amountRadioButton.Size = new Size(69, 19);
            amountRadioButton.TabIndex = 0;
            amountRadioButton.TabStop = true;
            amountRadioButton.Text = "Amount";
            amountRadioButton.UseVisualStyleBackColor = true;
            amountRadioButton.Click += AmountRadioButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 83);
            label3.Name = "label3";
            label3.Size = new Size(30, 13);
            label3.TabIndex = 4;
            label3.Text = "UAH";
            // 
            // gasPriceTextBox
            // 
            gasPriceTextBox.Location = new Point(66, 78);
            gasPriceTextBox.Name = "gasPriceTextBox";
            gasPriceTextBox.ReadOnly = true;
            gasPriceTextBox.Size = new Size(121, 23);
            gasPriceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Gas Type";
            // 
            // gasTypeComboBox
            // 
            gasTypeComboBox.FormattingEnabled = true;
            gasTypeComboBox.Location = new Point(66, 26);
            gasTypeComboBox.Name = "gasTypeComboBox";
            gasTypeComboBox.Size = new Size(121, 23);
            gasTypeComboBox.TabIndex = 0;
            gasTypeComboBox.SelectedIndexChanged += GasTypeComboBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cocacolaTextBox);
            groupBox1.Controls.Add(cocacolaPriceTextBox);
            groupBox1.Controls.Add(frenchFriesTextBox);
            groupBox1.Controls.Add(frenchFriesPriceTextBox);
            groupBox1.Controls.Add(hamburgerTextBox);
            groupBox1.Controls.Add(hamburgerPriceTextBox);
            groupBox1.Controls.Add(hotdogTextBox);
            groupBox1.Controls.Add(hotdogPriceTextBox);
            groupBox1.Controls.Add(cocacolaCheckBox);
            groupBox1.Controls.Add(frenchfriesCheckBox);
            groupBox1.Controls.Add(hamburgerCheckBox);
            groupBox1.Controls.Add(hotdogCheckBox);
            groupBox1.Location = new Point(267, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 311);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mini-Cafe";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(160, 19);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 13;
            label13.Text = "Quantity";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(miniCafeToPayLabel);
            groupBox3.Location = new Point(6, 213);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 92);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "To pay:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(176, 54);
            label9.Name = "label9";
            label9.Size = new Size(30, 13);
            label9.TabIndex = 1;
            label9.Text = "UAH";
            // 
            // miniCafeToPayLabel
            // 
            miniCafeToPayLabel.AutoSize = true;
            miniCafeToPayLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            miniCafeToPayLabel.Location = new Point(87, 35);
            miniCafeToPayLabel.Name = "miniCafeToPayLabel";
            miniCafeToPayLabel.Size = new Size(45, 32);
            miniCafeToPayLabel.TabIndex = 0;
            miniCafeToPayLabel.Text = "0,0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(116, 19);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 12;
            label8.Text = "Price";
            // 
            // cocacolaTextBox
            // 
            cocacolaTextBox.Enabled = false;
            cocacolaTextBox.Location = new Point(160, 155);
            cocacolaTextBox.Name = "cocacolaTextBox";
            cocacolaTextBox.Size = new Size(48, 23);
            cocacolaTextBox.TabIndex = 11;
            cocacolaTextBox.Text = "0";
            cocacolaTextBox.TextAlign = HorizontalAlignment.Right;
            cocacolaTextBox.TextChanged += CocacolaTextBox_TextChanged;
            // 
            // cocacolaPriceTextBox
            // 
            cocacolaPriceTextBox.Location = new Point(106, 155);
            cocacolaPriceTextBox.Name = "cocacolaPriceTextBox";
            cocacolaPriceTextBox.ReadOnly = true;
            cocacolaPriceTextBox.Size = new Size(48, 23);
            cocacolaPriceTextBox.TabIndex = 10;
            cocacolaPriceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // frenchFriesTextBox
            // 
            frenchFriesTextBox.Enabled = false;
            frenchFriesTextBox.Location = new Point(160, 117);
            frenchFriesTextBox.Name = "frenchFriesTextBox";
            frenchFriesTextBox.Size = new Size(48, 23);
            frenchFriesTextBox.TabIndex = 9;
            frenchFriesTextBox.Text = "0";
            frenchFriesTextBox.TextAlign = HorizontalAlignment.Right;
            frenchFriesTextBox.TextChanged += FrenchfriesTextBox_TextChanged;
            // 
            // frenchFriesPriceTextBox
            // 
            frenchFriesPriceTextBox.Location = new Point(106, 117);
            frenchFriesPriceTextBox.Name = "frenchFriesPriceTextBox";
            frenchFriesPriceTextBox.ReadOnly = true;
            frenchFriesPriceTextBox.Size = new Size(48, 23);
            frenchFriesPriceTextBox.TabIndex = 8;
            frenchFriesPriceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // hamburgerTextBox
            // 
            hamburgerTextBox.Enabled = false;
            hamburgerTextBox.Location = new Point(160, 78);
            hamburgerTextBox.Name = "hamburgerTextBox";
            hamburgerTextBox.Size = new Size(48, 23);
            hamburgerTextBox.TabIndex = 7;
            hamburgerTextBox.Text = "0";
            hamburgerTextBox.TextAlign = HorizontalAlignment.Right;
            hamburgerTextBox.TextChanged += HamburgerTextBox_TextChanged;
            // 
            // hamburgerPriceTextBox
            // 
            hamburgerPriceTextBox.Location = new Point(106, 78);
            hamburgerPriceTextBox.Name = "hamburgerPriceTextBox";
            hamburgerPriceTextBox.ReadOnly = true;
            hamburgerPriceTextBox.Size = new Size(48, 23);
            hamburgerPriceTextBox.TabIndex = 6;
            hamburgerPriceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // hotdogTextBox
            // 
            hotdogTextBox.Enabled = false;
            hotdogTextBox.Location = new Point(160, 40);
            hotdogTextBox.Name = "hotdogTextBox";
            hotdogTextBox.Size = new Size(48, 23);
            hotdogTextBox.TabIndex = 5;
            hotdogTextBox.Text = "0";
            hotdogTextBox.TextAlign = HorizontalAlignment.Right;
            hotdogTextBox.TextChanged += HotdogTextBox_TextChanged;
            // 
            // hotdogPriceTextBox
            // 
            hotdogPriceTextBox.Location = new Point(106, 40);
            hotdogPriceTextBox.Name = "hotdogPriceTextBox";
            hotdogPriceTextBox.ReadOnly = true;
            hotdogPriceTextBox.Size = new Size(48, 23);
            hotdogPriceTextBox.TabIndex = 4;
            hotdogPriceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // cocacolaCheckBox
            // 
            cocacolaCheckBox.AutoSize = true;
            cocacolaCheckBox.Location = new Point(16, 157);
            cocacolaCheckBox.Name = "cocacolaCheckBox";
            cocacolaCheckBox.Size = new Size(82, 19);
            cocacolaCheckBox.TabIndex = 3;
            cocacolaCheckBox.Text = "Coca-Cola";
            cocacolaCheckBox.UseVisualStyleBackColor = true;
            cocacolaCheckBox.Click += CocacolaCheckBox_Click;
            // 
            // frenchfriesCheckBox
            // 
            frenchfriesCheckBox.AutoSize = true;
            frenchfriesCheckBox.Location = new Point(16, 119);
            frenchfriesCheckBox.Name = "frenchfriesCheckBox";
            frenchfriesCheckBox.Size = new Size(87, 19);
            frenchfriesCheckBox.TabIndex = 2;
            frenchfriesCheckBox.Text = "French fries";
            frenchfriesCheckBox.UseVisualStyleBackColor = true;
            frenchfriesCheckBox.Click += FrenchfriesCheckBox_Click;
            // 
            // hamburgerCheckBox
            // 
            hamburgerCheckBox.AutoSize = true;
            hamburgerCheckBox.Location = new Point(16, 80);
            hamburgerCheckBox.Name = "hamburgerCheckBox";
            hamburgerCheckBox.Size = new Size(87, 19);
            hamburgerCheckBox.TabIndex = 1;
            hamburgerCheckBox.Text = "Hamburger";
            hamburgerCheckBox.UseVisualStyleBackColor = true;
            hamburgerCheckBox.Click += HamburgerCheckBox_Click;
            // 
            // hotdogCheckBox
            // 
            hotdogCheckBox.AutoSize = true;
            hotdogCheckBox.Location = new Point(16, 42);
            hotdogCheckBox.Name = "hotdogCheckBox";
            hotdogCheckBox.Size = new Size(73, 19);
            hotdogCheckBox.TabIndex = 0;
            hotdogCheckBox.Text = "Hot-Dog";
            hotdogCheckBox.UseVisualStyleBackColor = true;
            hotdogCheckBox.Click += HotdogCheckBox_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(calculateButton);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(12, 370);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(479, 130);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "TOTAL";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(126, 36);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(150, 67);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += CalculateButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(totalPriceLabel);
            groupBox5.Location = new Point(292, 18);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(181, 100);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(145, 72);
            label11.Name = "label11";
            label11.Size = new Size(30, 13);
            label11.TabIndex = 3;
            label11.Text = "UAH";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(72, 39);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(45, 32);
            totalPriceLabel.TabIndex = 2;
            totalPriceLabel.Text = "0,0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mainMessageLabel);
            groupBox2.Location = new Point(12, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 41);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Message";
            // 
            // mainMessageLabel
            // 
            mainMessageLabel.AutoSize = true;
            mainMessageLabel.Location = new Point(12, 19);
            mainMessageLabel.Name = "mainMessageLabel";
            mainMessageLabel.Size = new Size(0, 15);
            mainMessageLabel.TabIndex = 0;
            // 
            // BestOil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 512);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(gasStationBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BestOil";
            Text = "BestOil";
            gasStationBox.ResumeLayout(false);
            gasStationBox.PerformLayout();
            gasStationTotalGroupBox.ResumeLayout(false);
            gasStationTotalGroupBox.PerformLayout();
            AmountOrSumGroupBox.ResumeLayout(false);
            AmountOrSumGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gasStationBox;
        private Label label1;
        private ComboBox gasTypeComboBox;
        private Label label2;
        private TextBox gasPriceTextBox;
        private Label label3;
        private GroupBox AmountOrSumGroupBox;
        private RadioButton sumRadioButton;
        private RadioButton amountRadioButton;
        private TextBox sumTextBox;
        private TextBox amountTextBox;
        private Label label4;
        private Label label5;
        private GroupBox gasStationTotalGroupBox;
        private Label gasStationTotalValueLabel;
        private Label gasStationTotalValueTypeLabel;
        private GroupBox groupBox1;
        private CheckBox cocacolaCheckBox;
        private CheckBox frenchfriesCheckBox;
        private CheckBox hamburgerCheckBox;
        private CheckBox hotdogCheckBox;
        private TextBox cocacolaTextBox;
        private TextBox cocacolaPriceTextBox;
        private TextBox frenchFriesTextBox;
        private TextBox frenchFriesPriceTextBox;
        private TextBox hamburgerTextBox;
        private TextBox hamburgerPriceTextBox;
        private TextBox hotdogTextBox;
        private TextBox hotdogPriceTextBox;
        private Label label8;
        private GroupBox groupBox3;
        private Label label9;
        private Label miniCafeToPayLabel;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private Label label13;
        private Label label11;
        private Button calculateButton;
        private Label totalPriceLabel;
        private GroupBox groupBox5;
        private GroupBox groupBox2;
        private Label mainMessageLabel;
    }
}
