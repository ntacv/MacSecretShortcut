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


namespace secretShortcut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            apple1.Visibility = Visibility.Collapsed;
            apple2.Visibility = Visibility.Visible;
            apple3.Visibility = Visibility.Collapsed;

            


        }

        private void ChangeGif(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void ChangeGif1(object sender, MouseButtonEventArgs e)
        {
            apple1.Visibility = Visibility.Collapsed;
            apple3.Visibility = Visibility.Visible;
        }
        private void ChangeGif2(object sender, MouseButtonEventArgs e)
        {
            apple2.Visibility = Visibility.Collapsed;
            apple1.Visibility = Visibility.Visible;
        }
        private void ChangeGif3(object sender, MouseButtonEventArgs e)
        {
            apple3.Visibility = Visibility.Collapsed;
            apple2.Visibility = Visibility.Visible;
        }

        
    }

}
