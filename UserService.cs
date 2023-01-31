using demo.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo
{
    public class UserService 
    {
        //DbContextIntagrator contextDb = new DbContextIntagrator();

        private IApplicationContext applicationContext;

        public UserService(IApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public Users? RegisterUser(string fio, string login, string password)
        {
            try
            {
                var context = new ContextFactory().CreateDbContext(null);
                var user = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null)
                {
                    throw new Exception();
                }

                user = new Users { Login = login, Password = password, Name = fio };
                context.Users.Add(user);
                context.SaveChanges();
                return user;
            }
            catch
            {
                return null;
            }
        }

        public Users? AuthorizeUser(string login, string password)
        {
            try
            {
                using var context = new ContextFactory().CreateDbContext(null);
                var user = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user == null)
                {
                    throw new Exception();
                }

                return new Users { Login = user.Login, Password = user.Password };
            }
            catch
            {
                return null;
            }
        }
    }
}
