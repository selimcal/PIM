using System.ComponentModel.DataAnnotations;

namespace PIM.Core.Entity.Abstract
{
    public abstract class BaseEntity<T> : IEntity
    {
        [Key]
        public T Id { get; set; }
    }
}