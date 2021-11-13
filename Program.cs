using Azure.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.AddAzureKeyVault(new Uri("VaultUri"), new DefaultAzureCredential());

builder.Services
    .AddDbContext<NZFM.Common.Web.TestDbContext>(item => item.UseSqlServer("SQL-Connection"));
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();
