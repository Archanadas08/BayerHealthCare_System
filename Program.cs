using BayerHealthCare_System.MessageContracts;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Register MongoClient as a singleton
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));
builder.Services.AddSingleton<IMongoClient>(
    sp => new MongoClient(builder.Configuration.GetSection("MongoDbSettings:ConnectionString").Value));
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
