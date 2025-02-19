using System;
using StackExchange.Redis;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string connectionString = "tu-cadena-de-conexion-redis"; // Reemplaza con tu conexión de Azure

        ConnectionMultiplexer redis = await ConnectionMultiplexer.ConnectAsync(connectionString);
        IDatabase db = redis.GetDatabase();

        string key = "mensaje";
        string value = "¡Hola desde Azure Redis!";

        // Guardar en Redis
        await db.StringSetAsync(key, value);

        // Recuperar desde Redis
        string result = await db.StringGetAsync(key);
        Console.WriteLine($"Valor almacenado en Redis: {result}");
    }
}

