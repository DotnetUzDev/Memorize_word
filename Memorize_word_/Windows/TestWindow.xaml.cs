using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Pages;
using Memorize_word_.Repositories.Word;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Memorize_word_.Windows
{

    public partial class TestWindow : Window
    {

        private readonly IWordRepositories _wordRepositories;
        public int k { get; set; }

        public int togri { get; set; }

        public int notogri { get; set; }


        public int natija { get; set; }

        public int h { get; set; }

        public int j { get; set; }
        public int son { get; set; }

        public TestWindow()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
        }
        public TestWindow(int son)
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
            this.son = son;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestWindow testWindow = new TestWindow();
            this.Close();

        }

        private async void ButtonTestNext_Click(object sender, RoutedEventArgs e)
        {
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
                var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));

                string s2 = w[k].example;
                s2 = satr(s2, w[k].Word);
                Random random = new Random();
                h = random.Next(1, 4);
                lbSavoltest2.Text = "1:" + s2;
                lbsavolnumber.Content = $"{k + 1}-Savol";
                buttonA.Content = w[k + 1].Word;
                buttonB.Content = w[k + 2].Word;
                buttonC.Content = w[k + 3].Word;
                buttonD.Content = w[k + 4].Word;
                if (h == 1)
                {
                    buttonA.Content = w[k].Word;
                }
                else if (h == 2)
                {
                    buttonB.Content = w[k].Word;
                }
                else if (h == 3)
                {
                    buttonC.Content = w[k].Word;
                }
                else if (h == 4)
                {
                    buttonD.Content = w[k].Word;
                }
            }
            k++;
        }
        public string satr(string a, string b)
        {
            string[] s = a.Split(" ");
            string t = "";
            for (int e = 0; e < s.Length; e++)
            {
                bool lamp = false;
                string g = s[e];
                for (int i = 0; i < b.Length; i++)
                {
                    try
                    {
                        if (g[i] != b[i])
                        {
                            lamp = true;

                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                if (lamp == false)
                {
                    for(int i=0;i<b.Length;i++)
                        t += "* ";
                }
                else t += g + " ";
            }
            return t;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            h = random.Next(1, 4);
            var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
            string s1 = w[k].describtion;
            string s2 = w[k].example;
            string a = w[k].translate;
            string s4 = satr(s1, a);
            string s3 = satr(s2, a);
            lbSavoltest2.Text = "1:" + s3;
            lbsavolnumber.Content = $"{k + 1}-TEST";

            buttonA.Content = w[k + 3].Word;
            buttonB.Content = w[k + 2].Word;
            buttonC.Content = w[k + 4].Word;
            buttonD.Content = w[k + 1].Word;
            if (h == 1)
            {
                buttonA.Content = w[k].Word;
            }
            else if (h == 2)
            {
                buttonB.Content = w[k].Word;
            }
            else if (h == 3)
            {
                buttonC.Content = w[k].Word;
            }
            else if (h == 4)
            {
                buttonD.Content = w[k].Word;
            }
            k++;

        }
        private async void buttonB_Click(object sender, RoutedEventArgs e)
        {
            j = 2;
            Tem(j);
            await Task.Delay(1000);
            ButtonTestNext_Click(sender, e);
        }
        private async void buttonD_Click(object sender, RoutedEventArgs e)
        {
            j = 4;
            Tem(j);
            await Task.Delay(1000);
            ButtonTestNext_Click(sender, e);
        }
        private async void buttonA_Click(object sender, RoutedEventArgs e)
        {
            j = 1;
            Tem(j);
            await Task.Delay(1000);
            ButtonTestNext_Click(sender, e);
        }
        private async void buttonC_Click(object sender, RoutedEventArgs e)
        {
            j = 3;
            Tem(j);
            await Task.Delay(1000);
            ButtonTestNext_Click(sender, e);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public async void Tem(int j)
        {

            if (j == 1)
            {
                if (j == h)
                {
                    buttonA.Style = ButtonTestNext.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    buttonA.Style = buttonXXX.Style;
                    notogri++;
                }
            }

            else if (j == 2)
            {
                if (j == h)
                {
                    buttonB.Style = ButtonTestNext.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    buttonB.Style = buttonXXX.Style;
                    notogri++;
                }
            }
            else if (j == 3)
            {
                if (j == h)
                {
                    buttonC.Style = ButtonTestNext.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    buttonC.Style = buttonXXX.Style;
                    notogri++;
                }
            }
            else if (j == 4)
            {
                if (j == h)
                {
                    buttonD.Style = ButtonTestNext.Style;
                    natija += 1;
                    togri++;
                }
                else
                {
                    buttonD.Style = buttonXXX.Style;
                    notogri++;
                }
            }
            await Task.Delay(1000);
            buttonA.Style = buttonw.Style;
            buttonB.Style = buttonw.Style;
            buttonC.Style = buttonw.Style;
            buttonD.Style = buttonw.Style;

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
    }
}
