using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace Zadanie_comandi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
    
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = (sender as ComboBox).SelectedItem as String;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble((sender as ComboBox).SelectedItem as String);
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string weight = "Bold";
            FontWeight fw = (FontWeight)new FontWeightConverter().ConvertFromString(weight);
            textBox.FontWeight = fw;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string style = "Italic";
            FontStyle fs = (FontStyle)new FontStyleConverter().ConvertFromString(style);
            textBox.FontStyle = fs;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextDecorationCollection tcd = new TextDecorationCollection(1);
            tcd.Add(TextDecorations.Underline);
            textBox.TextDecorations = tcd;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                Brush bl = (Brush)new BrushConverter().ConvertFromString("Black");
                textBox.Foreground = bl;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                Brush rd = (Brush)new BrushConverter().ConvertFromString("Red");
                textBox.Foreground = rd;
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void newWindowExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Window1 newWindow = new Window1();
            newWindow.WindowStyle = WindowStyle.ToolWindow;
            newWindow.ShowDialog();
        }

        private void inCenterExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Double width = SystemParameters.FullPrimaryScreenWidth;
            Double heiht = SystemParameters.FullPrimaryScreenHeight;
            this.Top = (heiht - this.Height) / 2;
            this.Left = (width - this.Width) / 2;
        }

        private void showErrorExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Внимание! Ошибка!", "Ошибка в программе!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ExitCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (textBox!=null&&textBox.Text.Length==0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }

        }

        private void darkThemesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Uri uri = new Uri("Dark.xaml",UriKind.Relative);
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }

        private void whiteThemesExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Uri uri = new Uri("White.xaml", UriKind.Relative);
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }
    }
}
