using Memorize_word_.Entities.WordEntities;
using Memorize_word_.Interfase.WordRep;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memorize_word_.Components
{
    /// <summary>
    /// Interaction logic for WordComponenT.xaml
    /// </summary>
    public partial class WordComponenT : UserControl
    {
        private Words Words { get; set; } 

        private readonly IWordRepositories _wordRepositories;
        public WordComponenT()
        {
            InitializeComponent();
            this._wordRepositories = new WordRepositories();
            Words  = new Words();
        }
        public void SetData(Words words)
        {
            lbwordcom.Content = words.translate;
            lbwordtrcom.Content = words.Word;
            //imagebrush.ImageSource = new BitmapImage(new Uri(words.image1,UriKind.Relative));
            Words = words;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to delete this word?", "Warning", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                var result2 = _wordRepositories.DeleteAsync(Words.id);
            }
        }
    }
}
