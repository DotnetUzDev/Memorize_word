using Memorize_word_.Components;
using Memorize_word_.Entities.WordEntities;
using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Repositories.Word;
using Memorize_word_.Utils;
using Memorize_word_.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Memorize_word_.Pages
{
    /// <summary>
    /// Interaction logic for AddWordPage.xaml
    /// </summary>
    /// 


    public partial class AddWordPage : Page
    {

        private readonly IWordRepositories _wordRepositories;
        private IList<Words> words { get; set; }
        public AddWordPage()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

            CreateWordWindow createWordWindow = new CreateWordWindow();
            createWordWindow.ShowDialog();

        }
        public async Task RefreshAsync()
        {
            wrpWord.Children.Clear();
            PaginationParams paginationParams = new PaginationParams()
            {
                PageNumber = 1,
                PageSize = 30
            };
            words = await _wordRepositories.GetAllAsync(paginationParams);
            foreach (Words word in words)
            {
                WordComponenT wordComponenT = new WordComponenT();
                wordComponenT.SetData(word);
                wrpWord.Children.Add(wordComponenT);
            }
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await RefreshAsync();
        }
        private async void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = tbSearch.Text;
            var resultMedicine = words.Where(m => m.Word.ToLower().StartsWith(str)).ToList();
            wrpWord.Children.Clear();

            foreach (var m in resultMedicine)
            {
                WordComponenT medicineViewUserControl = new WordComponenT();
                medicineViewUserControl.SetData(m);
                wrpWord.Children.Add(medicineViewUserControl);
            }
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            string str = tbSearch.Text;
            var resultMedicine = words.Where(m => m.Word.ToLower().StartsWith(str)).ToList();
            wrpWord.Children.Clear();

            foreach (var m in resultMedicine)
            {
                WordComponenT wordViewUserControl = new WordComponenT();
                wordViewUserControl.SetData(m);
                wrpWord.Children.Add(wordViewUserControl);
            }
        }
    }
}
