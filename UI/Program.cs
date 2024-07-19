using BLL.DependencyServices;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddIdentityService();
builder.Services.AddDbContext<MyContext>(opt=>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));

//builder.Services.AddDbContextService();



builder.Services.AddRepositoryManagerService();

//Session 

builder.Services.AddDistributedMemoryCache();



WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();