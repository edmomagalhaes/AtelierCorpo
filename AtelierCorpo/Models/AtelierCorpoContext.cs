using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtelierCorpo.Models
{
    public class AtelierCorpoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Anamnesis> Anamnesises { get; set; }
    }
}