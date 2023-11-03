namespace Practise
{
    public partial class Form : System.Windows.Forms.Form
    {
        private PatrolPayment PatrolPayment;
        private FoodPayment FoodPayment;

        public Form()
        {
            InitializeComponent();

            PatrolPayment = new PatrolPayment();
            FoodPayment = new FoodPayment();

            foreach (var item in FoodPayment.Prices)
            {
                TextBox textBox = (TextBox)panelFood.Controls.Find($"textBox{item.Key.Replace(" ", "")}Price", false)[0];
                textBox.Text = item.Value.ToString();
            }
        }

        private void comboBoxPatrolType_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxTypePrice.Text = PatrolPayment.Prices[comboBoxPatrolType.Text].ToString();

            if (countRadio.Checked)
            {
                textBoxPatrolCount_TextChanged(sender, e);
            }

            else
            {
                textBoxPatrolPrice_TextChanged(sender, e);
            }
        }

        private void textEntered(TextBox sender)
        {
            double value;

            if (!double.TryParse(sender.Text, out value) && sender.Text != string.Empty)
            {
                MessageBox.Show("Not a number", "Error");

                return;
            }

            PatrolPayment.Argument = value;
            PatrolPayment.PatrolType = comboBoxPatrolType.Text;

            double result = Math.Round(PatrolPayment.Evaluate(), 3);
            patrolToPayLabel.Text = result.ToString();
        }

        private void textBoxPatrolCount_TextChanged(object sender, EventArgs e)
        {
            textEntered(textBoxPatrolCount);
        }

        private void textBoxPatrolPrice_TextChanged(object sender, EventArgs e)
        {
            textEntered(textBoxPatrolPrice);
        }

        private void priceRadio_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPatrolPrice.ReadOnly = false;

            textBoxPatrolCount.ReadOnly = true;
            textBoxPatrolCount.Text = string.Empty;

            PatrolPayment.SetMode('P');
        }

        private void countRadio_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPatrolCount.ReadOnly = false;

            textBoxPatrolPrice.ReadOnly = true;
            textBoxPatrolPrice.Text = string.Empty;

            PatrolPayment.SetMode('C');
        }

        private void CheckFoodItem(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            TextBox textBox = (TextBox)panelFood.Controls.Find($"textBox{check.Text.Replace(" ", "")}Count", false)[0];

            if (check.Checked)
            {
                FoodPayment.Items.Add(check.Text, 0);
                textBox.ReadOnly = false;
                textBox.Text = string.Empty;
            }

            else
            {
                FoodPayment.Items.Remove(check.Text);
                textBox.ReadOnly = true;
                textBox.Text = string.Empty;
            }

            FoodPriceChange();
        }

        private void EnterCountItem(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.ReadOnly)
            {
                return;
            }

            string valueToFind = $"checkBox{textBox.Name.Replace(" ", "").Replace("textBox", "").Replace("Count", "")}";
            string itemName = foodChoicePanel.Controls.Find(valueToFind, false)[0].Text;

            int value = 0;

            if (!int.TryParse(textBox.Text, out value) && textBox.Text != string.Empty)
            {
                MessageBox.Show("Not a number", "Error");
            }

            FoodPayment.Items[itemName] = value;
            FoodPriceChange();
        }

        private void FoodPriceChange()
        {
            double result = FoodPayment.Evaluate();
            foodToPayLabel.Text = result.ToString();
        }

        private void TotalPriceChange(object sender, EventArgs e)
        {
            double valuePatrol;
            double valueFood;

            double.TryParse(patrolToPayLabel.Text, out valuePatrol);
            double.TryParse(foodToPayLabel.Text, out valueFood);

            totalPayLabel.Text = Math.Round(valuePatrol + valueFood, 3).ToString();
        }
    }
}