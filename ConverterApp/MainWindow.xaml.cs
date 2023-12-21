using ConverterApp.Services;
using ConverterApp.Strategies;
using System.Windows;
using System.Windows.Controls;

namespace ConverterApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double amountInUSD;

        private double selectedCurrencyAmount;

        private string CharCurrencyCOde;

        public MainWindow()
        {
            InitializeComponent();

            FromCurrencyComboBox.SelectionChanged += FromCurrencyComboBox_SelectionChanged; ;

            ToCurrencyComboBox.SelectionChanged += ToCurrencyComboBox_SelectionChanged;
        }

        private void FromCurrencyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var value = int.Parse(AmountTextBox.Text);

            MoneyChanger moneyChanger = new MoneyChanger(value);

            switch (((ComboBoxItem)FromCurrencyComboBox.SelectedItem).Content.ToString())
            {
                case "USD":
                    moneyChanger.SetConverter(new USDConverter());
                    break;
                case "RUB":
                    moneyChanger.SetConverter(new RUBConverter());
                    break;
                case "JPY":
                    moneyChanger.SetConverter(new JPYConverter());
                    break;
                case "CNY":
                    moneyChanger.SetConverter(new CNYConverter());
                    break;
                case "GBP":
                    moneyChanger.SetConverter(new GBPConverter());
                    break;

            }

            amountInUSD = moneyChanger.GetMoney();
        }

        private void ToCurrencyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MoneyChanger moneyChanger = new MoneyChanger(amountInUSD);

            switch (((ComboBoxItem)ToCurrencyComboBox.SelectedItem).Content.ToString())
            {
                case "USD":
                    moneyChanger.SetConverter(new USDConverter());
                    break;
                case "RUB":
                    moneyChanger.SetConverter(new RUBConverter());
                    break;
                case "JPY":
                    moneyChanger.SetConverter(new JPYConverter());
                    break;
                case "CNY":
                    moneyChanger.SetConverter(new CNYConverter());
                    break;
                case "GBP":
                    moneyChanger.SetConverter(new GBPConverter());
                    break;

            }

            CharCurrencyCOde = ((ComboBoxItem)ToCurrencyComboBox.SelectedItem).Content.ToString();

            selectedCurrencyAmount = moneyChanger.ChangeMoney();

        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = $"Сумма денег после операции: {selectedCurrencyAmount} {CharCurrencyCOde}";
        }
    }
}
