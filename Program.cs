using UserManagementAPI.Middleware;
using UserManagementAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicio en memoria
builder.Services.AddSingleton<UserService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseErrorHandling();
app.UseTokenAuthentication();
app.UseRequestResponseLogging();

// Middleware se configurará después
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
