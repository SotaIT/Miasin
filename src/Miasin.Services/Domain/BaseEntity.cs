using System.ComponentModel.DataAnnotations;

namespace Miasin.Services.Domain
{
    public abstract class BaseEntity
    {

    }

    public abstract class BaseEntity<TKey>: BaseEntity
    {
        [Key]
        public TKey Id { get; set; }
    }
}