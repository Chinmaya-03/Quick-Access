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
    public sealed partial class Triangle : Page
    {
        public Triangle()
        {
            this.InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string x = ((float.Parse(i11.Text) + float.Parse(i12.Text) + float.Parse(i13.Text)) / 2).ToString();
                Area.Text = (Math.Sqrt((float.Parse(x)) *
                                                    ((float.Parse(x)) - (float.Parse(i11.Text))) *
                                                    ((float.Parse(x)) - (float.Parse(i12.Text))) *
                                                    ((float.Parse(x)) - (float.Parse(i13.Text)))))
                                                    .ToString();
            }
            catch (Exception)
            {
                Area.Text = "Please enter numbers only :)";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AShape));

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Area.Text = (0.5 * (Int32.Parse(i21.Text) * Int32.Parse(i22.Text))).ToString();
            }
            catch (Exception)
            {
                Area.Text = "Please enter numbers only :)";
            }

        }
        private void i13_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}
