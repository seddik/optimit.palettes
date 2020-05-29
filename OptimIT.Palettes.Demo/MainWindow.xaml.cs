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


            //string s = "";
            //var list_colors = new List<string>();
            //foreach (var item in main_tab.Items.OfType<TabItem>().Select(X => X.Content).Cast<PaletteUI>().ToList())
            //{
            //    var lst = Helpers.ClassToPalette(item.ColorClass);

            //    foreach (var color in lst)
            //    {
            //        if (color.Hex.Length != 7)
            //            continue;
            //        if (list_colors.Contains(color.Name))
            //            continue;

            //        s += $@"<SolidColorBrush x:Key=""{color.Name}""  Color=""{color.Hex}""/>" + Environment.NewLine;
            //    }

            //    s += Environment.NewLine;
            //}


        }


    }
}
