using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace demo
{
    internal static class Program
    {

        static IServiceProvider serviceProvider;
        internal static ApplicationContext context;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            /*serviceProvider = CreateProvider();
            
            context = serviceProvider.GetRequiredService<ApplicationContext>();

            ApplicationConfiguration.Initialize();

            var login = serviceProvider.GetRequiredService<MainForm>();
            
            context.MainForm = login;
            Application.Run(context);*/

            
            Application.Run(new MainForm());
        }

        private static IServiceProvider CreateProvider()
        {
            var services = new ServiceCollection();

            services.AddTransient<SignUp>();
            services.AddTransient<MainForm>();
            services.AddTransient<ApplicationContext>();
            services.AddTransient<Func<MainForm>>(sp =>
            {
                return () => sp.GetRequiredService<MainForm>();
            });
            services.AddTransient<Func<SignUp>>(sp =>
            {
                return () => sp.GetRequiredService<SignUp>();
            });

            return services.BuildServiceProvider();
        }
    }
}