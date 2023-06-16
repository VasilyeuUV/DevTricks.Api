using Autofac;
using Autofac.Extensions.DependencyInjection;
using DevTricks.Api.Security;

namespace DevTricks.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var p = new Microsoft.AspNetCore.Identity.PasswordHasher<object>().HashPassword(1, "strong_password");
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // - Идентификация пользователя 
            builder.Services
                .AddIdentityCore<UserModel>()   // - класс UserModel выступает в качестве идентификатора Пользователя (система идентификации будет сконфигурирована под указанный тип)
                .AddUserStore<UserStore>()      // - регистрация Хранилища Credentional Пользователя
                ;

            // - заменяем встроенную фабрику ServiceProvider (резолвер) 
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            // - регистрация Регистрационного модуля
            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
                containerBuilder.RegisterModule<RegistrationModule>()
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapControllers();

            app.Run();
        }
    }
}