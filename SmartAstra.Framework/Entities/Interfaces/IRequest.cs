using System;

namespace SmartAstra.Framework.Entities.Interfaces
{
    public interface IRequest<T>
    {
        Guid Id { get; set; }
        T Data { get; set; }
        int PageNumber { get; set; }
        int PageSize { get; set; }
        DateTime SentAt { get; set; }
    }
}
