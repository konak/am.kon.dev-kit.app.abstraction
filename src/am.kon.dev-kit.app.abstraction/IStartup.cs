using Microsoft.Extensions.Hosting;

namespace am.kon.DevKit.App;

/// <summary>
/// Defines the contract for initializing and configuring the host application during startup.
/// </summary>
public interface IStartup
{
    /// <summary>
    /// Configures and initializes the host application during startup.
    /// </summary>
    /// <param name="builder">The <see cref="IHostApplicationBuilder"/> instance used to configure the application.</param>
    /// <returns>Returns the configured <see cref="IHostApplicationBuilder"/> instance.</returns>
    IHostApplicationBuilder Start(IHostApplicationBuilder builder);
}