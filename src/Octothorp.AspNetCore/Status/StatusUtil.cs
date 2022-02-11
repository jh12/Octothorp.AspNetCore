using System.Reflection;

namespace Octothorp.AspNetCore.Status;

public class StatusUtil
{
    public static string GetVersion()
    {
        string? informationalVersion = Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

        return informationalVersion ?? "Unknown";
    }
}