

using MailServices;
using Microsoft.Extensions.DependencyInjection;

namespace FxResources.Microsoft.Extensions.DependencyInjection
{
    public static class MailServiceExtensions
    {
        /// <summary>
        /// 功能：添加邮箱的服务
        /// </summary>
        /// <param name="services"></param>
        public static void AddMailService(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailService>();
        }
    }
}