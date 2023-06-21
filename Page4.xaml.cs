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
using Microsoft.Win32;
using System.IO;

namespace navigation
{
    /// <summary>
    /// Interaktionslogik für Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_left_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Page3.xaml", UriKind.Relative));
        }

        private void Button_right_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Page5.xaml", UriKind.Relative));
        }
    }
}
