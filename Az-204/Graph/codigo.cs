using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    private static async Task Main(string[] args)
    {
        var clientId = "{CLIENT_ID}";
        var tenantId = "{TENANT_ID}";
        var clientSecret = "{CLIENT_SECRET}";

        IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
            .Create(clientId)
            .WithTenantId(tenantId)
            .WithClientSecret(clientSecret)
            .Build();

        GraphServiceClient graphClient = new GraphServiceClient(new ClientCredentialProvider(confidentialClientApplication));
        var users = await graphClient.Users.Request().GetAsync();
        
        foreach (var user in users)
        {
            Console.WriteLine(user.DisplayName);
        }
    }
}