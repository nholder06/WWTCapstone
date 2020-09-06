using System;
using System.Collections.Generic;
using System.Linq;
using WWTCapstone_api.Helpers;
using WWTCapstone_api.Models;

namespace WWTCapstone_api.Services
{
    public class UserService : IUserService
    {

       private DataContext _context;

       public UserService(DataContext context)
       {
          _context = context;
       }

        public User Authenticate(string email, string password)
       {
           if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
           {
                return null;
           }

           var user = _context.User.SingleOrDefault(x => x.Email == email);


           if (user == null)
           {
               return null;
           }

           if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
           {
               return null;
           }


            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User;
        }
        public User GetById(int id)
        {
            return _context.User.Find(id);
        }

        public User Create(User user, string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required.");

            if (_context.User.Any(x => x.Email == user.Email))
                throw new AppException("This email ' " + user.Email + " ' already has an account.");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

           _context.User.Add(user);
           _context.SaveChanges();
          
            return user;
        }

       public void Update(User userParam, string password = null)
        {
            var user = _context.User.Find(userParam.Id);

            if (user == null)
                throw new AppException("User not found.");
            if (userParam.Email != user.Email)
            {
                if (_context.User.Any(x => x.Email == userParam.Email))
                    throw new AppException("Email " + userParam.Email + "is already taken.");
            }

            user.FullName = userParam.FullName;
            user.Email = userParam.Email;

            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            _context.User.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.User.Find(id);
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Value cannot be empty or whitespace.", "password");
            }
            if (storedHash.Length != 64)
            {
                throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            }
            if (storedSalt.Length != 128)
            {
                throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");
            }

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                    {
                        return false;
                   }
                }
            }
            return true;
        }
    }
}
