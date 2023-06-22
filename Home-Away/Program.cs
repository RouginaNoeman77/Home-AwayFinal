using Home_Away.BL;
using Home_Away.BL.Dtos;
using Home_Away.BL.Managers;
using Home_Away.BL.Managers.Admin_Manager;
using Home_Away.BL.Managers.ChoiceManagers;
using Home_Away.BL.Managers.Images_Manager;
using Home_Away.BL.Managers.Property_Manager;
using Home_Away.BL.Managers.QuestionManagers;
using Home_Away.BL.Managers.User_Answer_Manager;
using Home_Away.DAL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.FileProviders.Physical;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

});



//---------------
builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HomeAway")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});
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

builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<IAdminManager, AdminManager>();


#region Identity
builder.Services.AddIdentity<IdentityUser,IdentityRole>(option=>
    {
        option.Password.RequireUppercase = false;
        option.Password.RequireDigit= true;
        option.Password.RequireNonAlphanumeric = true;
        option.Password.RequiredLength = 8;
        option.User.RequireUniqueEmail= true;
        option.Lockout.MaxFailedAccessAttempts = 3;

    })
    .AddEntityFrameworkStores<UserContext> ();
#endregion
#region Authentication
builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = "default";
    option.DefaultChallengeScheme = "default";

}).AddJwtBearer("default", option =>
{
    string keyString = builder.Configuration.GetValue<string>("SecretKey") ?? string.Empty;
    var keyInBytes = Encoding.ASCII.GetBytes(keyString);
    var key = new SymmetricSecurityKey(keyInBytes);

    option.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = key,
        ValidateIssuer = false,
        ValidateAudience = false,

    };

});
#endregion
#region Authorization
builder.Services.AddAuthorization(option =>
{
    option.AddPolicy("Admin", policy => policy
    .RequireClaim(ClaimTypes.Role, "Admin")
    .RequireClaim(ClaimTypes.NameIdentifier));

	option.AddPolicy("User", policy => policy
	.RequireClaim(ClaimTypes.Role, "User")
	.RequireClaim(ClaimTypes.NameIdentifier));
});
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//-----------------------
app.UseCors(MyAllowSpecificOrigins);
//-----------------------
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider($"{Environment.CurrentDirectory}\\Images\\")
}); 

    
var staticFilePath = Path.Combine(Environment.CurrentDirectory, "Images");
var RequestPath = "/Images";
//-----------------------
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
