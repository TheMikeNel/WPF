using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> splitWords = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            SplitLineList.ItemsSource = splitWords;
        }

        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            splitWords.Clear();

            if (SplitLineTB.Text != null)
            {
                foreach (string word in SplitLineTB.Text.Split(' '))
                {
                    splitWords.Add(word);
                }
            }
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReverseLineTB.Text != null)
            {
                string[] words = SplitLineTB.Text.Split(' ');
                string line = string.Empty;

                for (int i = words.Length - 1; i >= 0; i--) 
                {
                    line += $"{words[i]} ";
                }

                ReverseLabel.Content = line;
            }
        }
    }
}
