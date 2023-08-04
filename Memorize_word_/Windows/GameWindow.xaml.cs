using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Pages;
using Memorize_word_.Repositories.Word;
using Memorize_word_.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Memorize_word_.Windows
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private readonly PaginationParams paginationParams;
        
        public readonly IWordRepositories _wordRepositories;
        
        
        public int n { get; set; }

        public bool buttonn1 { get; set; }

        public bool buttonn2 { get; set; }

        public bool buttonn3 { get; set; }

        public bool buttonn4 { get; set; }

        public bool buttonn5 { get; set; }

        public bool buttonn6 { get; set; }

        public bool buttonn7 { get; set; }

        public bool buttonn8 { get; set; }

        public bool buttonn9 { get; set; }

        public bool buttonn10 { get; set; }

        

        public int togri { get; set; }

        public int notogri { get; set; }


        public int natija { get; set; }

        public int h { get; set; }

        public int j { get; set; }
        public int son { get; set; }
        public int g { get; set; }
        public int z { get; set; }
        public GameWindow()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Hide();
        }
        public GameWindow(int son)
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
            this.son = son;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
        
        
        private async void NextButton_Click(object sender, RoutedEventArgs e)
        {
            int n11 = 0;
            z = 0;
            if (natija == son)
            {
                await Task.Delay(1000);
                n++;
                MainWindow mainWindow = GetMainWindow();
                Hisob hisob = new Hisob();
                hisob.lbtogri.Content = togri;
                hisob.lbnotogri.Content = notogri+1;
                mainWindow.PageNavigator.Content = hisob;
                this.Close();
            }
            else
            {
                natija += 1;
                var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
                int l = w[n].Word.Length;

                if (buttonn1)
                {
                    if (tbtextgame1.Text == w[n].Word[0].ToString())
                    {
                        n11++;
                        tbtextgame1.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn1 = false;
                        tbtextgame1.Background = tbqizil.Background;
                    }
                }

                if (buttonn2 && l > 1)
                {
                    if (tbtextgame2.Text == w[n].Word[1].ToString())
                    {
                        n11++;
                        tbtextgame2.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn2 = false;
                        tbtextgame2.Background = tbqizil.Background;
                    }
                }
                if (buttonn3 && l > 2)
                {
                    if (tbtextgame3.Text == w[n].Word[2].ToString())
                    {
                        n11++;
                        tbtextgame3.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn3 = false;
                        tbtextgame3.Background = tbqizil.Background;

                    }
                }
                if (buttonn4 && l > 3)
                {
                    if (tbtextgame4.Text == w[n].Word[3].ToString())
                    {
                        n11++;
                        tbtextgame4.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn4 = false;
                        tbtextgame4.Background = tbqizil.Background;
                    }
                }
                if (buttonn5 && l > 4)
                {
                    if (tbtextgame5.Text == w[n].Word[4].ToString())
                    {
                        n11++;
                        tbtextgame5.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn5 = false;
                        tbtextgame5.Background = tbqizil.Background;
                    }
                }
                if (buttonn6 && l > 5)
                {
                    if (tbtextgame6.Text == w[n].Word[5].ToString())
                    {
                        n11++;
                        tbtextgame6.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn6 = false;
                        tbtextgame6.Background = tbqizil.Background;
                    }
                }
                if (buttonn7 && l > 6)
                {
                    if (tbtextgame7.Text == w[n].Word[6].ToString())
                    {
                        n11++;
                        tbtextgame7.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn7 = false;
                        tbtextgame7.Background = tbqizil.Background;
                    }
                }
                if (buttonn8 && l > 7)
                {
                    if (tbtextgame8.Text == w[n].Word[7].ToString())
                    {
                        n11++;
                        tbtextgame8.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn8 = false;
                        tbtextgame8.Background = tbqizil.Background;
                    }


                }
                if (buttonn9 && l > 8)
                {
                    if (tbtextgame9.Text == w[n].Word[8].ToString())
                    {
                        n11++;
                        tbtextgame9.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn9 = false;
                        tbtextgame9.Background = tbqizil.Background;
                    }
                }
                if (buttonn10 && l > 9)
                {
                    if (tbtextgame10.Text == w[n].Word[9].ToString())
                    {
                        n11++;
                        tbtextgame10.Background = tbyashil.Background;
                    }
                    else
                    {
                        buttonn10 = false;
                        tbtextgame10.Background = tbqizil.Background;
                    }
                }
                
                if (w[n].Word.Length % 2 == 0)
                {
                    g = w[n].Word.Length / 2;
                }
                else g = w[n].Word.Length / 2 + 1;

                if (n11 == g)
                {
                    togri++;
                    await Task.Delay(500);
                    MessageBox.Show("To'G'rI JaVoB!");
                    tbtextgame1.Background = Brushes.White;
                    tbtextgame2.Background = Brushes.White;
                    tbtextgame3.Background = Brushes.White;
                    tbtextgame4.Background = Brushes.White;
                    tbtextgame5.Background = Brushes.White;
                    tbtextgame6.Background = Brushes.White;
                    tbtextgame7.Background = Brushes.White;
                    tbtextgame8.Background = Brushes.White;
                    tbtextgame9.Background = Brushes.White;
                    tbtextgame10.Background = Brushes.White;
                    tbtextgame1.Visibility = Visibility.Collapsed;
                    tbtextgame2.Visibility = Visibility.Collapsed;
                    tbtextgame3.Visibility = Visibility.Collapsed;
                    tbtextgame4.Visibility = Visibility.Collapsed;
                    tbtextgame5.Visibility = Visibility.Collapsed;
                    tbtextgame6.Visibility = Visibility.Collapsed;
                    tbtextgame7.Visibility = Visibility.Collapsed;
                    tbtextgame8.Visibility = Visibility.Collapsed;
                    tbtextgame9.Visibility = Visibility.Collapsed;
                    tbtextgame10.Visibility = Visibility.Collapsed;
                    n++;
                    lbSavolnumber.Content = $"{n + 1}-Savol";
                    ButtonText2.Visibility = Visibility.Collapsed;
                    ButtonText3.Visibility = Visibility.Collapsed;
                    ButtonText4.Visibility = Visibility.Collapsed;
                    ButtonText5.Visibility = Visibility.Collapsed;
                    ButtonText6.Visibility = Visibility.Collapsed;
                    ButtonText7.Visibility = Visibility.Collapsed;
                    ButtonText8.Visibility = Visibility.Collapsed;
                    ButtonText9.Visibility = Visibility.Collapsed;
                    ButtonText10.Visibility = Visibility.Collapsed;
                    ButtonText1.Content = "";
                    ButtonText2.Content = "";
                    ButtonText3.Content = "";
                    ButtonText4.Content = "";
                    ButtonText5.Content = "";
                    ButtonText6.Content = "";
                    ButtonText7.Content = "";
                    ButtonText8.Content = "";
                    ButtonText9.Content = "";
                    ButtonText10.Content = "";

                    string path1 = w[n].image1;
                    string path2 = w[n].image2;
                    string path3 = w[n].image3;
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri(path1, UriKind.Relative));
                    imageButton1.Background = brush;
                    var brush2 = new ImageBrush();
                    brush2.ImageSource = new BitmapImage(new Uri(path2, UriKind.Relative));
                    imageButton2.Background = brush2;
                    var brush3 = new ImageBrush();
                    brush3.ImageSource = new BitmapImage(new Uri(path3, UriKind.Relative));
                    imageButton3.Background = brush3;

                    int s = w[n].Word.Length;


                    for (int i = 0; i < s; i++)
                    {
                        if (i == 0)
                        {
                            ButtonText1.Visibility = Visibility.Visible;
                            tbtextgame1.Visibility = Visibility.Visible;
                        }
                        else if (i == 1)
                        {
                            ButtonText2.Visibility = Visibility.Visible;
                            tbtextgame2.Visibility = Visibility.Visible;
                        }
                        else if (i == 2)
                        {
                            ButtonText3.Visibility = Visibility.Visible;
                            tbtextgame3.Visibility = Visibility.Visible;
                        }
                        else if (i == 3)
                        {
                            ButtonText4.Visibility = Visibility.Visible;
                            tbtextgame4.Visibility = Visibility.Visible;
                        }
                        else if (i == 4)
                        {
                            ButtonText5.Visibility = Visibility.Visible;
                            tbtextgame5.Visibility = Visibility.Visible;
                        }
                        else if (i == 5)
                        {
                            ButtonText6.Visibility = Visibility.Visible;
                            tbtextgame6.Visibility = Visibility.Visible;
                        }
                        else if (i == 6)
                        {
                            ButtonText7.Visibility = Visibility.Visible;
                            tbtextgame7.Visibility = Visibility.Visible;
                        }
                        else if (i == 7)
                        {
                            ButtonText8.Visibility = Visibility.Visible;
                            tbtextgame8.Visibility = Visibility.Visible;
                        }
                        else if (i == 8)
                        {
                            ButtonText9.Visibility = Visibility.Visible;
                            tbtextgame9.Visibility = Visibility.Visible;
                        }
                        else if (i == 9)
                        {
                            ButtonText10.Visibility = Visibility.Visible;
                            tbtextgame10.Visibility = Visibility.Visible;
                        }
                    }

                }
                else
                {
                    notogri++;
                    await Task.Delay(500);
                    MessageBox.Show("NoTO'g'RI JaVoB!");
                    tbtextgame1.Background = Brushes.White;
                    tbtextgame2.Background = Brushes.White;
                    tbtextgame3.Background = Brushes.White;
                    tbtextgame4.Background = Brushes.White;
                    tbtextgame5.Background = Brushes.White;
                    tbtextgame6.Background = Brushes.White;
                    tbtextgame7.Background = Brushes.White;
                    tbtextgame8.Background = Brushes.White;
                    tbtextgame9.Background = Brushes.White;
                    tbtextgame10.Background = Brushes.White;
                    tbtextgame1.Visibility = Visibility.Collapsed;
                    tbtextgame2.Visibility = Visibility.Collapsed;
                    tbtextgame3.Visibility = Visibility.Collapsed;
                    tbtextgame4.Visibility = Visibility.Collapsed;
                    tbtextgame5.Visibility = Visibility.Collapsed;
                    tbtextgame6.Visibility = Visibility.Collapsed;
                    tbtextgame7.Visibility = Visibility.Collapsed;
                    tbtextgame8.Visibility = Visibility.Collapsed;
                    tbtextgame9.Visibility = Visibility.Collapsed;
                    tbtextgame10.Visibility = Visibility.Collapsed;
                    n++;
                    lbSavolnumber.Content = $"{n + 1}-Savol";
                    ButtonText2.Visibility = Visibility.Collapsed;
                    ButtonText3.Visibility = Visibility.Collapsed;
                    ButtonText4.Visibility = Visibility.Collapsed;
                    ButtonText5.Visibility = Visibility.Collapsed;
                    ButtonText6.Visibility = Visibility.Collapsed;
                    ButtonText7.Visibility = Visibility.Collapsed;
                    ButtonText8.Visibility = Visibility.Collapsed;
                    ButtonText9.Visibility = Visibility.Collapsed;
                    ButtonText10.Visibility = Visibility.Collapsed;
                    ButtonText1.Content = "";
                    ButtonText2.Content = "";
                    ButtonText3.Content = "";
                    ButtonText4.Content = "";
                    ButtonText5.Content = "";
                    ButtonText6.Content = "";
                    ButtonText7.Content = "";
                    ButtonText8.Content = "";
                    ButtonText9.Content = "";
                    ButtonText10.Content = "";

                    string path1 = w[n].image1;
                    string path2 = w[n].image2;
                    string path3 = w[n].image3;
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri(path1, UriKind.Relative));
                    imageButton1.Background = brush;
                    var brush2 = new ImageBrush();
                    brush2.ImageSource = new BitmapImage(new Uri(path2, UriKind.Relative));
                    imageButton2.Background = brush2;
                    var brush3 = new ImageBrush();
                    brush3.ImageSource = new BitmapImage(new Uri(path3, UriKind.Relative));
                    imageButton3.Background = brush3;

                    int s = w[n].Word.Length;


                    for (int i = 0; i < s; i++)
                    {
                        if (i == 0)
                        {
                            ButtonText1.Visibility = Visibility.Visible;
                            tbtextgame1.Visibility = Visibility.Visible;
                        }
                        else if (i == 1)
                        {
                            ButtonText2.Visibility = Visibility.Visible;
                            tbtextgame2.Visibility = Visibility.Visible;
                        }
                        else if (i == 2)
                        {
                            ButtonText3.Visibility = Visibility.Visible;
                            tbtextgame3.Visibility = Visibility.Visible;
                        }
                        else if (i == 3)
                        {
                            ButtonText4.Visibility = Visibility.Visible;
                            tbtextgame4.Visibility = Visibility.Visible;
                        }
                        else if (i == 4)
                        {
                            ButtonText5.Visibility = Visibility.Visible;
                            tbtextgame5.Visibility = Visibility.Visible;
                        }
                        else if (i == 5)
                        {
                            ButtonText6.Visibility = Visibility.Visible;
                            tbtextgame6.Visibility = Visibility.Visible;
                        }
                        else if (i == 6)
                        {
                            ButtonText7.Visibility = Visibility.Visible;
                            tbtextgame7.Visibility = Visibility.Visible;
                        }
                        else if (i == 7)
                        {
                            ButtonText8.Visibility = Visibility.Visible;
                            tbtextgame8.Visibility = Visibility.Visible;
                        }
                        else if (i == 8)
                        {
                            ButtonText9.Visibility = Visibility.Visible;
                            tbtextgame9.Visibility = Visibility.Visible;
                        }
                        else if (i == 9)
                        {
                            ButtonText10.Visibility = Visibility.Visible;
                            tbtextgame10.Visibility = Visibility.Visible;
                        }
                    }
                    
                }
            }
            
        }
        private async void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            natija++;
            n = 0;
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            tbtextgame1.Visibility = Visibility.Collapsed;
            tbtextgame2.Visibility = Visibility.Collapsed;
            tbtextgame3.Visibility = Visibility.Collapsed;
            tbtextgame4.Visibility = Visibility.Collapsed;
            tbtextgame5.Visibility = Visibility.Collapsed;
            tbtextgame6.Visibility = Visibility.Collapsed;
            tbtextgame7.Visibility = Visibility.Collapsed;
            tbtextgame8.Visibility = Visibility.Collapsed;
            tbtextgame9.Visibility = Visibility.Collapsed;
            tbtextgame10.Visibility = Visibility.Collapsed;
            
            lbSavolnumber.Content = $"{n + 1}-Savol";
            ButtonText2.Visibility = Visibility.Collapsed;
            ButtonText3.Visibility = Visibility.Collapsed;
            ButtonText4.Visibility = Visibility.Collapsed;
            ButtonText5.Visibility = Visibility.Collapsed;
            ButtonText6.Visibility = Visibility.Collapsed;
            ButtonText7.Visibility = Visibility.Collapsed;
            ButtonText8.Visibility = Visibility.Collapsed;
            ButtonText9.Visibility = Visibility.Collapsed;
            ButtonText10.Visibility = Visibility.Collapsed;
            int s = w[n].Word.Length;
            string path1 = w[n].image1;
            string path2 = w[n].image2;
            string path3 = w[n].image3;
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(path1, UriKind.Relative));
            imageButton1.Background = brush;
            var brush2 = new ImageBrush();
            brush2.ImageSource = new BitmapImage(new Uri(path2, UriKind.Relative));
            imageButton2.Background = brush2;
            var brush3 = new ImageBrush();
            brush3.ImageSource = new BitmapImage(new Uri(path3, UriKind.Relative));
            imageButton3.Background = brush3;
            for (int i = 0; i < s; i++)
            {
                    if (i == 0)
                    {
                        ButtonText1.Visibility = Visibility.Visible;
                        tbtextgame1.Visibility = Visibility.Visible;
                    }
                    else if (i == 1)
                    {
                        ButtonText2.Visibility = Visibility.Visible;
                        tbtextgame2.Visibility = Visibility.Visible;
                    }
                    else if (i == 2)
                    {
                        ButtonText3.Visibility = Visibility.Visible;
                        tbtextgame3.Visibility = Visibility.Visible;
                    }
                    else if (i == 3)
                    {
                        ButtonText4.Visibility = Visibility.Visible;
                        tbtextgame4.Visibility = Visibility.Visible;
                    }
                    else if (i == 4)
                    {
                        ButtonText5.Visibility = Visibility.Visible;
                        tbtextgame5.Visibility = Visibility.Visible;
                    }
                    else if (i == 5)
                    {
                        ButtonText6.Visibility = Visibility.Visible;
                        tbtextgame6.Visibility = Visibility.Visible;
                    }
                    else if (i == 6)
                    {
                        ButtonText7.Visibility = Visibility.Visible;
                        tbtextgame7.Visibility = Visibility.Visible;
                    }
                    else if (i == 7)
                    {
                        ButtonText8.Visibility = Visibility.Visible;
                        tbtextgame8.Visibility = Visibility.Visible;
                    }
                    else if (i == 8)
                    {
                        ButtonText9.Visibility = Visibility.Visible;
                        tbtextgame9.Visibility = Visibility.Visible;
                    }
                    else if (i == 9)
                    {

                        ButtonText10.Visibility = Visibility.Visible;
                        tbtextgame10.Visibility = Visibility.Visible;
                    }
            }
            

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private async void ButtonText1_Click(object sender, RoutedEventArgs e)
        {

            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText1.Visibility = Visibility.Collapsed;
                tbtextgame1.Text = "";// w[n].Word[0].ToString();
                buttonn1 = true;

            }
            else
            {
                ButtonText1.Content = w[n].Word[0];
                buttonn1 = false;
            }
            z++;

        }

        private async void ButtonText2_Click(object sender, RoutedEventArgs e)
        {
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText2.Visibility = Visibility.Collapsed;
                tbtextgame2.Text = "";// w[n].Word[1].ToString();
                buttonn2 = true;
            }
            else { 
                ButtonText2.Content = w[n].Word[1];
                buttonn2= false;    
            }
            z++;
        }

        private async void ButtonText3_Click(object sender, RoutedEventArgs e)
        {
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText3.Visibility = Visibility.Collapsed;
                tbtextgame3.Text = "";// w[n].Word[2].ToString();
                buttonn3 = true;
            }
            else
            {
                ButtonText3.Content = w[n].Word[2];
                buttonn3 = false;
            }

            z++;
        }

        private async void ButtonText4_Click(object sender, RoutedEventArgs e)
        {

            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText4.Visibility = Visibility.Collapsed;
                tbtextgame4.Text = "";// w[n].Word[3].ToString();
                buttonn4 = true;
            }
            else
            {
                ButtonText4.Content = w[n].Word[3];
                buttonn4 = false;
            }
            z++;
        }

        private async void ButtonText5_Click(object sender, RoutedEventArgs e)
        {
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText5.Visibility = Visibility.Collapsed;
                tbtextgame5.Text = "";// w[n].Word[4].ToString();
                buttonn5 = true;
            }
            else
            {
                ButtonText5.Content = w[n].Word[4];
                buttonn5 = false;
            }
            z++;
        }

        private async void ButtonText6_Click(object sender, RoutedEventArgs e)
        {
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText6.Visibility = Visibility.Collapsed;
                tbtextgame6.Text = "";// w[n].Word[5].ToString();
                buttonn6 = true;
            }
            else
            {
                ButtonText6.Content = w[n].Word[5];
                buttonn6 = false;
            }
            z++;
        }

        private async void ButtonText7_Click(object sender, RoutedEventArgs e)
        {
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText7.Visibility = Visibility.Collapsed;
                tbtextgame7.Text = "";// w[n].Word[6].ToString();
                buttonn7 = true;
            }
            else { 
                ButtonText7.Content = w[n].Word[6];
                buttonn7 = false;
            }
            z++;
        }

        private async void ButtonText8_Click(object sender, RoutedEventArgs e)
        {
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText8.Visibility = Visibility.Collapsed;
                tbtextgame8.Text = "";//w[n].Word[7].ToString();
                buttonn8 = true;
            }
            else
            {
                ButtonText8.Content = w[n].Word[7];
                buttonn8= false;
            }
            z++;
        }

        private async void ButtonText9_Click(object sender, RoutedEventArgs e)
        {
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText9.Visibility = Visibility.Collapsed;
                tbtextgame9.Text = "";// w[n].Word[8].ToString();
                buttonn9 = true;
            }
            else
            {
                ButtonText9.Content = w[n].Word[8];
                buttonn9= false;
            }
            z++;
        }
        private async void ButtonText10_Click_1(object sender, RoutedEventArgs e)
        {

            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            if (z >= w[n].Word.Length / 2)
            {
                ButtonText10.Visibility = Visibility.Collapsed;
                tbtextgame10.Text = "";// w[n].Word[9].ToString();
                buttonn10 = true;
            }
            else
            {
                ButtonText10.Content = w[n].Word[9];
                buttonn10= false;
            }
            z++;
        }
        
        public static MainWindow GetMainWindow()
        {
            MainWindow mainWindow = null;

            foreach (Window window in Application.Current.Windows)
            {
                Type type = typeof(MainWindow);
                if (window != null && window.DependencyObjectType.Name == type.Name)
                {
                    mainWindow = (MainWindow)window;
                    if (mainWindow != null)
                    {
                        break;
                    }
                }
            }
            return mainWindow;

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
