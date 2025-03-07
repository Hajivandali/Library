using Domain.Entitie;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // رشته اتصال را به صورت دستی وارد می‌کنید.
                optionsBuilder.UseNpgsql("Server=localhost;Database=LibraryDb;User Id=postgres;Password=qazwsx;");
            }
        }
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تنظیم رابطه بین Book و User
            modelBuilder.Entity<Book>()
                .HasOne(b => b.User) // هر کتاب متعلق به یک کاربر است
                .WithMany(u => u.Books) // هر کاربر می‌تواند چندین کتاب داشته باشد
                .HasForeignKey(b => b.UserId) // کلید خارجی در جدول Book
                .OnDelete(DeleteBehavior.Cascade); // حذف کتاب‌ها اگر کاربر حذف شود
        }
    }
}
