//  para crear el proyecto 
//dotnet new console --framework net8.0 --name cosmosfcm --output .

//Instalar paquetes necesarios 
//dotnet add package Microsoft.Azure.Cosmos --version 3.28.0

// proyecto en cosmo Db PRIMER EJEMPLO

// using System;
// using System.Threading.Tasks;
// using Microsoft.Azure.Cosmos;

// namespace CosmosDbExample
// {
//     class Program
//     {
//         private static readonly string EndpointUri = "";
//         private static readonly string PrimaryKey = "";
//         private static CosmosClient cosmosClient = null!;
//         private static Database database = null!;
//         private static Container container = null!;
//         private static readonly string databaseId = "bdcosmo";
//         private static readonly string containerId = "productos";

//         static async Task Main(string[] args)
//         {
//             try
//             {
//                 // Inicializar el cliente de Cosmos DB.
//                 cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
                
//                 // Crear la base de datos y el contenedor.
//                 await CreateDatabaseAsync();
//                 await CreateContainerAsync();

//                 // Crear un documento.
//                 await AddItemsToContainerAsync();
//             }
//             catch (CosmosException ex)
//             {
//                 Console.WriteLine($"Cosmos DB Error: {ex.Message}");
//             }
//             finally
//             {
//                 if (cosmosClient != null)
//                 {
//                     cosmosClient.Dispose();
//                 }
//             }
//         }

//         private static async Task CreateDatabaseAsync()
//         {
//             // Crear una nueva base de datos si no existe.
//             database = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
//             Console.WriteLine($"Base de datos '{database.Id}' creada.");
//         }

//         private static async Task CreateContainerAsync()
//         {
//             // Crear un nuevo contenedor en la base de datos si no existe.
//             container = await database.CreateContainerIfNotExistsAsync(containerId, "/id");
//             Console.WriteLine($"Container '{container.Id}' creado.");
//         }

//         private static async Task AddItemsToContainerAsync()
//         {
//             // Crear un documento.
//             var item = new
//             {
//                 id = Guid.NewGuid().ToString(),
//                 nomprod = "techo"
//             };

//             // Insertar el documento en el contenedor.
//             var response = await container.CreateItemAsync(item, new PartitionKey(item.id));
//             Console.WriteLine($"Item creado con id: {response.Resource.id}");
//         }
//     }
// }


// PROYECTO 2 EN JSON
using System;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json.Linq;

    class Program
    {
        private static readonly string endpointUri = "";
        private static readonly string primaryKey = "";
        private static CosmosClient cosmosClient = null!;
        private static Database database = null!;
        private static Container container = null!;
        private static readonly string databaseId = "bdcosmo";
        private static readonly string containerId = "productos";



static async Task Main(string[] args)
    {
        // Inicializa el cliente de Cosmos DB
        cosmosClient = new CosmosClient(endpointUri, primaryKey);
        
        // Obtén una referencia a la base de datos
        database = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
        
        // Obtén una referencia al contenedor
        container = await database.CreateContainerIfNotExistsAsync(containerId, "/id");

        // Ruta del archivo JSON
        string jsonFilePath = "data.json";
        
        // Carga y procesa el archivo JSON
        await LoadJsonAsync(jsonFilePath);
        
        Console.WriteLine("Carga de JSON completada.");
    }

    private static async Task LoadJsonAsync(string filePath)
    {
        // Lee el contenido del archivo JSON
        string jsonContent = await File.ReadAllTextAsync(filePath);
        
        // Parsea el contenido JSON a un array de objetos
        JArray jsonArray = JArray.Parse(jsonContent);
        
        // Itera sobre cada objeto en el array
        foreach (JObject jsonObject in jsonArray)
        {
            // Inserta cada objeto en el contenedor de Cosmos DB
            await container.CreateItemAsync(jsonObject, new PartitionKey(jsonObject["id"].ToString()));
            Console.WriteLine($"Insertado objeto con id: {jsonObject["id"]}");
        }
    }
}

