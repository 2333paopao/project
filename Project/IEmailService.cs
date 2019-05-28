namespace Project
{
    public interface IEmailService
    {
        void Send(string fromEmailAddress, string fromDisplayName, string toEmailAdress, string subject, string body);
    }
}
