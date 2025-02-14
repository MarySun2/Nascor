using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;

class Program
{
    // 🔹 Reemplaza con tu cadena de conexión y el nombre de la cola
    static string connectionString = "CONECTION_STRING";
    static string queueName = "MiCola";

    static async Task Main(string[] args)
    {
        Console.WriteLine("Esperando mensajes de la cola...");
        await ReceiveMessagesAsync();
    }

    static async Task ReceiveMessagesAsync()
    {
        // 🟢 Crear cliente y receptor
        await using var client = new ServiceBusClient(connectionString);
        ServiceBusReceiver receiver = client.CreateReceiver(queueName);

        while (true) // Bucle infinito para recibir mensajes continuamente
        {
            // 🟢 Intentar recibir un mensaje
            ServiceBusReceivedMessage message = await receiver.ReceiveMessageAsync(TimeSpan.FromSeconds(10));

            if (message != null)
            {
                Console.WriteLine($"📩 Mensaje recibido: {message.Body.ToString()}");

                // 🔹 Confirmar que el mensaje se ha procesado correctamente
                await receiver.CompleteMessageAsync(message);
            }
            else
            {
                Console.WriteLine("⚠️ No hay mensajes en la cola.");
                await Task.Delay(3000); // Espera antes de volver a intentar
            }
        }
    }
}

