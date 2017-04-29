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
    public sealed partial class AShape : Page
    {
        public AShape()
        {
            this.InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Triangle));
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(circle));
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Sector));
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ellipse));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rectangle));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Square));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Parallelogram));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Trapezium));
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
