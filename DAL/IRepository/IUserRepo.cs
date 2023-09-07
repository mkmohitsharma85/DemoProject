using Infrastructure.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IUserRepo 
    {
        Task<List<UserRoleResponce>> GetAllRoleAssosiateUser();
        Task<List<UserRoleResponce>> GetAllRoleNotAssosiateUser();
    }
}
