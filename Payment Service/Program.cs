using Microsoft.EntityFrameworkCore;
using Payment_Service.Data;
using Payment_Service.Data.Repository;
using Payment_Service.Data.RepositoryImpl;
using Payment_Service.Services;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddTransient<DataManager>();

builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ITransactionHistoryRepository, TransactionHistoryRepository>();
builder.Services.AddTransient<ITransactionRepository, TransactionRepository>();
builder.Services.AddTransient<CustomerService>();
builder.Services.AddTransient<TransactionHistoryService>();
builder.Services.AddTransient<TransactionPowerAppsService>();




builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    
//}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
