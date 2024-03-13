using Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application.IAccount
{
    interface IAccount 
    {
        public void Login(string email, string password, Roles role);
    }
}
