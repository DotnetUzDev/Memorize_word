using Memorize_word_.Pages;
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

namespace Memorize_word_
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

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
        private void rbTest_Checked(object sender, RoutedEventArgs e)
        {
            TestAddPage page = new TestAddPage();
            PageNavigator.Content = page;
        }

        

        private void rbAddWord_Checked(object sender, RoutedEventArgs e)
        {

            AddWordPage page = new AddWordPage();
            PageNavigator.Content = page;
        }

        private void rbInformation_Checked(object sender, RoutedEventArgs e)
        {
            InformationPages page = new InformationPages();
            PageNavigator.Content = page;
        }

        private void rbsettings_Checked(object sender, RoutedEventArgs e)
        {
            SettingPage page = new SettingPage();
            PageNavigator.Content = page;
        }

        private void rbGames_Checked(object sender, RoutedEventArgs e)
        {
            GamePage page = new GamePage();
            PageNavigator.Content = page;
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbdashboard_Checked_1(sender, e);
        }

        private void rbAddWord_Checked_1(object sender, RoutedEventArgs e)
        {
            AddWordPage page = new AddWordPage();
            PageNavigator.Content = page;
        }

        private void rbDashboard(object sender, RoutedEventArgs e)
        {
            DashboardPage page = new DashboardPage();
            PageNavigator.Content = page;
        }

       

        private void rbdashboard_Checked_1(object sender, RoutedEventArgs e)
        {
            DashboardPage page = new DashboardPage();
            PageNavigator.Content = page;
        }

        private void rbDashboard_Checked(object sender, RoutedEventArgs e)
        {
            DashboardPage page = new DashboardPage();
            PageNavigator.Content = page;
        }
    }
}
