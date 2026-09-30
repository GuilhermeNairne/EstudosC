using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Data;
using ProjetoFinanceiro.Services.Painel;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IPainelService, PainelService>();

var app = builder.Build();
app.MapOpenApi();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
