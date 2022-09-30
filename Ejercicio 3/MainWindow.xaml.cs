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

namespace Ejercicio_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img.Opacity = 1;
        }
        private void mediaOpc_Checked(object sender, RoutedEventArgs e)
        {
            img.Opacity = 0.66;
        }

        private void bajaOpc_Checked(object sender, RoutedEventArgs e)
        {
            img.Opacity = 0.33;
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            img.Stretch = Stretch.Uniform;
        }

        private void rellAjt_Checked(object sender, RoutedEventArgs e)
        {
            img.Stretch = Stretch.Fill;
        }

        private void uniRellAjt_Checked(object sender, RoutedEventArgs e)
        {
            img.Stretch = Stretch.UniformToFill;
        }

        private void noneAjt_Checked(object sender, RoutedEventArgs e)
        {
            img.Stretch = Stretch.None;
        }
    }
}
