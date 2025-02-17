using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Day3_Lab.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using User = EntityFramework_Day3_Lab.Domain.Model.User;

namespace EntityFramework_Day3_Lab.Infrastructure.Context
{
    public class TaskManagerContext : DbContext
    {
        #region DB Sets

        public DbSet<User> Users { get; set; }

        public DbSet<TaskItem> TaskItems { get; set; }

        public DbSet<Category> categories { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TaskManager;integrated security=true; TrustServerCertificate=true;");
        }
    }
}
