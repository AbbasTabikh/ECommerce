
using ECommerce.Shared.Models;

namespace ECommerce.Server.Services
{
    public interface ITokenService
    {
        string GenerateToken(Models.Client client);
    }
}
