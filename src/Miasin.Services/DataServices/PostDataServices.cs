using Miasin.Services.DataServices.Contracts;
using Miasin.Services.Domain;
using Microsoft.Extensions.Configuration;

namespace Miasin.Services.DataServices
{
    public class PostDataServices: BaseDataService<Post, long>, IPostDataService
    {
        public PostDataServices(IConfiguration configuration) : base(configuration)
        {
        }

        protected override string TableName => "Posts";
        public override long Create(Post entity)
        {
            throw new System.NotImplementedException();
        }

        public override int Update(Post entity)
        {
            throw new System.NotImplementedException();
        }
    }
}