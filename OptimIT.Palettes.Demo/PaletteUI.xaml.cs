using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OptimIT.Palettes.Demo
{
    /// <summary>
    /// Interaction logic for PaletteUI.xaml
    /// </summary>
    public partial class PaletteUI : UserControl
    {
        public PaletteUI()
        {
            InitializeComponent();

            list.SelectionChanged += List_flatui_SelectionChanged;
        }
         



        public string TextSource
        {
            get { return (string)GetValue(TextSourceProperty); }
            set { SetValue(TextSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextSourceProperty =
            DependencyProperty.Register("TextSource", typeof(string), typeof(PaletteUI), new UIPropertyMetadata("", SourceChanged));




        public Type ColorClass
        {
            get { return (Type)GetValue(ColorClassProperty); }
            set { SetValue(ColorClassProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ColorClass.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorClassProperty =
            DependencyProperty.Register("ColorClass", typeof(Type), typeof(PaletteUI), new UIPropertyMetadata(null, ColorClassChanged));

        private static void ColorClassChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                var type = (Type)e.NewValue;
                ((PaletteUI)d).list.ItemsSource = Helpers.ClassToPalette(type);
            }
            catch
            {

            }
        }

        private static void SourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            try
            {
                ((PaletteUI)d).t_source.Text = "Source : " + e.NewValue.ToString();
            }
            catch
            {

            }
        }

        private void List_flatui_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lst = sender as ListBox;

            if (lst == null || lst.SelectedItem == null)
                return;

            var item = lst.SelectedItem as PaletteColor;
            Clipboard.SetText(item.Hex);
            MessageBox.Show("Copied");
        }
    }
}
