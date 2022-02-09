using SmartAstra.Framework.Entities.Interfaces;
using System;

namespace SmartAstra.Framework.Entities
{
    public class Response<T> : IResponse<T>
    {
        public Response()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public T Result { get; set; }
    }
}
