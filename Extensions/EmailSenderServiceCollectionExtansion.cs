using AwsLibrary.AWS.Interfaces;
using AwsLibrary.AWS.Options;
using AwsLibrary.AWS.SNS;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SendResponseEmailUsingAWS.Extensions
{
    public static class EmailSenderServiceCollectionExtansion
    {
        public static IServiceCollection AddEmailSender(this IServiceCollection services, IConfiguration configuration)
        {
            var setting = configuration.GetSection("EmailMessageSender");
            services.Configure<EmailMessageSenderOptions>(setting =>
                setting.defaultSubject = "TEST"
            );
            services.AddScoped<IMessageSender, EmailMessageSender>();
            
            return services;
        }
    }

}