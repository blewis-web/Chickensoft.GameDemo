namespace GameDemo.CustomExtensions;

using Chickensoft.AutoInject;
using Microsoft.Extensions.DependencyInjection;

public static class CustomDependentExtensions
{
  public static T CustomDependOn<T>(this IDependent dependent) where T : notnull
    => dependent.DependOn(fallback: () => App.ServiceProvider.GetRequiredService<T>());
}
