using SmartAstra.Framework.Entities.Interfaces;
using System;

namespace SmartAstra.Dto
{
    public class Request<T> : IRequest<T>
    {
        public Guid Id { get; set; }
        public T Data { get; set; }
        public DateTime SentAt { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }


        public Request(T data)
        {
            Id = Guid.NewGuid();
            Data = data;
            SentAt = DateTime.Now;
        }

    }
}
