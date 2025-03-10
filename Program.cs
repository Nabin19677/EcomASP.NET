using ecom_web_api.Extensions;
using ecom_web_api.Middlewares;
using ecom_web_api.Models;
using Microsoft.AspNetCore.Mvc;
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

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        // Handle Data Annotations Validations
        options.InvalidModelStateResponseFactory = context =>
        {
            var apiResponse = ApiResponse<Dictionary<string, string[]>>.FromModelState(context.ModelState);
            return new BadRequestObjectResult(apiResponse);
        };
    });

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

// Global Exception Handling Middleware
app.UseMiddleware<GlobalExceptionMiddleware>();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
