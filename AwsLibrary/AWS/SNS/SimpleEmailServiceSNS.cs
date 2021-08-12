using Amazon;
using System;
using System.Collections.Generic;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using System.Threading.Tasks;

namespace AwsLibrary.AWS.SNS
{
    public class SimpleEmailServiceSNS
    {
        #region SINGLETON   
        private static SimpleEmailServiceSNS instance;

        public static SimpleEmailServiceSNS GetInstance()
        {
            if (instance == null)
            {
                instance = new SimpleEmailServiceSNS();
            }
            return instance;
        }
        #endregion


        #region Default Values
        const string defaultSenderAddress = "ahmet_fatih_cengiz@hotmail.com";
        const string defaultRecieverAddress = "ahmetfatihcengiz2355@gmail.com";
        const string defaultSubject = "Amazom SES Test with .Net";
        const string defaultTextBody = "Amazon SES test Hello ";
        #endregion

        public SimpleEmailServiceSNS()
        {

        }

        public async Task SendEmailTo(string senderAddress = defaultSenderAddress, string recieverAddress = defaultRecieverAddress, string subject = defaultSubject, string textBody = defaultTextBody)
        {
            using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.USEast1))
            {
          
                var sendRequest = new SendEmailRequest
                {
                    Source = senderAddress,
                    Destination = new Destination
                    {
                        ToAddresses = new List<string> { recieverAddress }
                    },
                    Message = new Message
                    {
                        Subject = new Content(subject),
                        Body = new Body
                        {
                            Text = new Content
                            {
                                Charset = "UTF-8",
                                Data = textBody
                            }
                        }
                    },

                };
                try
                {
                    Console.WriteLine("Sending Email Using AWS SES");
                    var response = await client.SendEmailAsync(sendRequest);
                    Console.WriteLine("The email was sent successfully");
                    Console.WriteLine("From = " + senderAddress + " --> To = " + recieverAddress);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Email was not send !!!");
                    Console.WriteLine("Exception = " + ex.Message);
                }
            }
        }
    }
}
