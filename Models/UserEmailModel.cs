namespace SendResponseEmailUsingAWS
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc;

    public class UserEmailModel
    {
        [DisplayName("Name")]
        [StringLength(128)]
        public string UserName { get; set; }
        
        [DisplayName("Email")]
        [Required]
        [StringLength(256)]
        [EmailAddress]
        public string UserEmail { get; set; }
        
        [DisplayName("Message")]
        [StringLength(2048)]
        public string UserMessage { get; set; }
    }
}