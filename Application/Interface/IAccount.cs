using Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application.IAccount
{
    internal interface IAccount 
    {
    void Login (string username, string password,Roles role);
    }
}
