﻿using Microsoft.EntityFrameworkCore;
using ContactManager.Models;
using System.Collections.Generic;

namespace ContactManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }
}

