using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

class Program
{
    static async Task Main(string[] args)
    {
        string keyVaultName = "EjemploKey"; // Nombre de tu Key Vault
        string kvUri = $"https://{keyVaultName}.vault.azure.net/";

        // Autenticación con la identidad del usuario en Azure
        var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());

        // Obtener el secreto "secreto"
        KeyVaultSecret secret = await client.GetSecretAsync("secreto");


        // Mostrar el valor del secreto
        Console.WriteLine($"El secreto es: {secret.Value}");
    }
}

