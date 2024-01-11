using BookStore2023.BL.Interfaces;
using BookStore2023.BL.Services;
using BookStore2023.DL.Interfaces;
using BookStore2023.DL.Repositories;

namespace BookStore2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IAutorRepository,AutorRepository>();
            builder.Services.AddSingleton<IAutorService, AutorService>();

            builder.Services.AddSingleton<IBookRepository, BookRepository>();
            builder.Services.AddSingleton<IBookService, BookService>();
            builder.Services
                .AddSingleton<ILibraryService, LibraryService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
