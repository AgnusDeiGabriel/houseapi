using HouseApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=houses.db"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("allowall",
        policy => policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("allowall");
app.UseDefaultFiles();
app.UseStaticFiles();



app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();