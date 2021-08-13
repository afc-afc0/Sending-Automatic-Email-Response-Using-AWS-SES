using Amazon;
using System;
using System.Collections.Generic;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using System.Threading.Tasks;
using AwsLibrary.AWS.Interfaces;
using Microsoft.Extensions.Options;
using AwsLibrary.AWS.Options;

namespace AwsLibrary.AWS.SNS
{
    public class EmailMessageSender : IMessageSender
    {
        private IOptions<EmailMessageSenderOptions> options { get; set; }

        public EmailMessageSender(IOptions<EmailMessageSenderOptions> options)
        {
            this.options = options;
        }

        public async Task SendMessage(string name, string receiverEmail, string userMessage)
        {

            string message = $"{options.Value.defaultBody} {name}! " +
                $"Your message : {userMessage}";//<defaultMessage> <name>! Your message : <userMessage>

            using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.USEast1))
            {

                var sendRequest = new SendEmailRequest
                {
                    Source = options.Value.defaultSender,
                    Destination = new Destination
                    {
                        ToAddresses = new List<string> { receiverEmail }
                    },
                    Message = new Message
                    {
                        Subject = new Content(options.Value.defaultSubject),
                        Body = new Body
                        {
                            Text = new Content
                            {
                                Charset = "UTF-8",
                                Data = message
                            }
                        }
                    },

                };
                try
                {
                    Console.WriteLine("Sending Email Using AWS SES");
                    var response = await client.SendEmailAsync(sendRequest);
                    Console.WriteLine("The email was sent successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Email was not send !!!");
                    Console.WriteLine("Exception = " + ex.Message);
                }
            }
        }

       
    }
}
