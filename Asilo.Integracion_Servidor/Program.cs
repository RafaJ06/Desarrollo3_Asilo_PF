using Asilo.Core.Interfaces;
using Asilo.Integracion_Servidor.Repositories;

// Este namespace debe coincidir con el que tienen tus archivos .cs copiados
using Asilo.Integracion_Servidor.Repositories;

var builder = WebApplication.CreateBuilder(args);

// --- 1. CONFIGURACIÓN DE BASE DE DATOS ---
// Pon aquí tu cadena de conexión real (la misma que usabas antes)
string connectionString = "Server=.;Database=AsiloDB;Trusted_Connection=True;";

// --- 2. INYECCIÓN DE DEPENDENCIAS ---
// Aquí le decimos al servidor: "Cuando alguien pida IUsuarioRepository, dale el SqlUsuarioRepository"
builder.Services.AddScoped<IUsuarioRepository>(p => new SqlUsuarioRepository(connectionString));
builder.Services.AddScoped<IMovimientoRepository>(p => new SqlMovimientoRepository(connectionString));
builder.Services.AddScoped<ICuentaRepository>(p => new SqlCuentaRepository(connectionString));
builder.Services.AddScoped<IResidenteRepository>(p => new SqlResidenteRepository(connectionString));
builder.Services.AddScoped<IAuditRepository>(p => new SqlAuditRepository(connectionString));

// Habilitar los controladores (la API)
builder.Services.AddControllers();

// Configuración de Swagger (Para probar visualmente)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- 3. CONFIGURACIÓN DEL ENTORNO ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Esto te mostrará la web azul para probar
}

app.UseAuthorization();
app.MapControllers();

// --- 4. ARRANCAR EL SERVIDOR ---
app.Run();