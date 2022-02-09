using Microsoft.AspNetCore.Mvc;
using SmartAstra.Framework.Entities.Interfaces;

namespace SmartAstra.Framework.Controllers
{
    public class BaseController<TResponse> : Controller where TResponse : class, IEntity
    {
        public BaseController()
        {

        }

    }
}
