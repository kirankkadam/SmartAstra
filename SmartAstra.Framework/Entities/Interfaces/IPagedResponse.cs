using System;
using System.Collections.Generic;

namespace SmartAstra.Framework.Entities.Interfaces
{
    public interface IPagedResponse<TResponse>
    {
        Guid Id { get; set; }
        int Page { get; set; }
        int TotalPages { get; set; }
        int RecordsPerPage { get; set; }
        List<TResponse> Result { get; set; }
    }
}
