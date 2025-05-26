// using System;
// using System.IO;
// using System.Threading.Tasks;
// using Azure.Identity;
// using Azure.Storage.Blobs;

// class Program
// {
//     static async Task Main(string[] args)
//     {
//         // 1. URI del Blob en el Azure Storage Account
//         string blobUri = "https://almfcmazz.blob.core.windows.net/fcm/Lab.txt";

//         // 2. Crear un cliente para el blob utilizando DefaultAzureCredential
//         var blobClient = new BlobClient(new Uri(blobUri), new DefaultAzureCredential());

//         Console.WriteLine("Conectando al blob...");

//         try
//         {
//             // 3. Descargar el contenido del blob
//             var response = await blobClient.DownloadAsync();

//             // 4. Leer el contenido del blob
//             using (var streamReader = new StreamReader(response.Value.Content))
//             {
//                 string blobContent = await streamReader.ReadToEndAsync();
//                 Console.WriteLine("Contenido del blob:");
//                 Console.WriteLine(blobContent);
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error al leer el blob: {ex.Message}");
//         }
//     }
// }


//////////////////////////MIsmo Ejercicio con token
using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.Storage.Blobs;

class Program
{
    static async Task Main(string[] args)
    {
        // 1. URI del Blob en el Azure Storage Account
        string blobUri = "https://almfcmaz.blob.core.windows.net/fcm/Lab.txt";

        // 2. Crear un cliente para el blob utilizando DefaultAzureCredential
        var credential = new DefaultAzureCredential();
        var blobClient = new BlobClient(new Uri(blobUri), credential);

        // Obtener el token adquirido desde Entra ID
        try
        {
            Console.WriteLine("Obteniendo token desde Entra ID...");
            var token = await credential.GetTokenAsync(new TokenRequestContext(new[] { "https://storage.azure.com/" }));
            Console.WriteLine("Token adquirido:");
            Console.WriteLine(token.Token);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al adquirir el token: {ex.Message}");
            return;
        }

        // Descargar y mostrar el contenido del blob
        try
        {
            Console.WriteLine("\nConectando al blob...");
            var response = await blobClient.DownloadAsync();

            using (var streamReader = new StreamReader(response.Value.Content))
            {
                string blobContent = await streamReader.ReadToEndAsync();
                Console.WriteLine("\nContenido del blob:");
                Console.WriteLine(blobContent);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el blob: {ex.Message}");
        }
    }
}
