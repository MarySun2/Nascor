using System;
using System.Threading.Tasks;
//MSAL.NET, biblioteca de autenticación de Microsoft
using Microsoft.Identity.Client;

namespace az204_auth
{
    class Program
    {

        //Constantes para configuracion _clientId: ID de la aplicacion registrada
        private const string _clientId = "c5a04f0e-fd87-4fd1-8bbb-9ac4731b1061";
        //Constantes para configuracion _tenantId: ID del Tenant
        private const string _tenantId = "e09e2537-0074-4318-8356-e148b9fbcd7b";

        public static async Task Main(string[] args)
        {

            /* Inicia la construcción de una aplicación cliente pública, usamos PublicClientApplicationBuilder, clase en la biblioteca Microsoft.Identity.Client (MSAL)
            que proporciona métodos para configurar y construir una instancia de PublicClientApplication */
            var app = PublicClientApplicationBuilder

            //Metodo .Create: Construir una instancia de la aplicacion con base en el ID de la aplicacion registrada
                .Create(_clientId)

            /* Metodo .WithAuthority: Configura la autoridad para la autenticación. AzureCloudInstance.AzurePublic: Indica que se está utilizando la instancia pública de Azure
            _tenantId: Es el identificador del inquilino (tenant) en Entra, que especifica en qué directorio de Entra se encuentra registrada la aplicación*/            
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)

            /*Metodo .WithRedirectUri: Establece el URI de redirección que se utilizará para el flujo de autenticación interactiva. 
            Este es el URI donde Entra ID redirigirá la respuesta de autenticación. */
                .WithRedirectUri("http://localhost")

            // .Build(): Construye y devuelve una instancia de PublicClientApplication con la configuración proporcionada.
                .Build(); 
            
            // string[] scopes: Usamos una matriz de cadenas para especificar los permisos solicitados, user.read leer información del usuario, para poder realizar el proceso de autenticación
            string[] scopes = { "user.read" };
            
            /*Declaramos una variable tipo AuthenticationResult, la cual es una clase de MSAL la cual representa el resultado de una solicitud de token.
            Ahora AcquireTokenInteractive es un metodo que abre una ventana de autenticación en la que el usuario puede ingresar sus credenciales. */
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token:\t{result.AccessToken}");
        }
    }
}
