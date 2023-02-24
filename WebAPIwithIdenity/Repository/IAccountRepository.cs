using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebAPIwithIdenity.Models;

namespace WebAPIwithIdenity.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(Signup signup);
         Task<string> LoginAsync(Login login);
    }
}
