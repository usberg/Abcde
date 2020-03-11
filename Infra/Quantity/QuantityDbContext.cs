﻿using System;
using System.Collections.Generic;
using System.Text;
using Data.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Infra.Quantity
{
    public class QuantityDbContext: DbContext
    {
        public QuantityDbContext(DbContextOptions<QuantityDbContext> options)
            : base(options)
        {
        }
        public DbSet<MeasureData> Measures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<MeasureData>().ToTable(nameof(Measures));
        }

    }
}
