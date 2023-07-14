using ClubMagnament;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

services.AddTransient<IClub, Mandarine>();
services.AddTransient<Club>();
services.AddTransient<IGenre, Genre>();
services.AddTransient<IGig, Gig>();
services.AddTransient<IStaff, Security>();
services.AddTransient<IIncome, Income>();

ServiceProvider serviceProvider = services.BuildServiceProvider();

Club club = serviceProvider.GetService<Club>();
club.ShowInfo();

Console.ReadKey();

