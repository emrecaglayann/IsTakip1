using IsTakip.Data.Abstract;
using IsTakip.Data.Concrete;
using IsTakip.Service.Abstract;
using IsTakip.Service.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IAjandaRepository, AjandaRepository>();
builder.Services.AddScoped<IDepoEnvanterRepository, DepoEnvanterRepository>();
builder.Services.AddScoped<IDepoRafRepository, DepoRafRepository>();
builder.Services.AddScoped<IDepoRepository, DepoRepository>();
builder.Services.AddScoped<IDurusTipRepository, DurusTipRepository>();
builder.Services.AddScoped<IIsDosyaRepository, IsDosyaRepository>();
builder.Services.AddScoped<IIsRepository, IsRepository>();
builder.Services.AddScoped<IKalinlikIdRepository, KalinlikIdRepository>();
builder.Services.AddScoped<IKullaniciRepository, KullaniciRepository>();
builder.Services.AddScoped<IMailParametreleriRepository, MailParametreleriRepository>();
builder.Services.AddScoped<IMalzemeTipRepository, MalzemeTipRepository>();
builder.Services.AddScoped<IMusteriKisitlamaRepository, MusteriKisitlamaRepository>();
builder.Services.AddScoped<IMusteriRepository, MusteriRepository>();
builder.Services.AddScoped<IMusteriSinifRepository, MusteriSinifRepository>();
builder.Services.AddScoped<IMusteriTemsilcisiRepository, MusteriTemsilcisiRepository>();
builder.Services.AddScoped<ITedarikciRepository, TedarikciRepository>();
builder.Services.AddScoped<IUretimDurusRepository, UretimDurusRepository>();
builder.Services.AddScoped<IUretimEmriRepository, UretimEmriRepository>();


builder.Services.AddScoped<IAjandaService, AjandaService>();
builder.Services.AddScoped<IDepoEnvanterService, DepoEnvanterService>();
builder.Services.AddScoped<IDepoRafService, DepoRafService>();
builder.Services.AddScoped<IDepoService, DepoService>();
builder.Services.AddScoped<IDurusTipService, DurusTipService>();
builder.Services.AddScoped<IIsDosyaService, IsDosyaService>();
builder.Services.AddScoped<IIsService, IsService>();
builder.Services.AddScoped<IKalinlikIdService, KalinlikIdService>();
builder.Services.AddScoped<IKullaniciService, KullaniciService>();
builder.Services.AddScoped<IMailParametreleriService, MailParametreleriService>();
builder.Services.AddScoped<IMalzemeTipService, MalzemeTipService>();
builder.Services.AddScoped<IMusteriKisitlamaService, MusteriKisitlamaService>();
builder.Services.AddScoped<IMusteriService, MusteriService>();
builder.Services.AddScoped<IMusteriSinifService, MusteriSinifService>();
builder.Services.AddScoped<IMusteriTemsilcisiService, MusteriTemsilcisiService>();
builder.Services.AddScoped<ITedarikciService, TedarikciService>();
builder.Services.AddScoped<IUretimDurusService, UretimDurusService>();
builder.Services.AddScoped<IUretimEmriService, UretimEmriService>();

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
