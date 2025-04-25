using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace MicrosoftGraphDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string clientId = "";
            string clientSecret = "";
            string tenantId = "";
            string userId = "";

            //Creamos una instancia de la aplicacion confidencial basados en el clientId
            var app = ConfidentialClientApplicationBuilder.Create(clientId)
                //Establecemos el secreto del cliente que se usa para autenticar la aplicacion
                .WithClientSecret(clientSecret)
                //Establecemos la autoridad que sera utilizada para adquirir los tokens
                .WithAuthority(new Uri($"https://login.microsoftonline.com/{tenantId}"))
                .Build();

            //la variable scope recibe "https://graph.microsoft.com/.default" como el alcance para solicitar un token de acceso
            var scopes = new string[] { "https://graph.microsoft.com/.default" };

            //Usamos le metodo de MSAL AcquireTokenForClient para obtener un token de acceso usando el ID del cliente, el secreto del cliente y el scope
            var result = await app.AcquireTokenForClient(scopes).ExecuteAsync();

            //Se crea una instancia de HttpClient parfa poder enviar solicitudes HTTP
            var httpClient = new HttpClient();

            /* Con la instancia HttpClient usamos propiedades disponibles de la misma, DefaultRequestHeaders la cual contiene los encabezados HTTP predeterminados
            y Authorization es un encabezado de DefaultRequestHeaders */

            /* AuthenticationHeaderValue es una clase que representa el valor del encabezado de autorización, esta clase tiene dos parámetros: el esquema de autenticación y el token de acceso.
            Bearer: Especifica el esquema de autenticación que se está utilizando, result.AccessToken: Es el token de acceso que se ha adquirido previamente 
            mediante la llamada a AcquireTokenForClient */
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result.AccessToken);

            //Realizamos una solicitud GET a la API de Microsoft Graph para obtener las propiedades del usuario que estamos especificando a traves de userId.
            var response = await httpClient.GetAsync($"https://graph.microsoft.com/v1.0/users/{userId}");

            if (response.IsSuccessStatusCode)
            {

                //Con el metodo de la clase HttpClient lea el contenido 
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}
