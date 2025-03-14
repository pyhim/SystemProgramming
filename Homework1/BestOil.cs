namespace Homework1
{
    public partial class BestOil : Form
    {
        private delegate double CalculationFunc(double inputValue, double gasPrice);

        private static string defaultGasType = string.Empty;
        private readonly Dictionary<string, double> _gasTypesPrices = [];
        private readonly Dictionary<string, double> _miniCafePrices = [];
        private Dictionary<string, double> _miniCafeQuantityBoxes = [];
        private double _gasStationTotal = 0;
        private double _miniCafeTotal = 0;

        public BestOil()
        {
            _gasTypesPrices.Add("A-92", 29.50);
            _gasTypesPrices.Add("A-95", 34.20);
            _gasTypesPrices.Add("A-100", 36.35);
            _gasTypesPrices.Add("B-100", 31.70);

            _miniCafePrices.Add("Hot-Dog", 4.0);
            _miniCafePrices.Add("Hamburger", 5.4);
            _miniCafePrices.Add("French fries", 7.2);
            _miniCafePrices.Add("Coca-Cola", 4.4);

            defaultGasType = _gasTypesPrices.Keys.First();

            InitializeComponent();
            GasTypeComboBox_Init();
            MiniCafe_Init();
        }

        private void GasTypeComboBox_Init()
        {
            foreach (string item in _gasTypesPrices.Keys)
            {
                gasTypeComboBox.Items.Add(item);
            }

            gasTypeComboBox.SelectedItem = gasTypeComboBox.Items[0];
        }

        private void MiniCafe_Init()
        {
            hotdogPriceTextBox.Text = _miniCafePrices["Hot-Dog"].ToString("F2");
            hamburgerPriceTextBox.Text = _miniCafePrices["Hamburger"].ToString("F2");
            frenchFriesPriceTextBox.Text = _miniCafePrices["French fries"].ToString("F2");
            cocacolaPriceTextBox.Text = _miniCafePrices["Coca-Cola"].ToString("F2");
        }

        private void GasTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = gasTypeComboBox.SelectedItem!.ToString() ?? defaultGasType;
            gasPriceTextBox.Text = _gasTypesPrices[selectedItem].ToString();
        }

        private void AmountRadioButton_Click(object sender, EventArgs e)
        {
            amountTextBox.Enabled = true;
            sumTextBox.Enabled = false;

            gasStationTotalGroupBox.Text = "To pay";
            gasStationTotalValueLabel.Text = "0.0";
            gasStationTotalValueTypeLabel.Text = "UAH";
        }

        private void SumRadioButton_Click(object sender, EventArgs e)
        {
            sumTextBox.Enabled = true;
            amountTextBox.Enabled = false;

            gasStationTotalGroupBox.Text = "To be yielded";
            gasStationTotalValueLabel.Text = "0.0";
            gasStationTotalValueTypeLabel.Text = "L";
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            mainMessageLabel.Text = string.Empty;

            GasStationCalculateValues(amountTextBox, (double amount, double price) => amount * price);
        }

        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {
            mainMessageLabel.Text = string.Empty;

            GasStationCalculateValues(sumTextBox, (double amount, double price) => amount / price);
        }

        private void GasStationCalculateValues(TextBox inputBox, CalculationFunc f)
        {
            try
            {
                var inputValue = Convert.ToDouble(
                            inputBox.Text.Equals(string.Empty) ? 0 : inputBox.Text);
                var gasPrice = _gasTypesPrices[gasTypeComboBox.SelectedItem!.ToString() ?? defaultGasType];

                double result = f(inputValue, gasPrice);

                _gasStationTotal = result;
                gasStationTotalValueLabel.Text = result.ToString("F2");
            }
            catch (FormatException)
            {
                mainMessageLabel.Text = "Wrong value!";
            }
            catch (ArithmeticException)
            {
                mainMessageLabel.Text = "Unable to calculate the total!";
            }
        }

        private void HotdogCheckBox_Click(object sender, EventArgs e)
        {
            hotdogTextBox.Enabled = !hotdogTextBox.Enabled;
            ChangeEnabledMiniCafeTextBoxes(hotdogCheckBox);
        }

        private void HamburgerCheckBox_Click(object sender, EventArgs e)
        {
            hamburgerTextBox.Enabled = !hamburgerTextBox.Enabled;
            ChangeEnabledMiniCafeTextBoxes(hamburgerCheckBox);
        }

        private void FrenchfriesCheckBox_Click(object sender, EventArgs e)
        {
            frenchFriesTextBox.Enabled = !frenchFriesTextBox.Enabled;
            ChangeEnabledMiniCafeTextBoxes(frenchfriesCheckBox);
        }

        private void CocacolaCheckBox_Click(object sender, EventArgs e)
        {
            cocacolaTextBox.Enabled = !cocacolaTextBox.Enabled;
            ChangeEnabledMiniCafeTextBoxes(cocacolaCheckBox);
        }

        private void ChangeEnabledMiniCafeTextBoxes(CheckBox checkBox)
        {
            if (checkBox.Enabled)
            {
                _miniCafeQuantityBoxes.Add(checkBox.Text, 0);
                return;
            }

            _miniCafeQuantityBoxes.Remove(checkBox.Text);
        }

        private void HotdogTextBox_TextChanged(object sender, EventArgs e)
        {
            MiniCafeCalculateTotal("Hot-Dog", hotdogTextBox);
        }

        private void HamburgerTextBox_TextChanged(object sender, EventArgs e)
        {
            MiniCafeCalculateTotal("Hamburger", hamburgerTextBox);
        }

        private void FrenchfriesTextBox_TextChanged(object sender, EventArgs e)
        {
            MiniCafeCalculateTotal("French fries", frenchFriesTextBox);
        }

        private void CocacolaTextBox_TextChanged(object sender, EventArgs e)
        {
            MiniCafeCalculateTotal("Coca-Cola", cocacolaTextBox);
        }

        private void MiniCafeCalculateTotal(string fieldName, TextBox textBox)
        {
            mainMessageLabel.Text = string.Empty;

            try
            {
                double calculatedProductTotal =
                    (textBox.Text.Equals(string.Empty) ? 0 : Convert.ToDouble(textBox.Text)) * _miniCafePrices[fieldName];
                _miniCafeQuantityBoxes[fieldName] = calculatedProductTotal;
                _miniCafeTotal = _miniCafeQuantityBoxes.Values.Sum();
                miniCafeToPayLabel.Text = _miniCafeTotal.ToString("F2");
            }
            catch (FormatException)
            {
                mainMessageLabel.Text = "Wrong value!";
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (sumTextBox.Enabled)
            {
                totalPriceLabel.Text = _miniCafeTotal.ToString("F2");
            }
            else
            {
                totalPriceLabel.Text = (_gasStationTotal + _miniCafeTotal).ToString("F2");
            }

            mainMessageLabel.Text = "The total has been calculated!";
        }
    }
}
