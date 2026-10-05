

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dolgozat_1005
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool isNameValid()
        {
            string Name = txtName.Text.Trim();
            if (Name == "")
            {
                MessageBox.Show("A név mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (Name.Length < 3)
            {
                MessageBox.Show("A név mezőnek legalább 3 karakter hosszúnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private bool isAgeValid()
        {
            string AgeText = txtAge.Text.Trim();
            if (AgeText == "")
            {
                MessageBox.Show("Az életkor mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            try
            {
                int Age = int.Parse(AgeText);
                if (Age < 14 || Age > 120)
                {
                    MessageBox.Show("Az életkor mezőnek 0 és 120 közötti számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Az életkor mezőnek számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Az életkor mező túl nagy számot tartalmaz!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private bool isEmailValid()
        {
            string Email = txtEmail.Text.Trim();
            if (Email == "")
            {
                MessageBox.Show("Az email mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                MessageBox.Show("Az email mezőnek érvényes email címet kell tartalmaznia!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private bool isCpuValid()
        {
            if (myComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Kérlek válaszd ki a processzort!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private bool isGpuValid()
        {
            if (rb4060.IsChecked == true || rb4070.IsChecked == true || rb4080.IsChecked == true)
            {
                return true;
            }
            MessageBox.Show("Kérlek válaszd ki a videókártyát!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
        private bool isMemoryValid()
        {
            if (rb16.IsChecked == true || rb32.IsChecked == true || rb64.IsChecked == true)
            {
                return true;
            }
            MessageBox.Show("Kérlek válaszd ki a memória mennyiségét!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
        private bool isGValid()
        {
            if (rbG1.IsChecked == true || rbG3.IsChecked == true || rbG5.IsChecked == true)
            {
                return true;
            }
            MessageBox.Show("Kérlek válaszd ki hány év garanciát szeretnél!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }
        private bool isNumberPcValid()
        {
            string numberPC = pcNumber.Text.Trim();
            if (numberPC == "")
            {
                MessageBox.Show("A darabszám mező nem lehet üres!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            try
            {
                int number = int.Parse(numberPC);
                if (number < 1 || number > 5)
                {
                    MessageBox.Show("Az darabszám mezőnek 1 és 5 közötti számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Az darabszám mezőnek számnak kell lennie!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Az darabszám mező túl nagy számot tartalmaz!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private int allExtras()
        {
            int alLExtra = 0;
            if (check1.IsChecked == true)
            {
                alLExtra += 15000;
            }
            if (check2.IsChecked == true)
            {
                alLExtra += 45000;
            }
            if (check3.IsChecked == true)
            {
                alLExtra += 25000;
            }
            if (check4.IsChecked == true)
            {
                alLExtra += 18000;
            }
            return alLExtra;
        }

        private int allCpu()
        {
            int alLExtraCpu = 0;
            if (myComboBox.SelectedIndex == 0)
            {
                alLExtraCpu += 70000;
            }
            if (myComboBox.SelectedIndex == 1)
            {
                alLExtraCpu += 110000;
            }
            if (myComboBox.SelectedIndex == 2)
            {
                alLExtraCpu += 65000;
            }
            if (myComboBox.SelectedIndex == 3)
            {
                alLExtraCpu += 105000;
            }
            return alLExtraCpu;
        }
        private int allGpu()
        {
            int alLExtraGpu = 0;
            if (rb4060.IsChecked == true)
            {
                alLExtraGpu += 130000;
            }
            if (rb4070.IsChecked == true)
            {
                alLExtraGpu += 220000;
            }
            if (rb4080.IsChecked == true)
            {
                alLExtraGpu += 400000;
            }
            return alLExtraGpu;
        }
        private int allMemory()
        {
            int allExtraMemory = 0;
            if (rb16.IsChecked == true)
            {
                allExtraMemory += 20000;
            }
            if (rb32.IsChecked == true)
            {
                allExtraMemory += 35000;
            }
            if (rb64.IsChecked == true)
            {
                allExtraMemory += 65000;
            }
            return allExtraMemory;
        }
        private bool isAccepted()
        {
            if (checkBox.IsChecked == true) 
            {
                return true;
            }
            MessageBox.Show("Kérlek fogadd el az vásárlási feltételeket!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            return false;
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (!isNameValid()) return;
            if (!isAgeValid()) return;
            if (!isEmailValid()) return;
            if (!isCpuValid()) return;
            if (!isGpuValid()) return;
            if (!isGValid()) return;
            if (!isMemoryValid()) return;
            if (!isNumberPcValid()) return;

            int allExtra = allExtras();
            int allExtraCpu = allCpu();
            int allExtraGpu = allGpu();
            int allExtraMemory = allMemory();
            int numberPC = int.Parse(pcNumber.Text.Trim());

            int totalPrice = (allExtra + allExtraCpu + allExtraGpu + allExtraMemory)*numberPC;

            MessageBox.Show($"A vásárlás végösszege: {totalPrice} Ft", "Vásárlás összegzése", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}