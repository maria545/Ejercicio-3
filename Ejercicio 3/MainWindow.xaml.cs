
using System.Windows;

using System.Windows.Media;


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

        private void radioBotonMedio_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.6;
        }

        private void radioBotonAlta_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1;
        }

        private void radioBotonBaja_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.3;
        }


        private void radioBotonRelleno_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void radioBotonUniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void radioBotonRellenoUniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void radioBotonSinAjuste_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}
