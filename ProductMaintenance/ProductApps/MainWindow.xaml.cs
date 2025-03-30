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

        // Calculate button click event handler
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Parse values from the textboxes
                decimal price = Convert.ToDecimal(priceTextBox.Text);
                int quantity = Convert.ToInt32(quantityTextBox.Text);

                // Calculate total payment
                decimal totalPayment = price * quantity;

                // Display the total payment in the TotalPayment TextBlock
                totalPaymentTextBlock.Text = totalPayment.ToString("0.00");

                // Add $25 delivery charge
                decimal deliveryCharge = 25.00m;
                decimal totalCharge = totalPayment + deliveryCharge;

                // Display the total charge after delivery charge
                totalChargeTextBlock.Text = totalCharge.ToString("0.00");

                // Add $5 wrapping charge
                decimal wrapCharge = 5.00m;
                decimal totalChargeWithWrap = totalCharge + wrapCharge;

                // Display the total charge after the wrap charge
                totalChargeWrapBlock.Text = totalChargeWithWrap.ToString("0.00");

                // Calculate GST at 10%
                decimal gst = 0.10m * totalChargeWithWrap;

                // Display the total charge after GST
                decimal totalWithGST = totalChargeWithWrap + gst;
                totalChargeGSTBlock.Text = totalWithGST.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total: " + ex.Message);
            }
        }

        // Clear button click event handler
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear all textboxes and labels
            productTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
            totalPaymentTextBlock.Text = string.Empty;
            totalChargeTextBlock.Text = string.Empty;
            totalChargeWrapBlock.Text = string.Empty;
            totalChargeGSTBlock.Text = string.Empty;
        }

        // Close button click event handler
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}