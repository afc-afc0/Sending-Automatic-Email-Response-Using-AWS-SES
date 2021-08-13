    using System;
using System.Collections.Generic;
using System.Text;

namespace AwsLibrary.AWS.Options
{
    public class EmailMessageSenderOptions
    {
        public string defaultSender { get; set; } = "ahmet_fatih_cengiz@hotmail.com";
        public string defaultSubject { get; set; } = "Amazom SES Test with .Net";
        public string defaultBody { get; set; } = "Amazon SES test Hello ";
    }
}
