using System.Collections.Generic;
using WWTCapstone_api.Models;

namespace WWTCapstone_api.Services
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);

        //void AddPet(Pet pet, string email);
    }
}


