<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.DependencyInjection</NuGetReference>
  <NuGetReference>Wagner.NLogServices</NuGetReference>
  <Namespace>Microsoft.Extensions.DependencyInjection</Namespace>
  <Namespace>Microsoft.Extensions.Logging</Namespace>
  <Namespace>Wagner.NLogServices</Namespace>
</Query>

void Main()
{
	// Write code to test your extensions here. Press F5 to compile and run.
}

public static class MyExtensions
{
	// Write custom extension methods here. They will be available to all queries.
	public static ILoggerFactory GetLogger(this NLogService nlogService)
	{
		NLogService service = new NLogService();
		var host = service.UseNLogConsole(Util.MyQueriesFolder);
		var loggerFactory = host.Services.GetService<ILoggerFactory>();
		return loggerFactory;
	}
}

// You can also define non-static classes, enums, etc.