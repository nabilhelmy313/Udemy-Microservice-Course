﻿namespace Ordering.API
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            return services;
        }
        public static WebApplication UseApiServices(this WebApplication application)
        {
            return application;
        }

    }
}
