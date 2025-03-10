using ecom_web_api.extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Retreive psqlconnection string
var psqlConnectionString = builder.Configuration.GetConnectionString("psqlconnectionstring");

// Add dbcontext
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(psqlConnectionString));

// Inject Application Services
builder.Services.AddApplicationServices();

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
