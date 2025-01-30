using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simulación de base de datos
var cases = new List<dynamic>
{
    new { CaseId = 1, Client = "John Doe", Status = "Open" }
};

// Endpoint para obtener todos los casos legales
app.MapGet("/cases", () => Results.Ok(cases));

// Endpoint para crear un nuevo caso legal
app.MapPost("/cases", (dynamic newCase) =>
{
    int caseId = cases.Count + 1;
    newCase.CaseId = caseId;
    cases.Add(newCase);
    return Results.Created($"/cases/{caseId}", newCase);
});

// Endpoint para obtener un caso por ID
app.MapGet("/cases/{id:int}", (int id) =>
{
    var caseItem = cases.FirstOrDefault(c => c.CaseId == id);
    return caseItem is not null ? Results.Ok(caseItem) : Results.NotFound($"Case with ID {id} not found.");
});

// Endpoint para actualizar un caso
app.MapPut("/cases/{id:int}", (int id, dynamic updatedCase) =>
{
    var caseItem = cases.FirstOrDefault(c => c.CaseId == id);
    if (caseItem is not null)
    {
        caseItem.Client = updatedCase.Client ?? caseItem.Client;
        caseItem.Status = updatedCase.Status ?? caseItem.Status;
        return Results.Ok(caseItem);
    }
    return Results.NotFound($"Case with ID {id} not found.");
});

// Endpoint para eliminar un caso
app.MapDelete("/cases/{id:int}", (int id) =>
{
    var caseItem = cases.FirstOrDefault(c => c.CaseId == id);
    if (caseItem is not null)
    {
        cases.Remove(caseItem);
        return Results.Ok($"Case with ID {id} deleted.");
    }
    return Results.NotFound($"Case with ID {id} not found.");
});

app.Run();