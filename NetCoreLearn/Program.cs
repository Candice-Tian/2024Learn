//add Log file
Log.Logger = new LoggerConfiguration()
       .MinimumLevel.Debug()
       .WriteTo.Console()
       .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
       .CreateLogger();

Log.Information("This is the program of NetCore learning");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add DB
builder.Services.AddSqlite<PizzaContext>("Data Source=ContosoPizza.db");
builder.Services.AddSqlite<PromotionsContext>("Data Source=Promotions.db");
builder.Services.AddSqlite<BooksContext>("Data Source=Books.db");

builder.Services.AddScoped<PizzaService>();

//test adding multiple services
TestForMultipleImplementServices.Test(builder);

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

app.CreateDbIfNotExists();

app.Run();
