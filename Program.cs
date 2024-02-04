using Microsoft.EntityFrameworkCore;
using TheSaultyMonk.Minimal.Representation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

const string connectionString = "host=localhost;port=9999;database=db;username=user;password=password;";

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options
        .UseNpgsql(
            connectionString,
            o => o
                .MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
        )
        .UseSnakeCaseNamingConvention()
);
builder.Services.AddScoped<ApplicationDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();