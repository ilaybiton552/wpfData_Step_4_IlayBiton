using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceModel
{
    public class ServiceSnack : IServiceSnack
    {
        public CityList GetAllCities()
        {
            CityDB cityDB = new CityDB();
            return cityDB.SelectAll();
        }

        public SnackList GetAllSnacks()
        {
            SnackDB snackDB = new SnackDB();
            return snackDB.SelectAll();
        }

        public UserList GetAllUsers()
        {
            UserDB userDB = new UserDB();
            return userDB.SelectAll();
        }

        public SnackList GetSnacksByUser(User user)
        {
            SnackDB snackDB = new SnackDB();
            return snackDB.SelectByUserId(user.Id);
        }

        public UserList GetUsersBySnack(Snack snack)
        {
            UserDB userDB = new UserDB();
            return userDB.SelectBySnackId(snack.Id);
        }

        public User Login(User user)
        {
            UserDB userDB = new UserDB();
            return userDB.Login(user.UserName, user.Password);
        }
    }
}
