using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace tty
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QAccess : Page
    {
        public QAccess()
        {
            this.InitializeComponent();
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(News));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Search));
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Education));

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Cloud));
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Networking));

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Mailing));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ecom));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Videos));
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Games));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Software));
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
