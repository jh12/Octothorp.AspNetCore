using System.Reflection;

namespace Octothorp.AspNetCore.Health;

public class HealthUtil
{
    public static string GetVersion()
    {
        string? informationalVersion = Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

        return informationalVersion ?? "Unknown";
    }
}