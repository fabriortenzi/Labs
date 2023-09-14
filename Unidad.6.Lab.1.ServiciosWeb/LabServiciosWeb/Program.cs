using LabServiciosWeb;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UniversidadContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.MapGet("/alumnos", async (UniversidadContext context) =>
    await context.Alumnos.ToListAsync());

app.MapGet("/alumnos/{id}", async (int id, UniversidadContext context) =>
    await context.Alumnos.FindAsync(id) is Alumno alumno
        ? Results.Ok(alumno)
        : Results.NotFound());

app.MapPost("/alumnos", async (Alumno alumno, UniversidadContext context) =>
{
    context.Alumnos.Add(alumno);
    await context.SaveChangesAsync();

    return Results.Created($"/alumnos/{alumno.Id}", alumno);
});

app.MapPut("/alumnos", async (Alumno alumno, UniversidadContext context) =>
{
    var alumnoAModificar = await context.Alumnos.FindAsync(alumno.Id);

    if (alumnoAModificar == null)
    {
        return Results.NotFound();
    }
    else
    {
        context.Entry(alumnoAModificar).CurrentValues.SetValues(alumno);
        await context.SaveChangesAsync();
        return Results.NoContent();
    }
});

app.MapDelete("/alumnos/{id}", async(int id, UniversidadContext context) =>
{
    var alumnoABorrar = await context.Alumnos.FindAsync(id);
    
    if (alumnoABorrar != null)
    {
        context.Alumnos.Remove(alumnoABorrar);
        await context.SaveChangesAsync();
        return Results.NoContent();
    }
    else
    {
        return Results.NotFound();
    }
});


app.Run();
