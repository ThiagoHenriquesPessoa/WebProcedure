using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProcedure.Models;

namespace WebProcedure.Data
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
