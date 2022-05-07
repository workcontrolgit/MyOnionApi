using MyOnionApi.Application.DTOs.Email;
using System.Threading.Tasks;

namespace MyOnionApi.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}