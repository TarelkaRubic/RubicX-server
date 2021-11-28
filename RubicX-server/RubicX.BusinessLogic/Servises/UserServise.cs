using AutoMapper;
using RubicX.BusinessLogic.Core.Interfaces;
using RubicX.BusinessLogic.Core.Models;
using RubicX_server.DataAccess.Core.Models;
using RubicX_server.DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace RubicX.BusinessLogic.Servises
{
    public class UserServise : IUserService
    {
        private readonly IMapper _mapper;
        private readonly RubicContext _context;


        public UserServise(IMapper mapper, RubicContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<UserInformationBlo> AuthWithEmail(string email, string password)
        {
            UserRto user = _context.Users.FirstOrDefault(p => p.Email == email && p.Password == password);
            if (user == null)

                throw new NotFoundException($"Такой пользователь не найден {email} ");
            if (user.Password != password)
            {
               
            }



        }

        public Task<UserInformationBlo> AuthWithLogin(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> AuthWithPhone(string numberPrefix, string sumNumber, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(string numPrefix, string sumNumber)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string sumNumber, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, string numberPrefix, string sumNumber, string password)
        {
            throw new NotImplementedException();
        }
        private async Task<UserInformationBlo> ConvertUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentNullException(nameof(userRto));

            var userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
