using Microsoft.EntityFrameworkCore;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.DataAccess.Service
{
    public class UserService
    {
        public bool UserExist(string userName, string password)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Users.ToList().Exists(u => u.LoginName.ToFormat() == userName.ToFormat() && u.PassKey.ToFormat() == password.ToFormat());
            }
        }

        public async Task<User> GetUserAsync(string userName, string password)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return await context.Users.Include(x => x.Permission).FirstOrDefaultAsync(u => u.LoginName.ToFormat() == userName.ToFormat() && u.PassKey.ToFormat() == password.ToFormat());
            }
        }

        public async Task<User> GetUserAsync(int userId)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return await context.Users.FirstOrDefaultAsync(x => x.Id == userId);
            }
        }

        public List<User> GetUsers()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
