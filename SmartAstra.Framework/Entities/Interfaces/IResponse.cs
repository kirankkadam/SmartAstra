using SmartAstra.Framework.Common;
using System;

namespace SmartAstra.Framework.Entities.Interfaces
{
    public interface IResponse<T>
    {
        Guid Id { get; set; }
        T Result { get; set; }
        int PageCount { get; set; }
        Guid RequestId { get; set; }
        ResponseStatus Status { get; set; }
    }
}
