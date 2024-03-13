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
            if (email==Constans.Constans.Email&&  == "test12345")
            {
               if (role==Roles.SuperAdmin)
                {
                    Console.WriteLine("Giris ugurludur ");
                }
               else
                {
                    Console.WriteLine("girish huququnuz yoxdur!");
                }
            }
            else
            {
                Console.WriteLine("email ve ya password yanlisdir ");
            }
        }

        
    }
}
