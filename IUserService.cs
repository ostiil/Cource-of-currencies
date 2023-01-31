using Microsoft.VisualBasic.ApplicationServices;

namespace demo
{
    public interface IUserService
    {
        
            public User? AuthorizeUser(string login, string password);
            public User? RegisterUser(string fio, string login, string password);
        
    }
}