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

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private byte red;
        private byte green;
        private byte blue;

        public MainWindow()
        {
            InitializeComponent();
            SetRectangleColor(0, 0, 0);
        }
        private void SetRectangleColor(byte red,byte green, byte blue)
        {
            rectangle_magic.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
        private void Slider_red_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            red = (byte)slider_red.Value;
            SetRectangleColor(red, green, blue);
        }

        private void Slider_green_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            green = (byte)slider_green.Value;
            SetRectangleColor(red, green, blue);
        }

        private void Slider_blue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            blue = (byte)slider_blue.Value;
            SetRectangleColor(red, green, blue);
        }
    }
}
