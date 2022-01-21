using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using service_layers_demo;

internal class Program
{
	static void Main(string[] args)
	{
		// register service for DI
		using IHost host = Host.CreateDefaultBuilder(args)
			.ConfigureServices((_, services) => services.AddSingleton<IUserColorsService, UserColorsService>())
			.Build();

		// invoke our instance method using DI
		DoSomeWork(host.Services);
	}

	static void DoSomeWork(IServiceProvider services)
	{
		using IServiceScope serviceScope = services.CreateScope();
		IServiceProvider provider = serviceScope.ServiceProvider;

		var colorService = provider.GetRequiredService<IUserColorsService>();

		// Where we used to use a static method call, we now have an instance method call
		var currentUserID = 123;
		var favouriteColor = colorService.GetFavourite(currentUserID);
		Console.WriteLine(favouriteColor);
	}
}
