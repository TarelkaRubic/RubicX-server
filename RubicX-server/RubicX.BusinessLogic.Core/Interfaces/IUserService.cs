using RubicX.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX.BusinessLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string sumNumber, string password);
        Task<UserInformationBlo> AuthWithPhone(string numberPrefix, string sumNumber, string password);
        Task<UserInformationBlo> AuthWithEmail(string email, string password);
        Task<UserInformationBlo> AuthWithLogin(string login, string password);
        Task<UserInformationBlo> Get(int userId);
        Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, string numberPrefix, string sumNumber, string password);
        Task<bool> DoesExist(string numPrefix, string sumNumber);


    }
}
