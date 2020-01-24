using System.Threading.Tasks;

namespace DevBlog.Domain.Services
{
    public interface ISecurityService
    {
        Task<bool> ValidateUser(string token);

        Task<bool> RegisterUser(string token);
    }
}