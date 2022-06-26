using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.BLL.Data;
using EMS.BLL.Interface;
using EMS.BLL.Models;
using EMS.BLL.ViewModels;
using Microsoft.EntityFrameworkCore;
namespace EMS.BLL.Implementation
{
    public class UserManager : BaseManager, IUserManager
    {
        public UserManager(EMSContext Context) : base(Context)
        {
        }

        public async Task<LoginViewModel> CheckIsUserValid(string emailId, string password)
        {
            var data = await (from u in Context.Users
                              join ur in Context.UserRoles on u.UserId equals ur.UserId
                              join r in Context.Roles on ur.RoleId equals r.RoleId
                              where u.EmailId == emailId && u.Password == password
                              select new LoginViewModel
                              {
                                  UserId = u.UserId,
                                  FirstName = u.FirstName,
                                  LastName = u.LastName,
                                  Password = u.Password,
                                  MobileNumber = u.MobileNumber,
                                  EmailId = u.EmailId,
                                  RoleId = r.RoleId,
                                  RoleName = r.RoleName,
                                  PasswordSalt = u.PasswordSalt,
                              }).FirstAsync();
            return data;
        }

        public string GetUserPasswordSalt(string userName)
        {
            return (from u in Context.Users where u.EmailId == userName select u.PasswordSalt).SingleOrDefault();

        }
    }
}
