using AP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AP.Backend.Models
{
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<AP.Common.Models.Product> Products { get; set; }
    }
}