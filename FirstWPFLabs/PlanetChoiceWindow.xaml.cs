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
    /// Логика взаимодействия для PlanetChoiceWindow.xaml
    /// </summary>
    public partial class PlanetChoiceWindow : Window
    {

        private struct PlanetInfo
        {
            public string Name { get; }
            public string Description { get; }

            public PlanetInfo (string name, string description)
            {
                Name  = name;
                Description = description;
            }
        }

        public PlanetChoiceWindow()
        {
            InitializeComponent();
            PlanetListBox.ItemsSource = new List<PlanetInfo>
            {
                new PlanetInfo("Марс", "Четвёртая по удалённости от Солнца и седьмая по размеру планета Солнечной системы; масса планеты составляет 10,7 % массы Земли.\r\n\r\nЭто планета земной группы с разреженной атмосферой (давление на поверхности в 160 раз меньше земного). Особенностями поверхностного рельефа Марса можно считать ударные кратеры наподобие лунных, а также вулканы, долины, пустыни и полярные ледниковые шапки наподобие земных."),
                new PlanetInfo("Земля", "Третья по удалённости от Солнца планета Солнечной системы. Самая плотная, пятая по диаметру и массе среди всех планет Солнечной системы и крупнейшая среди планет земной группы, в которую входят также Меркурий, Венера и Марс. Единственное известное человеку в настоящее время тело во Вселенной, населённое живыми организмами.\r\n\r\nВ публицистике и научно-популярной литературе могут использоваться синонимические термины — мир, голубая планета, Терра (от лат. Terra). "),
                new PlanetInfo("Венера", "Вторая по удалённости от Солнца и шестая по размеру планета Солнечной системы, наряду с Меркурием, Землёй и Марсом принадлежащая к семейству планет земной группы.\r\n\r\nНазвана в честь древнеримской богини любви Венеры. По ряду характеристик — например, по массе и размерам — Венера считается «сестрой» Земли.\r\n\r\nВенерианский год составляет 224,7 земных суток. Она имеет самый длинный период вращения вокруг своей оси (около 243 земных суток, в среднем 243,0212 ± 0,00006 сут) среди всех планет Солнечной системы и вращается в направлении, противоположном направлению вращения большинства планет."),
                new PlanetInfo("Юпитер", "Крупнейшая планета Солнечной системы, пятая по удалённости от Солнца. Наряду с Сатурном Юпитер классифицируется как газовый гигант.\r\n\r\nПланета была известна людям с глубокой древности, что нашло своё отражение в мифологии и религиозных верованиях различных культур: месопотамской, вавилонской, греческой и других. Современное название Юпитера происходит от имени древнеримского верховного бога-громовержца."),
            };
            PlanetListBox.DisplayMemberPath = "Name";
        }

        private void PlanetsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlanetListBox.SelectedItem is PlanetInfo selectedPlanetInfo)
            {
                InfoTextBox.Text = selectedPlanetInfo.Description;
            } else
            {
                InfoTextBox.Text = "Выберите планету из списка";
            }
        }
    }
}
