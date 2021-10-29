using System.ComponentModel.DataAnnotations;
using PIM.Core.Entity.Abstract;

namespace PIM.Core.Entity.Concrete
{
    public abstract class BaseEntity<T> : IEntity
    {
        [Key]
        public T Id { get; set; }
    }
}