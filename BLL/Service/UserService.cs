using BLL.IService;
using DAL.IRepository;
using Infrastructure.Result;

namespace BLL.Service
{
    public class UserService : IUserService
    {
        public readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<List<UserRoleResponce>> GetAllRoleAssosiateUser()
        {
            return  await _userRepo.GetAllRoleAssosiateUser();
        }

        public async Task<List<UserRoleResponce>> GetAllRoleNotAssosiateUser()
        {
            return await _userRepo.GetAllRoleNotAssosiateUser();
        }
    }
}
