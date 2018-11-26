using System.Collections.Generic;
using Miasin.Services.Domain;

namespace Miasin.Services.DataServices.Contracts
{
    public interface IDataService<T,TKey> 
        where T : BaseEntity<TKey>
    {
        TKey Create(T entity);

        int Update(T entity);

        int Delete(T entity);

        int DeleteById(TKey id);

        T Get(TKey id);

        IEnumerable<T> GetAll();
    }
}