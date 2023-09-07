using Infrastructure.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IService
{
    public interface IUserService
    {
        Task<List<UserRoleResponce>> GetAllRoleAssosiateUser();
        Task<List<UserRoleResponce>> GetAllRoleNotAssosiateUser();
    }
}
