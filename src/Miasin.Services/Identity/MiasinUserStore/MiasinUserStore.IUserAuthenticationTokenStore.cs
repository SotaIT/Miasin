using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Miasin.Services.Identity
{
    public partial class MiasinUserStore: IUserAuthenticationTokenStore<IdentityUser>
    {
        public Task SetTokenAsync(IdentityUser user, string loginProvider, string name, string value,
            CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveTokenAsync(IdentityUser user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetTokenAsync(IdentityUser user, string loginProvider, string name, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}