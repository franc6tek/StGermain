using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace StGermain.Pages
{
    public partial class Galerie : Page
    {
        public Galerie()
        {
            this.InitializeComponent();
            
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var image = (sender as Button).Background as ImageBrush;
            if (image != null && image.ImageSource != null)
            {
                var fullScreenWindow = new ChildWindow
                {
                    //Background = Brushes.Black,
                    Content = new Image
                    {
                        Source = image.ImageSource,
                        Stretch = Stretch.Uniform
                    }
                };
                fullScreenWindow.IsModal = true;
                fullScreenWindow.MouseLeftButtonUp += (s, args) => fullScreenWindow.Close();
                fullScreenWindow.Show();
            }
        }
    }
}
