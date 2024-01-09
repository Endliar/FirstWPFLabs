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
    /// Логика взаимодействия для AddStringWindow.xaml
    /// </summary>
    public partial class AddStringWindow : Window
    {
        public AddStringWindow()
        {
            InitializeComponent();
        }

        private void EnterValueButton_Click(object sender, RoutedEventArgs e)
        {
            string message = InputValue.Text;
            MessageListBox.Items.Add(message);
            InputValue.Clear();
        }
    }
}
