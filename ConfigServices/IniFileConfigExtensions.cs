

using ConfigServices;
using Microsoft.Extensions.DependencyInjection;

namespace FxResources.Microsoft.Extensions.DependencyInjection
{
    public static class IniFileConfigExtensions
    {
        /// <summary>
        /// 功能：添加读取Ini文件的服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="filePath"></param>
        public static void AddIniFileConfig(this IServiceCollection services, string filePath)
        {
            services.AddScoped(typeof(IConfigService), s => new IniFileConfigService { FilePath = $"{filePath}" });
        }
    }
}