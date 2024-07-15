using AdoptMyPetBackend.Pets.Application.Mapping;
using AdoptMyPetBackend.Pets.Application.Services;
using AdoptMyPetBackend.Pets.Domain.Repositories;
using AdoptMyPetBackend.Pets.Domain.Services;
using AdoptMyPetBackend.Pets.Infrasture.Repositories;
using AdoptMyPetBackend.Shared.Domain.Repositories;
using AdoptMyPetBackend.Shared.Persistence.Context;
using AdoptMyPetBackend.Shared.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting(options=>options.LowercaseUrls = true);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IPetTypeRepository, PetTypeRepository>();
builder.Services.AddScoped<IPetTypeService, PetTypeService>();
builder.Services.AddScoped<IPetRepository, PetRepository>();
builder.Services.AddScoped<IPetService, PetService>();

builder.Services.AddAutoMapper(typeof(MapperProfile));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
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
