using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoMarket.Domain.Models;

namespace TechnoMarket.Application.Services
{
    public class UserServices
    {
        private static List<User> Users = new List<User>(); //Creo una lista que va a contener los Users

        //Metodo para endpoint GET
        public IEnumerable<User?> GetUserList()
        {
            var response = Users.Where(a => a.Active).ToList();

            return response;
        }

        //Metodo para endpoint GET por ID
        public User? GetUserById(int id)
        {
            User? user = Users.Where(p => p.Id == id && p.Active).FirstOrDefault(); //Este método devuelve el primer elemento de la secuencia que cumple con las condiciones especificadas en el Where.

            return user;
        }

        //Metodo para endpoint de registrar usuario
        public bool RegisterUser(User user)
        {
            if (Users.Any(u => u.Email == user.Email))
            {
                return false;

            }
            Users.Add(user);

            return true;
        }
    }
}
