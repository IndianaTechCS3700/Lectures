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

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnDisable_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement item in this.PanelOne.Children)
            {
                item.IsEnabled = false;
            }
        }

        private void btnEnable_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement item in this.PanelOne.Children)
            {
                item.IsEnabled = true;
            }
        }

        private void btnSetText_Click(object sender, RoutedEventArgs e)
        {
            foreach (UIElement item in this.PanelOne.Children)
            {

                ContentControl bar = item as ContentControl;
                if(bar != null)
                {
                    bar.Content = "test";
                }
                if (item is ContentControl)
                {
                    //ContentControl foo = item;
                    ContentControl foo = item as ContentControl;
                    //ContentControl baz = (ContentControl)item;

                    //baz.Content = "My Custom Text";
                    //item.Content = "My Custom Text";
                    foo.Content = "My Custom Text";
                }
                if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    rb.IsChecked = true;
                }
            }
        }

    }
}