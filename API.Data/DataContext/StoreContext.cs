﻿using API.Data.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace API.Data.DataContext
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }



        public DbSet<Product> Products { get; set; }
    }
}
