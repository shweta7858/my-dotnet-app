using Mera_yani_shweta_ka_app.Data;
using Mera_yani_shweta_ka_app.Interface;
using Mera_yani_shweta_ka_app.ServiceImpl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
                       options.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));// connection string app setting me bana lo 

// Add services to the container.
builder.Services.AddScoped<ICustomerRepository, CustomerServiceImpl>();


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
