namespace SmartAstra.Framework.Entities.Interfaces
{
    public interface IRequest<T>
    {
        T Data { get; set; }
    }
}
