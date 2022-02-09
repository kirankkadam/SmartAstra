using System;

namespace SmartAstra.Framework.Entities.Interfaces
{
    public interface IResponse<T>
    {
        Guid Id { get; set; }
        T Result { get; set; }
    }
}
