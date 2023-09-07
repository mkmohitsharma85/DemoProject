using DAL.IRepository;
using Infrastructure.Model;
using Infrastructure.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepo : IUserRepo
    {
        public readonly DemoDBContext _context;
        public UserRepo(DemoDBContext context)
        {
            _context = context;
        }
        public async Task<List<UserRoleResponce>> GetAllRoleAssosiateUser()
        {
            var userRoleResponse = await _context.UserRole.Include(ur => ur.User).Include(ur => ur.Role)
                                  .Select(ur => new UserRoleResponce
                                  {
                                      Id = ur.User.Id,
                                      UserName = ur.User.UserName,
                                      FullName = ur.User.FullName,
                                      RoleName = ur.Role.Name
                                  }) .ToListAsync();

            return userRoleResponse;
        }

        public async Task<List<UserRoleResponce>> GetAllRoleNotAssosiateUser()
        {
            var usersNotInUserRole =await  _context.User
                                    .Where(u => !_context.UserRole.Any(ur => ur.User.Id == u.Id))
                                    .Select(u => new UserRoleResponce
                                    {
                                        Id = u.Id,
                                        UserName = u.UserName,
                                        FullName = u.FullName,
                                        RoleName = null // No role for users not in UserRole table
                                    }).ToListAsync();

            return usersNotInUserRole;
        }
    }
}
