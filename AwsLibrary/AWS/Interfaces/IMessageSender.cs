namespace AwsLibrary.AWS.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMessageSender
    {
        public Task SendMessage(string name, string adress, string userMessage);
    }
}
