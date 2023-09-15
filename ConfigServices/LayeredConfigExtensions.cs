
using ConfigServices;
using Microsoft.Extensions.DependencyInjection;

namespace FxResources.Microsoft.Extensions.DependencyInjection
{
    public static class LayeredConfigExtensions
    {
        /// <summary>
        /// 优先级：本地 > 环境变量 > 其他服务器给的配置
        /// </summary>
        /// <param name="services"></param>
        public static void AddLayeredConfig(this IServiceCollection services)
        {
            services.AddScoped<IConfigReader, LayeredConfigReader>();
        }
    }
}