using Home_Away.BL;
using Home_Away.BL.Managers;
using Home_Away.BL.Managers.ChoiceManagers;
using Home_Away.BL.Managers.Images_Manager;
using Home_Away.BL.Managers.Property_Manager;
using Home_Away.BL.Managers.QuestionManagers;
using Home_Away.BL.Managers.User_Answer_Manager;
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
builder.Services.AddScoped<IPropertyManager, PropertyManager>();
//----------------
builder.Services.AddScoped<IReservationsRepo, ReservationsRepo>();
builder.Services.AddScoped<IReservationsManager, ReservationsManager>();

builder.Services.AddScoped<IReviewsRepo, ReviewsRepo>();
builder.Services.AddScoped<IReviewsManager, ReviewsManager>();
//----------------
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IUsersManagers, UsersManager>();
//----------------
builder.Services.AddScoped<IQuestionsRepo,QuestionsRepo>();
builder.Services.AddScoped<IQuestionManager, QuestionManager>();
//----------------
builder.Services.AddScoped<IChoicesRepo, ChoicesRepo>();
builder.Services.AddScoped<IChoiceManager, ChoiceManager>();
//----------------
builder.Services.AddScoped<IUser_AnswersRepo, User_AnswersRepo>();
builder.Services.AddScoped<IUser_Answer_Manager, User_Answer_Manager>();
//----------------
builder.Services.AddScoped<IReviewsRepo, ReviewsRepo>();
builder.Services.AddScoped<IReviewsManager, ReviewsManager>();

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
