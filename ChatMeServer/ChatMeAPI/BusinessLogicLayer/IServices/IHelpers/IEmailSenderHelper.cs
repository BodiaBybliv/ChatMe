using System.Threading.Tasks;


namespace BusinessLogicLayer.IServices.IHelpers
{
    public interface IEmailSenderHelper
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
