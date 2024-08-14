using Microsoft.EntityFrameworkCore;
using talabat.reposatory.Data;

namespace talabat.APIs
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<storeContext>(options=>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });



            var app = builder.Build();
            #region updata database automatic


            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;//all services
            var LoggerFactory=services.GetRequiredService<ILoggerFactory>();
            try
            {
               
                var dbcontext = services.GetRequiredService<storeContext>();//select services
                await dbcontext.Database.MigrateAsync();//update-database outomatic
                 await  StoreContextSeed.SeedAsync(dbcontext);
            }
            catch (Exception ex)
            {
                var Logger = LoggerFactory.CreateLogger<Program>();
                Logger.LogError(ex, "An error occured During doing migration ");//to print error message in console
            }
            #endregion

          

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}