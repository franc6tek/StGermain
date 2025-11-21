using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace StGermain.Pages
{
    public partial class Contact : Page
    {
        public Contact()
        {
            this.InitializeComponent();
            //string mapIframe = "<iframe width='100%' height='100%' " +
            //           "src='https://www.google.com/maps/embed?pb=...'></iframe>";
            //contactWebBrowser. = mapIframe;
            AddMaps();
            //contactWebBrowser.Navigate(new Uri("https://www.google.com/maps/@48.8486087,2.2203844,2088m"));
        }

        private void AddMaps()
        {
            string htmlContent = @"
                                   <html>
                                      <head>
                                      </head>
                                      <body>
                                        <iframe
                                     		id=""inlineFrameExample""
                                     		title=""Inline Frame Example""
                                     		width=""350""
                                     		height=""550""
                                     		src=""https://www.openstreetmap.org/export/embed.html?bbox=11.5458%2C3.9333%2C11.5678%2C3.9553&amp;layer=mapnik&amp;marker=3.9443574%2C11.5568169"">
                                          </iframe>
                                      </body>
                                    </html>";
            contactWebBrowser.NavigateToString(htmlContent);
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
