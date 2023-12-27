using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Repositories.Word;
using System.Windows.Controls;

namespace Memorize_word_.Pages
{
    public partial class DashboardPage : Page
    {
        private readonly IWordRepositories _wordRepositories;
        public DashboardPage()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
        }
        public object PageNavigator { get; private set; }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}