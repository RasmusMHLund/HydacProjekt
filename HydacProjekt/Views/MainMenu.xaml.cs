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

namespace HydacProjekt.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Report_Screen_Click(object sender, RoutedEventArgs e)
        {
            ReportScreen reportScreen = new ReportScreen();
            reportScreen.Show();
        }

        private void Solution_Screen_Click(object sender, RoutedEventArgs e)
        {
            SolutionScreen solutionScreen = new SolutionScreen();
            solutionScreen.Show();
        }

        private void Product_Screen_Click(object sender, RoutedEventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();  
            productScreen.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();  
            mainWindow.Show();
            Close();
        }
    }
}
