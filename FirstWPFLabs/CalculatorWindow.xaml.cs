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
using System.Windows.Shapes;

namespace FirstWPFLabs
{
    /// <summary>
    /// Логика взаимодействия для CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }

        private void PerformOperation(Func<int, int, int> operation)
        {
            if (int.TryParse(InputFirstValue.Text, out int firstValue) && int.TryParse(InputSecondValue.Text, out int secondValue))
            {
                try
                {
                    int result = operation(firstValue, secondValue);
                    ResultInfo.Text = result.ToString();
                } catch (Exception ex) { 
                    ResultInfo.Text = "Ошибка" + ex.Message;
                }
            } else
            {
                ResultInfo.Text = "Ошибка ввода!";
            }
        }

        private void SumValue_click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => a + b);
        }

        private void DifferenceValue_click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => a - b);
        }

        private void MultiplicationValue_click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => a * b);
        }

        private void DivisionValue_click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) =>  (a / b));
        }
    }
}
