using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BackEndAPI.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BackEndAPIContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("BackEndAPIContext") ?? throw new InvalidOperationException("Connection string 'BackEndAPIContext' not found.")));

// Adiciona controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    // Define uma política chamada "FrontendPolicy" (você pode escolher o nome)
    options.AddPolicy(name: "FrontendPolicy",
         builder =>
         {
             // 1. Permite as origens específicas do seu frontend
             builder.WithOrigins("http://localhost:3000") //Se o front estiver em produção, adicionar ,"url_front_production"
                    // 2. Permite todos os métodos HTTP
                    .AllowAnyMethod()  
                    // 3. Permite todos os cabeçalhos
                    .AllowAnyHeader();
         });
});


var app = builder.Build();
app.UseCors("FrontendPolicy");

// Swagger no desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
