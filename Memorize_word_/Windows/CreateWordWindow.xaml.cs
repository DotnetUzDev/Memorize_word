using Memorize_word_.Constans;
using Memorize_word_.Entities.WordEntities;
using Memorize_word_.Healpers;
using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Pages;
using Memorize_word_.Repositories.Word;
using Microsoft.Win32;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Memorize_word_.Windows
{
    /// <summary>
    /// Interaction logic for CreateWordWindow.xaml
    /// </summary>
    public partial class CreateWordWindow : Window
    {
        private readonly AddWordPage _page;
        private readonly IWordRepositories _wordRepositories;
        public CreateWordWindow()
        {
            InitializeComponent();
            this._page = new AddWordPage();
            this._wordRepositories = new WordRepositories();
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)

        {
            Words words = new Words();
            words.Word = tbWord.Text;
            string imagepath1 = "";
            string imagepath2 = "";
            string imagepath3 = "";
            words.translate = tbWordTranslate.Text;
            words.example = tbexample.Text;
            words.describtion = tbdescription.Text;
            if(ImgB1.ImageSource != null)
            {
                imagepath1 = ImgB1.ImageSource.ToString();
            }
            if (!String.IsNullOrEmpty(imagepath1))
                words.image1 = await CopyImageAsync(imagepath1,
                   ContentConstans.IMAGE_CONTENTS_PATH);

            if (ImgB2.ImageSource != null)
            {
                imagepath2 = ImgB1.ImageSource!.ToString();
            }
            if (!String.IsNullOrEmpty(imagepath2))
                words.image2 = await CopyImageAsync(imagepath2,
                   ContentConstans.IMAGE_CONTENTS_PATH);
            if (ImgB3.ImageSource != null)
            {
                imagepath3 = ImgB1.ImageSource!.ToString();
            }
            if (!String.IsNullOrEmpty(imagepath3))
                words.image3 = await CopyImageAsync(imagepath3,
                   ContentConstans.IMAGE_CONTENTS_PATH);
            words.CreatedAt = words.UpdatedAt = TimeHealpers.GetDateTime();
            var result = await _wordRepositories.CreateAsync(words);
            await _page.RefreshAsync();
            if (result > 0)
            {
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = GetImageDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string imgPath = openFileDialog.FileName;
                ImgB1.ImageSource = new BitmapImage(new Uri(imgPath, UriKind.Relative));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var openFileDialog = GetImageDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string imgPath = openFileDialog.FileName;
                ImgB2.ImageSource = new BitmapImage(new Uri(imgPath, UriKind.Relative));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var openFileDialog = GetImageDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string imgPath = openFileDialog.FileName;
                ImgB3.ImageSource = new BitmapImage(new Uri(imgPath, UriKind.Relative));
            }
        }
        private OpenFileDialog GetImageDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            return openFileDialog;
        }
        private async Task<string> CopyImageAsync(string imgPath, string destinationDirectory)
        {
            if (!Directory.Exists(destinationDirectory))
                Directory.CreateDirectory(destinationDirectory);

            var imageName = ContentNameMaker.GetImageName(imgPath);

            string path = System.IO.Path.Combine(destinationDirectory, imageName);

            byte[] image = await File.ReadAllBytesAsync(imgPath);

            await File.WriteAllBytesAsync(path, image);

            return path;
        }
    }
}
