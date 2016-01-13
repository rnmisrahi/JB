using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Citizens_and_Cars.Models
{
    public class CarsDbContext:DbContext
    {
        DbSet<Citizen> Citizens { get; set; }
        DbSet<Car> Cars { get; set; }
    }
}