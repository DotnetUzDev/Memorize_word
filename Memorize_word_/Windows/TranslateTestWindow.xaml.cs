using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Pages;
using Memorize_word_.Repositories.Word;
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

namespace Memorize_word_.Windows
{
    /// <summary>
    /// Interaction logic for TranslateTestWindow.xaml
    /// </summary>
    public partial class TranslateTestWindow : Window
    {
        public int k { get; set; }

        public int togri { get; set; }

        public int notogri { get; set; }


        public int natija { get; set; }

        public int h { get; set; }

        public int j { get; set; }
        public int son { get; set; }

        private readonly IWordRepositories _wordRepositories;
        public TranslateTestWindow()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
        }
        public TranslateTestWindow(int son)
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
            this.son = son;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("LLL");
            
        }
    

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private async void trtestB_Click(object sender, RoutedEventArgs e)
        {
            j = 2;
            Tem(j);
            await Task.Delay(1000);
            btntrNext_Click(sender, e);
        }

        private async void trtestA_Click(object sender, RoutedEventArgs e)
        {
            j = 1;
            Tem(j);
            await Task.Delay(1000);
            btntrNext_Click(sender, e);
        }

        private async void trtestC_Click(object sender, RoutedEventArgs e)
        {
            j = 3;
            Tem(j);
            await Task.Delay(1000);
            btntrNext_Click(sender, e);
        }

        private async void trtestD_Click(object sender, RoutedEventArgs e)
        {
            j = 4;
            Tem(j);
            await Task.Delay(1000);
            btntrNext_Click(sender, e);
        }
        public static MainWindow GetMainWindow()
        {
            MainWindow mainWindow = null!;

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
            return mainWindow!;

        }

        private async void btntrNext_Click(object sender, RoutedEventArgs e)
            
        {
            lbtrtestshot.Content = $"{k+1}/{son}";
            if (k >= son)
            {
                MainWindow mainWindow = GetMainWindow();
                Hisob hisob = new Hisob();
                hisob.lbtogri.Content = togri;
                hisob.lbnotogri.Content = notogri;
                mainWindow.PageNavigator.Content = hisob;
                this.Close();
            }
            else
            {
                var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(10, 100));
                Random random = new Random();
                h = random.Next(1, 4);
                lbtrtest.Content = w[k].Word;
                trtestA.Content = w[k + 1].translate;
                trtestB.Content = w[k + 2].translate;
                trtestC.Content = w[k + 3].translate;
                trtestD.Content = w[k + 4].translate;
                if (h == 1)
                {
                    trtestA.Content = w[k].translate;
                }
                else if (h == 2)
                {
                    trtestB.Content = w[k].translate;
                }
                else if (h == 3)
                {
                    trtestC.Content = w[k].translate;
                }
                else if (h == 4)
                {
                    trtestD.Content = w[k].translate;
                }
            }
            k++;
        }
        public async void Tem(int j)
        {

            if (j == 1)
            {
                if (j == h)
                {
                    trtestA.Style = buttonyashil.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    trtestA.Style = buttonqizil.Style;
                    notogri++;
                    if(h==2)
                    {
                        trtestB.Style = buttonyashil.Style;
                    }
                    if (h == 3)
                    {
                        trtestC.Style = buttonyashil.Style;
                    }
                    if (h == 4)
                    {
                        trtestD.Style = buttonyashil.Style;
                    }
                }
            }

            else if (j == 2)
            {
                if (j == h)
                {
                    trtestB.Style = buttonyashil.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    trtestB.Style = buttonqizil.Style;
                    notogri++;
                    if (h == 1)
                    {
                        trtestA.Style = buttonyashil.Style;
                    }
                    if (h == 3)
                    {
                        trtestC.Style = buttonyashil.Style;
                    }
                    if (h == 4)
                    {
                        trtestD.Style = buttonyashil.Style;
                    }
                }
            }
            else if (j == 3)
            {
                if (j == h)
                {
                    trtestC.Style = buttonyashil.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    trtestC.Style = buttonqizil.Style;
                    notogri++;
                    if (h == 2)
                    {
                        trtestB.Style = buttonyashil.Style;
                    }
                    if (h == 1)
                    {
                        trtestA.Style = buttonyashil.Style;
                    }
                    if (h == 4)
                    {
                        trtestD.Style = buttonyashil.Style;
                    }
                }
            }
            else if (j == 4)
            {
                if (j == h)
                {
                    trtestD.Style = buttonyashil.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    trtestD.Style = buttonqizil.Style;
                    notogri++;
                    if (h == 2)
                    {
                        trtestB.Style = buttonyashil.Style;
                    }
                    if (h == 3)
                    {
                        trtestC.Style = buttonyashil.Style;
                    }
                    if (h == 1)
                    {
                        trtestA.Style = buttonyashil.Style;
                    }
                }
            }
            await Task.Delay(1000);
            trtestA.Style = buttonw.Style;
            trtestB.Style = buttonw.Style;
            trtestC.Style = buttonw.Style;
            trtestD.Style = buttonw.Style;


        }

        private void buttonqizil_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbtrtestshot.Content = $"{k+1}/{son}";
            Random random = new Random();
            h = random.Next(1, 4);
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            lbtrtest.Content = w[k].Word;
            trtestA.Content = w[k + 3].translate;
            trtestB.Content = w[k + 2].translate;
            trtestC.Content = w[k + 4].translate;
            trtestD.Content = w[k + 1].translate;
            if (h == 1)
            {
                trtestA.Content = w[k].translate;
            }
            else if (h == 2)
            {
                trtestB.Content = w[k].translate;
            }
            else if (h == 3)
            {
                trtestC.Content = w[k].translate;
            }
            else if (h == 4)
            {
                trtestD.Content = w[k].translate;
            }
            k++;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //TranslateTestWindow translateTestWindow = new TranslateTestWindow();
            this.Close();
        }
    }
}
