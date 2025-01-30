var builder = WebApplication.CreateBuilder(args);

// Agregar servicios necesarios
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Simulación de base de datos
var cases = new List<dynamic>
{
    new { CaseId = 1, Client = "John Doe", Status = "Open" }
};

// Endpoints de la API
app.MapGet("/cases", () => cases);

app.MapPost("/cases", (dynamic newCase) =>
{
    int caseId = cases.Count + 1;
    newCase.CaseId = caseId;
    cases.Add(newCase);
    return Results.Created($"/cases/{caseId}", newCase);
});

app.Run();
