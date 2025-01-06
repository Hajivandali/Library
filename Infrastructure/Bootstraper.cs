using Infrastructure.DataContext;
using Infrastructure.Repositories.bookRepositories;
using Infrastructure.Repositories.userRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Bootstraper
    {
        public static void Config(IServiceCollection services, string connectionString)
        {
            // ثبت وابستگی‌ها
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            // تنظیم کانفیگ دیتابیس
            services.AddDbContext<LibraryContext>(options => options.UseNpgsql(connectionString));
        }
    }
}
