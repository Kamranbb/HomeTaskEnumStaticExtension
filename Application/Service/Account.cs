using Application.Application.IAccount;
using Application.Constans;
using Application.Enum;
using System.ComponentModel.DataAnnotations;


namespace Application.Service
{
    public  class Account : IAccount
    {
         public void Login (string email, string password, Roles role)
        {
            if (email==Constans.Constans.Email&& Constans.Constans.Password == "test12345")
            {
               if (role==Roles.SuperAdmin)
                {
                    Console.WriteLine(Constans.Constans.Succesmessage);
                }
               else
                {
                    Console.WriteLine(Constans.Constans.RoleMessage);
                }
            }
            else
            {
                Console.WriteLine(Constans.Constans.FailMessage);
            }
        }

        
    }
}
