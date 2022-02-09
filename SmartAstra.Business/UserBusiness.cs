using SmartAstra.Dto;
using SmartAstra.Entities;
using SmartAstra.Framework.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAstra.Business
{
    public class UserBusiness
    {
        public IResponse<User> GetUser(int id)
        {
            return new Response<User>();
        }
    }
}
