using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
    [ServiceContract]
    public interface IServiceSnack
    {
        [OperationContract] CityList GetAllCities();
        [OperationContract] UserList GetAllUsers();
        [OperationContract] SnackList GetAllSnacks();
        [OperationContract] SnackList GetSnacksByUser(User user);
        [OperationContract] UserList GetUsersBySnack(Snack snack);
        [OperationContract] User Login(User user);
    }
}
