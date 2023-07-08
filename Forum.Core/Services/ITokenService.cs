using Forum.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Forum.Core.Services
{
    public interface ITokenService
    {
        void SetRefreshToken(User user, HttpResponse response);
        string CreateToken(User user);
    }
}
