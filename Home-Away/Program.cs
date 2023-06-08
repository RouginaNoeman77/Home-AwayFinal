using Home_Away.BL;
using Home_Away.BL.Managers.Images_Manager;
using Home_Away.BL.Managers.Property_Manager;
using Home_Away.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//---------------
builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HomeAway")));
//----------------
builder.Services.AddScoped<IImagesRepo, ImagesRepo>();
builder.Services.AddScoped<IImagesManager , ImagesManager>();
//----------------
builder.Services.AddScoped<IPropertyRepo, PropertyRepo>();


builder.Services.AddScoped<IReservationsRepo, ReservationsRepo>();
builder.Services.AddScoped<IReservationsManager, ReservationsManager>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
