using System;
using ConfigServices;
using LogServices;

namespace MailServices
{
    public class MailService:IMailService
    {
        private readonly ILogProvider log;
        //private readonly IConfigService config;
        private readonly IConfigReader config;

        public MailService(ILogProvider log, IConfigReader config)
        {
            this.log = log;
            this.config = config;
        }
        public void Send(string title, string to, string body)
        {
            this.log.LogInfo($"准备发邮件前");
            string smtpServer = this.config.GetValue("smtpServer");
            string userName = this.config.GetValue("UserName");
            string password = this.config.GetValue("password");
            Console.WriteLine($"邮件服务器地址{smtpServer},{userName},{password}");
            Console.WriteLine($"发邮件！{title},{to}:{body}");
            this.log.LogInfo($"邮件发送完成");
        }
    }
}
