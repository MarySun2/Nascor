using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

class Program
{
    static string connectionString = ""; // Reemplázala con tu cadena de conexión
    static string containerName = "mi-contenedor";
    static string filePath = "archivo.txt";
    static string downloadPath = "descargado.txt";

    static async Task Main()
    {
        try
        {
            Console.WriteLine("Iniciando el proceso...");

            // 1. Crear el contenedor
            Console.WriteLine("Paso 1: Creando contenedor...");
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);
            Console.WriteLine($"Contenedor '{containerName}' creado.");

            // 2. Crear un archivo de prueba si no existe
            if (!File.Exists(filePath))
            {
                await File.WriteAllTextAsync(filePath, "Este es un archivo de prueba para Azure Blob Storage.");
                Console.WriteLine($"Archivo '{filePath}' creado localmente.");
            }

            // 3. Subir el archivo al contenedor
            Console.WriteLine("Paso 2: Subiendo archivo a Blob Storage...");
            BlobClient blobClient = containerClient.GetBlobClient(Path.GetFileName(filePath));

            using FileStream uploadFileStream = File.OpenRead(filePath);
            await blobClient.UploadAsync(uploadFileStream, true);
            uploadFileStream.Close();
            Console.WriteLine($"Archivo '{filePath}' subido a Blob Storage.");

            // 4. Listar los archivos en el contenedor
            Console.WriteLine("Paso 3: Listando blobs en el contenedor...");
            await foreach (var blob in containerClient.GetBlobsAsync())
            {
                Console.WriteLine($"Blob encontrado: {blob.Name}");
            }

            // 5. Descargar el archivo desde Blob Storage
            Console.WriteLine("Paso 4: Descargando archivo desde Blob Storage...");
            BlobClient downloadBlobClient = containerClient.GetBlobClient(Path.GetFileName(filePath));

            BlobDownloadInfo download = await downloadBlobClient.DownloadAsync();
            using FileStream downloadFileStream = File.OpenWrite(downloadPath);
            await download.Content.CopyToAsync(downloadFileStream);
            downloadFileStream.Close();
            Console.WriteLine($"Archivo descargado como '{downloadPath}'.");

            // 6. Eliminar el contenedor (Opcional)
            Console.WriteLine("Paso 5: Eliminando contenedor...");
            await containerClient.DeleteAsync();
            Console.WriteLine($"Contenedor '{containerName}' eliminado.");

            Console.WriteLine("Proceso completado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
