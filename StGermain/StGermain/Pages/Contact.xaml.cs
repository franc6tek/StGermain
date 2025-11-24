using StGermain.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string message = MessageTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
            {
                StatusTextBlock.Text = "Veuillez remplir tous les champs.";
                return;
            }

            try
            {
                await EnvoyerEmailHelper.EnvoyerEmailMailerSend(email, name, message);
            }
            catch (Exception ex)
            {
                StatusTextBlock.Text = "Erreur réseau: " + ex.Message;
            }
            finally
            {
                NameTextBox.Text = string.Empty;
                EmailTextBox.Text = string.Empty;
                MessageTextBox.Text = string.Empty;
            }
        }
    }
}
