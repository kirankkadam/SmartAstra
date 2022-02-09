using SmartAstra.Framework.Entities.Interfaces;

namespace SmartAstra.Dto
{
    public class Company: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
