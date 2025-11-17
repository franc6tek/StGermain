using StGermain.Pages;
using StGermain.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

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
    }
}
