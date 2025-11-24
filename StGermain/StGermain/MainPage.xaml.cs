using StGermain.Pages;
using StGermain.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace StGermain
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CurrentPage.Content = new Accueil();
            DataContext = new MainViewModel(); 
        }

        private void LoadAccueilClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/Accueil.xaml", UriKind.Relative));
        }

        private void LoadHotelClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/hotel.xaml", UriKind.Relative));
        }

        private void LoadChambresClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/Chambres.xaml", UriKind.Relative));
        }

        private void LoadTarifsClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/Tarifs.xaml", UriKind.Relative));
        }
        private void LoadServicesClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/Services.xaml", UriKind.Relative));
        }
        private void LoadGalerieClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/Galerie.xaml", UriKind.Relative));
        }

        private void LoadContactClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/Contact.xaml", UriKind.Relative));
        }

        private void LoadRestaurantClick(object sender, RoutedEventArgs e)
        {
            CurrentPage.Navigate(new Uri("/Pages/Restaurant.xaml", UriKind.Relative));
        }

        private void WrapPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (MenuBar.ActualWidth <= 460)
            {
                if (MenuDeroulant.Visibility == Visibility.Collapsed)
                {
                    home.Visibility = Visibility.Hidden;
                    location.Visibility = Visibility.Hidden;
                    doublebed.Visibility = Visibility.Hidden;
                    wallet.Visibility = Visibility.Hidden;
                    support.Visibility = Visibility.Hidden;
                    image.Visibility = Visibility.Hidden;
                    contact.Visibility = Visibility.Hidden;
                    dinner.Visibility = Visibility.Hidden;
                    MenuDeroulant.Visibility = Visibility.Visible;
                }
            }
            else
            {
                if (MenuDeroulant.Visibility == Visibility.Visible)
                {
                    home.Visibility = Visibility.Visible;
                    location.Visibility = Visibility.Visible;
                    doublebed.Visibility = Visibility.Visible;
                    wallet.Visibility = Visibility.Visible;
                    support.Visibility = Visibility.Visible;
                    image.Visibility = Visibility.Visible;
                    contact.Visibility = Visibility.Visible;
                    dinner.Visibility = Visibility.Visible;
                    MenuDeroulant.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
