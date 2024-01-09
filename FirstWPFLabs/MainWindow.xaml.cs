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

namespace FirstWPFLabs
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

        private void CalculatorButton_Click(object sender, RoutedEventArgs e)
        {
            CalculatorWindow calculatorWindow = new CalculatorWindow();
            calculatorWindow.Show();
        }

        private void AddStringButton_Click(object sender, RoutedEventArgs e)
        {
            AddStringWindow addStringWindow = new AddStringWindow();
            addStringWindow.Show();
        }

        private void PlanetChoiceButton_Click(object sender, RoutedEventArgs e)
        {
            PlanetChoiceWindow planetChoiceWindow = new PlanetChoiceWindow();
            planetChoiceWindow.Show();
        }

        private void DateChoiceButton_Click(object sender, RoutedEventArgs e)
        {
            DateInputWindow dateInputWindow = new DateInputWindow();
            dateInputWindow.Show();
        }

        private void WorkWithFileButton_Click(object sender, RoutedEventArgs e)
        {
            WorkWithFileWindow workWithFileWindow = new WorkWithFileWindow();
            workWithFileWindow.Show();
        }
    }
}
