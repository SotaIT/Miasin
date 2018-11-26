using Miasin.Services.DataServices.Contracts;
using Miasin.Services.Domain;
using Microsoft.Extensions.Configuration;

namespace Miasin.Services.DataServices
{
    public class AuthorDataService : BaseDataService<Author, string>, IAuthorDataService
    {
        public AuthorDataService(IConfiguration configuration) : base(configuration)
        {
        }

        protected override string TableName => "Authors";
        public override string Create(Author entity)
        {
            throw new System.NotImplementedException();
        }

        public override int Update(Author entity)
        {
            throw new System.NotImplementedException();
        }
    }
}