using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Miasin.Services.Repositories.Contracts
{
    public interface IRoleRepository
    {
        Task<bool> InsertAsync(IdentityRole role, CancellationToken cancellationToken);
        Task<bool> RemoveAsync(string id, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(IdentityRole role, CancellationToken cancellationToken);
        Task<IdentityRole> GetByIdAsync(string id);
        Task<IdentityRole> GetByNameAsync(string roleName);
        Task<IEnumerable<IdentityRoleClaim<string>>> GetClaimsByRole(IdentityRole role, CancellationToken cancellationToken);
        Task<bool> InsertClaimAsync(IdentityRole role, Claim claim, CancellationToken cancellationToken);
        Task<bool> RemoveClaimAsync(IdentityRole role, Claim claim, CancellationToken cancellationToken);
    }
}