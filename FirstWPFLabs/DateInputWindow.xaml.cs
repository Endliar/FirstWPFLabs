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
    /// Логика взаимодействия для DateInputWindow.xaml
    /// </summary>
    public partial class DateInputWindow : Window
    {
        public DateInputWindow()
        {
            InitializeComponent();

            for (int year = 1900;  year <= DateTime.Now.Year; year++)
            {
                YearComboBox.Items.Add(year);
            }

            for (int month = 1; month <= 12; month++)
            {
                MonthComboBox.Items.Add(month);
            }
        }

        private void YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkDateSelection();
        }

        private void MonthComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkDateSelection();
        }

        private void DayComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DayComboBox.SelectedItem != null)
            {
                DateTime selectedDate = new DateTime(
                    Convert.ToInt32(YearComboBox.SelectedItem),
                    Convert.ToInt32(MonthComboBox.SelectedItem),
                    Convert.ToInt32(DayComboBox.SelectedItem));
                DateTime now = DateTime.Now;

                int years = now.Year - selectedDate.Year;
                int months = now.Month - selectedDate.Month;
                int days = now.Day - selectedDate.Day;

                if (days < 0)
                {
                    days += DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);
                    months--;
                }
                if (months < 0)
                {
                    months += 12;
                    years--;
                }
                MessageBox.Show($"Years: {years}, Months: {months}, Days: {days}", "Date Passed");
            }
        }

        private void checkDateSelection()
        {
            if (YearComboBox.SelectedIndex != null && MonthComboBox.SelectedItem != null)
            {
                DayComboBox.IsEditable = true;
                UpdateDays();
            }
            else
            {
                 DayComboBox.IsEditable= false;
            }
        }

        private void UpdateDays()
        {
            int year = Convert.ToInt32(YearComboBox.SelectedItem);
            int month = Convert.ToInt32(MonthComboBox.SelectedItem);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            DayComboBox.Items.Clear();
            for (int day = 0;  day < daysInMonth; day++)
            {
                DayComboBox.Items.Add(day);
            }
        }
    }
}
