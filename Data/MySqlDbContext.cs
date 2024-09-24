using Microsoft.EntityFrameworkCore;

namespace levysDatabase.Data
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        public DbSet<Room> Rooms { get; set; }
    }
    public class User 
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public int RoomCode { get; set; }
        public bool Accessible { get; set; }
    }

}
