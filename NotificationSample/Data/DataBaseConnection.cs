using Microsoft.EntityFrameworkCore;
using NotificationSample.Models;

namespace NotificationSample.Data
{
    public class DataBaseConnection : DbContext
    {
        public DataBaseConnection(DbContextOptions<DataBaseConnection> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notification { get; set; }
    }
}
