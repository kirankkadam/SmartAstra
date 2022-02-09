using SmartAstra.Framework.Common;
using SmartAstra.Framework.Entities.Interfaces;
using System;

namespace SmartAstra.Dto
{
    public class Response<T> : IResponse<T>
    {
        private T _result = default(T);
        public Response()
        {
            Id = Guid.NewGuid();
            Status = ResponseStatus.None;
        }

        public Guid Id { get; set; }
        public T Result
        {
            get { return _result; }
            set
            {
                _result = value;
                if (_result != null)
                {
                    this.Status = ResponseStatus.Success;
                }
            }
        }

        public ResponseStatus Status { get; set; }
    }

}
