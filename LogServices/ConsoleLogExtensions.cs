using LogServices;
using Microsoft.Extensions.DependencyInjection;
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConsoleLogExtensions
    {
        /// <summary>
        /// 功能：添加打印日志的服务
        /// </summary>
        /// <param name="services"></param>
        public static void AddConsoleLog(this IServiceCollection services)
        {
            services.AddScoped<ILogProvider,ConsoleLogProvider>();
        }
    }
}