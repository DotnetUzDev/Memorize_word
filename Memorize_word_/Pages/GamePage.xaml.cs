using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Repositories.Word;
using Memorize_word_.Windows;
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

namespace Memorize_word_.Pages
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        private readonly IWordRepositories _wordRepositories;

        public GamePage()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            if (tbGameNumber.Text.Length > 0)
            {
                int dt = int.Parse(tbGameNumber.Text);
                GameWindow gameWindow1 = new GameWindow(dt);
                gameWindow1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Test Sonini Kiriting!!!");
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                gameWindow.lbSavolnumber.Content = "1-Savol";

                var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
                string path1 = w[0].image1;
                string path2 = w[0].image2;
                string path3 = w[0].image3;
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(path1, UriKind.Relative));
                gameWindow.imageButton1.Background = brush;
                var brush2 = new ImageBrush();
                brush2.ImageSource = new BitmapImage(new Uri(path2, UriKind.Relative));
                gameWindow.imageButton2.Background = brush2;
                var brush3 = new ImageBrush();
                brush3.ImageSource = new BitmapImage(new Uri(path3, UriKind.Relative));
                gameWindow.imageButton3.Background = brush3;
                int s = w[0].Word.Length;
                for (int i = 0; i < s; i++)
                {
                    if (i == 0) gameWindow.tbtextgame1.Visibility = Visibility.Visible;
                    else if (i == 1) gameWindow.tbtextgame2.Visibility = Visibility.Visible;
                    else if (i == 2) gameWindow.tbtextgame3.Visibility = Visibility.Visible;
                    else if (i == 3) gameWindow.tbtextgame4.Visibility = Visibility.Visible;
                    else if (i == 4) gameWindow.tbtextgame5.Visibility = Visibility.Visible;
                    else if (i == 5) gameWindow.tbtextgame6.Visibility = Visibility.Visible;
                    else if (i == 6) gameWindow.tbtextgame7.Visibility = Visibility.Visible;
                    else if (i == 7) gameWindow.tbtextgame8.Visibility = Visibility.Visible;
                    else if (i == 8) gameWindow.tbtextgame9.Visibility = Visibility.Visible;
                    else if (i == 9) gameWindow.tbtextgame10.Visibility = Visibility.Visible;

                }
                
            }
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
