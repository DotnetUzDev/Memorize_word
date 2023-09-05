﻿using Memorize_word_.Interfase.WordRep;
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

namespace Memorize_word_.Pages
{
    /// <summary>
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    /// 
    
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
