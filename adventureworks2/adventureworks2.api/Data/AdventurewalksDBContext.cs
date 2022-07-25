﻿using adventureworks2.api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace adventureworks2.api.Data
{
    public class AdventurewalksDBContext : DbContext
    {
        public AdventurewalksDBContext(DbContextOptions<AdventurewalksDBContext> options) : base(options)
        {

        }


        public DbSet<mPerson> Person { get; set; }
        public DbSet<mEmailAddress> EmailAddress { get; set; }
    }
}
