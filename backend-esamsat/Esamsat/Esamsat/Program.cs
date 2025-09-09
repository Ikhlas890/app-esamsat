using Esamsat.Db;
using Esamsat.Models;
using Esamsat.Repositories.Implementations;
using Esamsat.Repositories.Interfaces;
using Esamsat.Services.Implementations;
using Esamsat.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Tambahkan DbContext (sesuaikan connection string di appsettings.json)
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Tambahkan Repositories
builder.Services.AddSingleton<EmailService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAppgroupuserRepository, AppgroupuserRepository>();
builder.Services.AddScoped<IMasterrekdRepository, MasterrekdRepository>();
builder.Services.AddScoped<IMasterreknrcRepository, MasterreknrcRepository>();
builder.Services.AddScoped<IMasteruptRepository, MasteruptRepository>();
builder.Services.AddScoped<IMasterpegawaiRepository, MasterpegawaiRepository>();
builder.Services.AddScoped<IMasterbendaharaRepository, MasterbendaharaRepository>();
builder.Services.AddScoped<IMasterbankRepository, MasterbankRepository>();
builder.Services.AddScoped<IJnsstrurekRepository, JnsstrurekRepository>();
builder.Services.AddScoped<IMasterkabkotumRepository, MasterkabkotumRepository>();
builder.Services.AddScoped<IMasterktpRepository, MasterktpRepository>();
builder.Services.AddScoped<IJnspajakRepository, JnspajakRepository>();

// Tambahkan session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Tambahkan controller
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
});


// Tambahkan swagger (opsional)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
         builder =>
         {
             builder
                 .WithOrigins("http://localhost:4200", "http://localhost:5174")
                 .AllowAnyHeader()
                 .AllowAnyMethod()
                 .AllowCredentials(); // Mengizinkan kredensial
         });
});

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();
app.UseRouting();

app.UseSession(); // wajib sebelum UseEndpoints
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
