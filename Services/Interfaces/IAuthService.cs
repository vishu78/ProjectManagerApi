using ProjectManagerApi.DTOs;
using ProjectManagerApi.Models;

namespace ProjectManagerApi.Services.Interfaces
{
    public interface IAuthService
    {
        string Register(RegisterDto dto);
        string Login(LoginDto dto);
        User? GetUser(string username);
    }
}
