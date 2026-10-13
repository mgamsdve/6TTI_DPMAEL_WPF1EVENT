using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace _6TTI_DPMAEL_WPF1EVENT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            boutonCalculer.Click += Calculer;

            TxtA.PreviewTextInput += VerifTextInput;
            TxtB.PreviewTextInput += VerifTextInput;
            TxtC.PreviewTextInput += VerifTextInput;

            boutonV.Visibility = Visibility.Hidden;

            boutonCalculer.MouseEnter += new MouseEventHandler(SurvolBouton);
            boutonCalculer.MouseLeave += new MouseEventHandler(QuitterBouton);
        }

        private bool EstEntier(string texteUser)
        {
            int nombre;
            return int.TryParse(texteUser, out nombre);
        }

        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox zone = (TextBox)sender;

            if (e.Text == ",")
            {
                if (zone.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!EstEntier(e.Text))
                {
                    e.Handled = true;
                }
            }
        }

        private void Calculer(object sender, RoutedEventArgs e)
        {
            string message;

            if (!double.TryParse(TxtA.Text, out double a)
                || !double.TryParse(TxtB.Text, out double b)
                || !double.TryParse(TxtC.Text, out double c))
            {
                MessageBox.Show("Entre trois nombres valides.");
                return;
            }

            MethodesDuProjet mesOutils = new MethodesDuProjet();
            mesOutils.ResoudreTrinome(a, b, c, out message);

            Window1 secondeFenetre = new Window1();
            secondeFenetre.Owner = this;
            secondeFenetre.LblResultat.Text = message;
            secondeFenetre.ShowDialog(); 
        }

        private void SurvolBouton(object sender, MouseEventArgs e)
        {
            boutonV.Visibility = Visibility.Visible;
            boutonV.Background = Brushes.Red;
        }

        private void QuitterBouton(object sender, MouseEventArgs e)
        {
            boutonV.Visibility = Visibility.Hidden;
        }

    }
}