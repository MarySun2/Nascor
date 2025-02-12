using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

public static class Productos
{
    private static List<Producto> ProductosList = new List<Producto>
    {
        new Producto { Id = 1, Nombre = "Laptop", Precio = 1000 },
        new Producto { Id = 2, Nombre = "Mouse", Precio = 20 }
    };

    [FunctionName("GetProductos")]
    public static IActionResult RunGet(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "productos")] HttpRequest req,
        ILogger log)
    {
        return new OkObjectResult(ProductosList);
    }

    [FunctionName("PostProducto")]
    public static IActionResult RunPost(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "productos")] HttpRequest req,
        ILogger log)
    {
        string requestBody = new StreamReader(req.Body).ReadToEnd();
        var producto = JsonConvert.DeserializeObject<Producto>(requestBody);
        producto.Id = ProductosList.Count + 1;
        ProductosList.Add(producto);

        return new CreatedResult($"/api/productos/{producto.Id}", new { mensaje = "Producto agregado" });
    }
}

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}
