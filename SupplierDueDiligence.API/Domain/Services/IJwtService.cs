using SupplierDueDiligence.API.Domain.Models;

namespace SupplierDueDiligence.API.Domain.Services;

public interface IJwtService
{
    string CookieKey { get; }
    int ExpiresInMinutes { get; }
    string GenerateToken(User user);
}
