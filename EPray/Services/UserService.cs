using EPray.EntityFramework;
using EPray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.Services
{
    public class UserService
    {
        private PrayerContext _context;
        public UserService(PrayerContext context)
        {
            _context = context;
        }
        public UserModel GetUserIfValid(RegistrationModel model)
        {
            var users = _context.Users.Where(x => x.Email == model.Email && x.Password == model.Password).ToList();
            if (users.Count == 1)
            {
                return users[0];
            }
            return null;
        }
    }
}
