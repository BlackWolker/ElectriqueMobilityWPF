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

namespace ElectriqueMobility
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Apropos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Categorie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Produit_Click(object sender, RoutedEventArgs e)
        {
            //UserControlRevue lapage = new UserControlRevue();
            //Content.Content = lapage;
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
