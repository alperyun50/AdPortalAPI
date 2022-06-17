using AdPortalAPI.DataModels;
using AdPortalAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StudentAdminContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("StudentAdminPortalDb")));

// choose repository
builder.Services.AddScoped<IStudentRepository, SqlStudentRepository>();

// for cors adjusment
builder.Services.AddCors((options) =>
{
    options.AddPolicy("angularApplication", (builder) =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .WithMethods("GET", "POST", "PUT", "DELETE")
        .WithExposedHeaders("*");
    });
});

// added for automapper (Program == Startup for lower dotnet series - exp. dotnet 5)
builder.Services.AddAutoMapper(typeof(Program).Assembly);
 


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

// for usage of cors
app.UseCors("angularApplication");

app.UseAuthorization();

app.MapControllers();

app.Run();
