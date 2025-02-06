using Shared.Common;

namespace Api.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder RegisterCommandHandlers(this WebApplicationBuilder builder)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(x=> x is
                       {
                           IsClass: true,
                           IsAbstract: false
                       } 
                       && x.GetInterfaces()
                           .Any(i => i.IsGenericType 
                                     && i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>)));

        foreach (var type in types)
        {
            var interfaceTypes = type.GetInterfaces()
                .Where(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ICommandHandler<,>));

            foreach (var interfaceType in interfaceTypes)
            {
                builder.Services.AddSingleton(interfaceType, type);
            }
        }
        
        return builder;
    }
    
    public static WebApplicationBuilder RegisterQueryHandlers(this WebApplicationBuilder builder)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(x=> x is
                       {
                           IsClass: true,
                           IsAbstract: false
                       } 
                       && x.GetInterfaces()
                           .Any(i => i.IsGenericType 
                                     && i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)));

        foreach (var type in types)
        {
            var interfaceTypes = type.GetInterfaces()
                .Where(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IQueryHandler<,>));

            foreach (var interfaceType in interfaceTypes)
            {
                builder.Services.AddSingleton(interfaceType, type);
            }
        }
        
        return builder;
    }
}