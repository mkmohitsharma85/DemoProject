using Microsoft.EntityFrameworkCore;
using Infrastructure.Model;
using BLL.IService;
using BLL.Service;
using DAL.IRepository;
using DAL.Repository;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

var connectionString = configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DemoDBContext>(options =>
{
    options.UseSqlServer(connectionString);
});

// Add services to the container.

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<DemoDBContext>();

    // Apply any pending migrations
    dbContext.Database.Migrate();
}
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
