using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Miasin.Services.Identity
{
    public partial class MiasinUserStore : IQueryableUserStore<IdentityUser>
    {
        public IQueryable<IdentityUser> Users => throw new System.NotImplementedException();
    }
}