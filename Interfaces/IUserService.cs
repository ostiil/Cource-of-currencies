using Microsoft.VisualBasic.ApplicationServices;
using demo.Contexts;

namespace demo.Interfaces
{
    public interface IUserService
    {

        public Users? AuthorizeUser(string login, string password);
        public Users? RegisterUser(string fio, string login, string password);
        public Currency? AddCurrency(string name, int favorites);
        //public Currency? EditCurrency(string name, int favorites);
        public List<Currency> GetCurrency();
        public void RemoveCurrency(int id);
    }
}