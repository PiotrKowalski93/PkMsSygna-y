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

namespace Sygnaly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddItems();
        }

        private void AddItems()
        {
            TypySygnalow.Items.Add("Skok Jednostkowy");
            TypySygnalow.Items.Add("Prostokatny");
            TypySygnalow.Items.Add("Prostokatny Symetryczny");
            TypySygnalow.Items.Add("Sinusoidalny");
            TypySygnalow.Items.Add("Sinusoidalny Dwupolowkowo");
            TypySygnalow.Items.Add("Sinusoidalny Jednopolowkowo");
            TypySygnalow.Items.Add("Trójkatny");
            TypySygnalow.Items.Add("Szum Gaussowski");
            TypySygnalow.Items.Add("Szum o Rozdkladzie Jednostajnym");
            TypySygnalow.Items.Add("Impuls Jednostkowy");
            TypySygnalow.Items.Add("Szum Impulsowy");
        }
    }
}
