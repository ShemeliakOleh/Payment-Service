using Microsoft.EntityFrameworkCore;
using Payment_Service.Data;
using Payment_Service.Data.Repository;
using Payment_Service.Data.RepositoryImpl;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddTransient<DataManager>();

builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ITransactionHistoryRepository, TransactionHistoryRepository>();
builder.Services.AddTransient<ITransactionRepository, TransactionRepository>();



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
