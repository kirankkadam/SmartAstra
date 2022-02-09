using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SmartAstra.Entities;

namespace SmartAstra.Data
{
    public class AstraDbContext : DbContext
    {
        public DbSet<Entities.Campaign> Campaigns { get; set; }
        public DbSet<Entities.Company> Companies { get; set; }
        public DbSet<Entities.Configuration> Configurations { get; set; }
        public DbSet<Entities.Email> Emails { get; set; }
        public DbSet<Entities.Message> Messages { get; set; }
        public DbSet<Entities.Recepient> Recepients { get; set; }
        public DbSet<RecepientList> RecepientLists { get; set; }
        public DbSet<Entities.Schedule> Schedules { get; set; }
        public DbSet<Entities.SubscriptionPlan> Subscriptions { get; set; }
        public DbSet<SMS> SMSes { get; set; }
        public DbSet<Entities.User> Users { get; set; }


        public override int SaveChanges()
        {

            return base.SaveChanges();
        }
    }
}
