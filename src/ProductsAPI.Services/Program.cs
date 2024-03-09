using MediatR;
using ProductsAPI.Application.Interfaces.Services;
using ProductsAPI.Application.Services;
using ProductsAPI.Infra.IoC.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServerConfig(builder.Configuration);

#region Injeções de dependência

builder.Services.AddTransient<IProductsAppService, ProductsAppService>();
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();