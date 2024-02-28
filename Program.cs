using Microsoft.EntityFrameworkCore;
using ServiceOffre;
using ServiceOffre.DAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//configure et ajoute un contexte de base de donn�es � l'application .NET, en sp�cifiant que celui-ci utilise SQL Server comme moteur de base de donn�es et en fournissant les d�tails de connexion n�cessaires � partir des fichiers de configuration de l'application
builder.Services.AddDbContext<ServiceOffreDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//registration of the repository service
builder.Services.AddScoped<OffreRepository>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
