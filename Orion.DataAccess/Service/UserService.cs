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
                return context.Users.Include(x => x.Permission).ToList();
            }
        }

        public User GetUser(User user)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Users.Include(x => x.Permission).FirstOrDefault(x => x.Id == user.Id);
            }
        }

        public User UpdateUser(User user)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                User dbUser = user.Id != 0 ? context.Users.Include(x => x.Permission).FirstOrDefault(x => x.Id == user.Id) : user;

                dbUser.Name = user.Name;
                dbUser.LoginName = user.LoginName;
                dbUser.PassKey = user.PassKey;
                dbUser.Email = user.Email;
                dbUser.Telephone = user.Telephone;

                dbUser.Permission.CanEditCatalogs = user.Permission.CanEditCatalogs;
                dbUser.Permission.IsAdmin = user.Permission.IsAdmin;

                context.Update(dbUser);
                context.SaveChanges();

                return dbUser;
            }
        }

        public bool LoginNameExist(User user)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Users.Any(x => x.LoginName.ToFormat() == user.LoginName.ToFormat() && x.Id != user.Id);
            }
        }
    }
}
