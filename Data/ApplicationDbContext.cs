﻿using Microsoft.EntityFrameworkCore;

namespace UserService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Models.User> Users { get; set; }
    }
}
