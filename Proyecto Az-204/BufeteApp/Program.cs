var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simulación de base de datos
var cases = new List<dynamic>
{
    new { CaseId = 1, Client = "John Doe", Status = "Open" }
};

app.MapGet("/cases", () => cases);

app.MapPost("/cases", (dynamic newCase) =>
{
    int caseId = cases.Count + 1;
    newCase.CaseId = caseId;
    cases.Add(newCase);
    return Results.Created($"/cases/{caseId}", newCase);
});

app.Run();