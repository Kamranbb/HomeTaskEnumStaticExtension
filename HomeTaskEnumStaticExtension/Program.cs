using Application.Enum;
using Application.Service;
using System.Security.Principal;

namespace HomeTaskEnumStaticExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do 
                {
                    Console.WriteLine("Email daxil et ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Sifre daxil et ");
                    string password = Console.ReadLine();

                    Account account = new Account();
                    account.Login(email, password, Roles.SuperAdmin);
                }while(true);
            
                


        }
    }
}
