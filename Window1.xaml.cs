using System.Windows;

namespace _6TTI_DPMAEL_WPF1EVENT
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            boutonRetour.Click += Retour;
        }

        private void Retour(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}