using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace AuthConsoleApp
{
    class Program
    {
        private const string _clientId = "?";
        private const string _tenantId = "?";
        private const string _clientSecret = "?"; // Debes generarlo en Azure AD

        static async Task Main(string[] args)
        {
            var app = ConfidentialClientApplicationBuilder.Create(_clientId)
                .WithClientSecret(_clientSecret)
                .WithAuthority($"https://login.microsoftonline.com/{_tenantId}")
                .Build();

            string[] scopes = { "https://graph.microsoft.com/.default" };

            try
            {
                var result = await app.AcquireTokenForClient(scopes).ExecuteAsync();
                Console.WriteLine($"Token:\n{result.AccessToken}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:\n{ex.Message}");
            }
        }
    }
}
