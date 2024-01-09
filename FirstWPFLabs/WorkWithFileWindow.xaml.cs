using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace FirstWPFLabs
{
    /// <summary>
    /// Логика взаимодействия для WorkWithFileWindow.xaml
    /// </summary>
    public partial class WorkWithFileWindow : Window
    {
        public WorkWithFileWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                MainTextBlock.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveFileAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, MainTextBlock.Text);
            }
        }
    }
}
