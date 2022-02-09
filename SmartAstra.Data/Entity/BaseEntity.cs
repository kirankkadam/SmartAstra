using SmartAstra.Data.Entity.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartAstra.Data.Entity
{
    public class BaseEntity: IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
