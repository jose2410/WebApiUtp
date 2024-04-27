using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiUtp.Data;
using WebApiUtp.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
// Configuración de la conexión a la base de datos PostgreSQL
builder.Services.AddDbContext<RestauranteDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
//"Host=cb889jp6h2eccm.cluster-czrs8kj4isg7.us-east-1.rds.amazonaws.com;Port=5432;Database=d22r9ft2ao1ok9;Username=u1q98n52nvp0vo;Password=pa79714338d08e19e8eaed57bb92f8280798425e6ef01923ecbbbbb2216d89aa4;"
//options.UseNpgsql("Host=cb889jp6h2eccm.cluster-czrs8kj4isg7.us-east-1.rds.amazonaws.com;Port=5432;Database=d22r9ft2ao1ok9;Username=u1q98n52nvp0vo;Password=pa79714338d08e19e8eaed57bb92f8280798425e6ef01923ecbbbbb2216d89aa4;"));
// Agregar repositorio de usuarios
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IRestauranteRepository, RestauranteRepository>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
//app.UseSwaggerUI();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    //app.UseSwaggerUI();
//    app.UseSwaggerUI(c => {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
//    });
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
