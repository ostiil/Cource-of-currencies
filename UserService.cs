using demo.Contexts;
using demo.Forms;
using demo.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace demo
{
    public class UserService : IUserService
    {
        //DbContextIntagrator contextDb = new DbContextIntagrator();

        public UserService()
        {
            
        }

        public Users? RegisterUser(string fio, string login, string password)
        {
            using (DbContextIntagrator db = new DbContextIntagrator())
            {

                Users users = new Users { Name = fio, Login = login, Password = password };
                db.Users.Add(users);
                db.SaveChanges();
                return users;
            }
        }

        public Users? AuthorizeUser(string login, string password)
        {
            
            using (DbContextIntagrator db = new DbContextIntagrator())
            {
                var users = db.Users.ToList();
                try
                {
                    
                    foreach (var user in users)
                    {
                        if (user.Login == login && user.Password == password)
                        {
                            MessageBox.Show("Вход выполнен");
                            return user;
                            
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден");
                        }
                    }

                }
                catch 
                {
                    return null;
                }
                return new Users { Login = login, Password = password};

            }
        }

        public Currency? AddCurrency(string name, int favorites)
        {
            CurrencyForm currencyForm = new CurrencyForm();
            Currency currency = new Currency { Name = name, Favorites = favorites };
            using (DbContextIntagrator db = new DbContextIntagrator())
            {
                db.Currencies.Add(currency);
                db.SaveChanges();
                currencyForm.dataGridView1.Update();
                //currencyForm.dataGridView1.
                return currency;
            }
        }

        public List<Currency> GetCurrency() 
        {
            List<Currency> currency;
            using (DbContextIntagrator db = new DbContextIntagrator())
            {
                currency = db.Currencies.ToList();

            }
            return currency.ToList();
        }

        public void RemoveCurrency(int id)
        {
            using (DbContextIntagrator db = new DbContextIntagrator())
            {

                var currencyRemove = GetCurrency();
                //Currency currency = new Currency();
                foreach (var currency in currencyRemove)
                {
                    if (currency.Id == id)
                    {
                        //db.Currencies.FirstOrDefault(element);
                        db.Currencies.Remove(currency);
                    }
                }
                
                db.SaveChanges();
            }
             
        }

        /*public Currency EditCurrency(string name, int favorites)
        {
            CurrencyForm currencyForm = new CurrencyForm();
            Currency currency = new Currency { Name = name, Favorites = favorites };
            using (DbContextIntagrator db = new DbContextIntagrator())
            {
                db.Currencies.Update(currency);
                db.SaveChanges();
                currencyForm.dataGridView1.Update();
                //currencyForm.dataGridView1.
                return currency;
            }
        }*/
    }
}
