using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API
{

  class ApplicationContext : DbContext
  {
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    public DbSet<Person> Person { get; set; }
    public DbSet<Intrest> Intrest { get; set; }
    public DbSet<Link> Link { get; set; }
  }
}