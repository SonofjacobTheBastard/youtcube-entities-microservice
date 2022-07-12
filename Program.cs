using YoutCubeRelationalDatabaseConnection.Interfaces;
using YoutCubeEntitiesMicroservice.Extensions;
using YoutCubeEntitiesMicroservice.Models;
using YoutCubeEntitiesMicroservice.Repositories;
using YoutCubeEntitiesMicroservice.DevelopmentTesting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IRepository<Video>, VideoRepository>();
builder.Services.AddScoped<IRepository<Comment>, CommentRepository>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapVideosEndpoints();
app.MapCommentsEndPoint();

app.Run();