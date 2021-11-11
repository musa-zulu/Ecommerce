using System.Threading.Tasks;
using Ecommerce.Domain.Settings;

namespace Ecommerce.Service.Contracts
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
