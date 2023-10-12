using Microsoft.EntityFrameworkCore;
using TPH_TPT_EF_Core_Mapping.Model;
using Application.Extensions;
using System.Reflection;
using Application.IServices;
using Application.Services;

var builder = WebApplication.CreateBuilder(args);




////////////////////////
var executingAssm = Assembly.GetExecutingAssembly();
var dir = Path.GetDirectoryName(executingAssm.Location);
Assembly.LoadFrom(Path.Combine(dir, "BaseProjectName.Application.dll"));
builder.Services.RegisterServices(builder.Environment.EnvironmentName, "BaseProjectName");
////////////////////////////
///







builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EFCoreMappingContext>(x =>
{
    x.UseSqlServer("Data source=.; Initial Catalog=EFCoreMapping;Integrated Security=true;TrustServerCertificate=True;");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
