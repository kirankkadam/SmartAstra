using SmartAstra.Framework.Common;
using SmartAstra.Framework.Entities.Interfaces;
using System;

namespace SmartAstra.Framework.Entities
{
    public class Response<T> : IResponse<T>
    {
        public Response(T result)
        {
            Id = Guid.NewGuid();
            Result = result;
        }

        public Guid Id { get; set; }
        public T Result { get; set; }
        public Guid RequestId { get; set; }
        public int PageCount { get; set; }
        public ResponseStatus Status { get; set; }
    }
}
