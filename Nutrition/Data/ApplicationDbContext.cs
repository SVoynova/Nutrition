using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Nutrition.Models;

namespace Nutrition.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Nutrition.Models.Meal> Meal { get; set; }
        public DbSet<Nutrition.Models.Diary> Diary { get; set; }
        public DbSet<Nutrition.Models.User> User { get; set; }
    }
}
