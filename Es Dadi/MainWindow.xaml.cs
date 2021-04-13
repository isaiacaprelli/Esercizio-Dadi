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
using System.Threading.Tasks;
using System.Threading;

namespace Es_Dadi
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool lanciareDado = false;

        private void btnLanciaDadi_Click(object sender, RoutedEventArgs e) //bottone per far partire il dado
        {
            
            if (lanciareDado == false)      //controlla se il dado è fermo
            {
                btnLanciaDadi.IsEnabled = false;
                btnStoppaDadi.IsEnabled = true;
                lanciareDado = true;
                Lancia();
            }
        }

        private void btnStoppaDadi_Click(object sender, RoutedEventArgs e) //bottone per far stoppare il dado
        {
            
            if (lanciareDado == true)   //controlla se il dado si sta muovendo
            { 
                btnStoppaDadi.IsEnabled = false;
                btnLanciaDadi.IsEnabled = true;
                lanciareDado = false;
            }
        }
        private async void Lancia()
        {
            await Task.Run(() =>
            {
                if (lanciareDado == true)
                {
                    Random val = new Random();

                    int dado1 = val.Next(1, 7);
                    int dado2 = val.Next(1, 7);
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        Dadi1.Source = CambioDado("faccia dado " + dado1 + ".jpg"); //facciamo cambiare immagine nella casella delle immagini nel wpf, in base al suo numero 
                        Dadi2.Source = CambioDado("faccia dado " + dado2 + ".jpg");
                    }));

                    Thread.Sleep(100);
                   Lancia();
                }
            });

            ImageSource CambioDado(string s) //metodo per far cambiare le immagini 
            {
                Uri u = new Uri(s, UriKind.Relative);
                ImageSource immagine = new BitmapImage(u);
                return immagine;
            }
        }

      
    }
}
