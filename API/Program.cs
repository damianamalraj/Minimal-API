using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);
      string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
      builder.Services.AddDbContext<ApplicationContext>(opt => opt.UseSqlServer(connectionString));
      var app = builder.Build();

      app.MapGet("/", () => "Hello World!");

      app.Run();
    }
  }
}
