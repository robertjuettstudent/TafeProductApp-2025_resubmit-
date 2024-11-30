using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ProductApps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Read the input values
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                int quantity = Convert.ToInt32(quantityTextBox.Text);

                // Calculate the total payment
                decimal totalPayment = price * quantity;

                // Add a delivery charge of $25
                decimal deliveryCharge = 25.00m;
                decimal totalCharge = totalPayment + deliveryCharge;

                // Display the total payment and total charge
                totalPaymentTextBlock.Text = totalPayment.ToString("C");
                totalChargeTextBox.Text = totalCharge.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear all fields
            productTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();

        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
