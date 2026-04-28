using DIExample.Services;
using DIExample.ViewModels;
using DIExample.Views;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace DIExample
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();

			builder.AddPages().AddViewModels().AddServices();
#endif
			//builder.Services.AddTransient<ScorePage>();
			//builder.Services.AddTransient<ScorePageViewModel>();
			//builder.Services.AddSingleton<IScoreService,TheRealService>();
			return builder.Build();
		}
		public static MauiAppBuilder AddPages(this MauiAppBuilder builder)
		{
			builder.Services.AddTransient<ScorePage>();

			return builder;

		}
		public static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
		{
			builder.Services.AddTransient<ScorePageViewModel>();

			return builder;

		}
		public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
		{
			builder.Services.AddTransient<IScoreService, MockScoreService>();

			return builder;

		}

	}
}
