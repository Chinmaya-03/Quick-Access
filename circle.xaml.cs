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
    public sealed partial class circle : Page
    {
        public circle()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Area.Text = (3.141592653589793238462643383279502884197169399375105820974944592307816406286 * float.Parse(i1.Text) * float.Parse(i1.Text)).ToString();

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
    }
}



