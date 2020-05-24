using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OptimIT.Palettes;

namespace OptimIT.Palettes.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            list_flatui.ItemsSource = Helpers.ClassToPalette<FlatUI>();

            list_flatui.SelectionChanged += List_flatui_SelectionChanged;
        }

        private void List_flatui_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = sender as ListBox;

            if (list == null || list.SelectedItem == null)
                return;

            var item = list.SelectedItem as PaletteColor;
            Clipboard.SetText(item.Hex);
            MessageBox.Show("Copied");
        }
    }
}
