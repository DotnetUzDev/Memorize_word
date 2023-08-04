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
    /// Interaction logic for TestAddPage.xaml
    /// </summary>
    public partial class TestAddPage : Page
    {
       
        public int dt { get; set; }
        private readonly IWordRepositories _wordRepositories;
        public TestAddPage()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbtestnumber.Text.Length > 0)
            {
                dt = int.Parse(tbtestnumber.Text);
                TestWindow testWindow = new TestWindow(dt);
                testWindow.ShowDialog();
            }
            else MessageBox.Show("Test Sonini Kiriting!!!");
            

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (tbtestnumber.Text.Length > 0)
            {
                var w = await _wordRepositories.GetAllAsync(new Utils.PaginationParams(1, 100));
                dt = int.Parse(tbtestnumber.Text);
                TranslateTestWindow translateTestWindow = new TranslateTestWindow(dt);
                //Random random = new Random();
                //int h = random.Next(1, 4);
                //translateTestWindow.lbtrtest.Content = w[k].Word;
                //translateTestWindow.trtestA.Content = w[k + 1].translate;
                //translateTestWindow.trtestB.Content = w[k + 2].translate;
                //translateTestWindow.trtestC.Content = w[k + 3].translate;
                //translateTestWindow.trtestD.Content = w[k + 4].translate;
                //if (h == 1)
                //{
                //    MessageBox.Show("lll");
                //    translateTestWindow.trtestA.Content = w[k].translate;
                //}
                //else if (h == 2)
                //{
                //    translateTestWindow.trtestB.Content = w[k].translate;
                //}
                //else if (h == 3)
                //{
                //    translateTestWindow.trtestC.Content = w[k].translate;
                //}
                //else if (h == 4)
                //{
                //    translateTestWindow.trtestD.Content = w[k].translate;
                //}
                translateTestWindow.ShowDialog();

            }
            else MessageBox.Show("Test Sonini Kiriting!!!");
            
            

        }
    }
}
