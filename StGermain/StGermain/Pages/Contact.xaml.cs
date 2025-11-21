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

            AddMaps();
            //contactWebBrowser.Navigate(new Uri("https://www.google.com/maps/@48.8486087,2.2203844,2088m"));
        }

        private void AddMaps()
        {
            string htmlContent = @"
                                    <html>
                                      <head>
                                        <link rel=""stylesheet"" href=""https://unpkg.com/leaflet/dist/leaflet.css""/>
                                        <script src=""https://unpkg.com/leaflet/dist/leaflet.js""></script>
                                      </head>
                                      <body style=""color:rgb(0,0,0);background-color:rgb(0,0,0);"">
                                        <div id=""map"" style=""width: 100%; height: 100%;""></div>
                                        <script>
                                          var map = L.map(""map"").setView([48.8584, 2.2945], 14);
                                          L.tileLayer(""https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"").addTo(map);
                                          L.marker([48.8584, 2.2945]).addTo(map);
                                        </script>
                                        <script src=""https://code.jquery.com/jquery-3.7.0.min.js""></script>
                                        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js""></script>
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
