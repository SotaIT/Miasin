using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Miasin.Services.DataServices.Contracts;
using Miasin.Services.Domain;

namespace Miasin.Services.DataServices
{
    public abstract class BaseDataService<T,TKey>: IDataService<T,TKey>, IDisposable where T : BaseEntity<TKey>
    {
        protected BaseDataService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Dispose()
        {
            //todo
        }

        protected IDbConnection CreateConnection()
        {
            return new SqlConnection(Configuration.GetConnectionString("MiasinConnection"));
        }

        protected abstract string TableName { get; }

        public abstract TKey Create(T entity);

        public abstract int Update(T entity);

        public int Delete(T entity)
        {
            return DeleteById(entity.Id);
        }

        public int DeleteById(TKey id)
        {
            using(var db = CreateConnection())
            {
                return db.Query<int>($"DELETE FROM [{TableName}] WHERE Id = @id", new { id }).FirstOrDefault();;
            }
        }

        public T Get(TKey id)
        {
            using(var db = CreateConnection())
            {
                return db.Query<T>($"SELECT * FROM [{TableName}] WHERE Id = @id", new { id }).FirstOrDefault();;
            }
        }

        public IEnumerable<T> GetAll()
        {
            using(var db = CreateConnection())
            {
                return db.Query<T>($"SELECT * FROM [{TableName}]").ToList();
            }
        }
    }
}