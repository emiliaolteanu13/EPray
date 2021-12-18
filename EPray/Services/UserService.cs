using EPray.EntityFramework;
using EPray.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            var users = _context.Users.Where(x => x.Email == model.Email && x.Password == HashPassword(model.Password)).ToList();
            if (users.Count == 1)
            {
                return users[0];
            }
            return null;
        }

        public string HashPassword(string password)
        {
            byte[] salt = System.Text.Encoding.UTF8.GetBytes("EPRAY");
            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
  
            return hashed;
        }
    }
}
