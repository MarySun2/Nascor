using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

class Program
{
    static async Task Main(string[] args)
    {
        // 1. Construir configuración desde appsettings.json
        var configuration = new ConfigurationBuilder() //ConfigurationBuilder: Clase para construir una configuración. Permite agregar múltiples fuentes de configuración.
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Leer appsettings.json
            .Build();

        // 2. Leer la cadena de conexión desde appsettings.json
        string? connectionString = configuration["AppConfigurationConnectionString"];
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException("AppConfigurationConnectionString", "La cadena de conexión no está configurada en appsettings.json.");
        }

        // 3. Construir configuración desde Azure App Configuration y Conectar con Azure App Configuration
        /*Resultado de este paso 3: Construye un nuevo objeto IConfiguration llamado azureConfig, que ahora contiene configuraciones y Feature Flags desde Azure App Configuration.*/
        var azureConfig = new ConfigurationBuilder()
            .AddAzureAppConfiguration(options =>
            {
                options.Connect(connectionString)
                       .UseFeatureFlags(); // Habilitar manejo de Feature Flags
            })
            .Build();

        // 4. Configurar servicios y Feature Flags
        var services = new ServiceCollection();
        services.AddFeatureManagement(azureConfig); //Permite administrar Feature Flags en la aplicación

        var serviceProvider = services.BuildServiceProvider(); //BuildServiceProvider: Construye el proveedor de servicios para resolver dependencias.
        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>(); //Obtiene una instancia de IFeatureManager, que se utiliza para verificar el estado de los Feature Flags.

        // 5. Leer configuraciones y marcas de características
        string? welcomeMessage = azureConfig["WelcomeMessage"];
        if (string.IsNullOrEmpty(welcomeMessage))
        {
            Console.WriteLine("No se encontró el mensaje de bienvenida en App Configuration.");
        }
        else
        {
            Console.WriteLine(welcomeMessage);
        }

        // Verificar Feature Flags
        var featureName = "ShowAdditionalMessage";
        if (await featureManager.IsEnabledAsync(featureName))
        {
            Console.WriteLine("¡Funcionalidad adicional habilitada! Este mensaje es dinámico.");
        }
        else
        {
            Console.WriteLine("La funcionalidad adicional está deshabilitada.");
        }
    }
}
