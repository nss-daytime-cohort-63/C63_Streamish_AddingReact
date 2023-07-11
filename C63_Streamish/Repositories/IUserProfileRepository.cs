using C63_Streamish.Models;
using System.Collections.Generic;

namespace C63_Streamish.Repositories
{
    public interface IUserProfileRepository
    {
        void Add(UserProfile userProfile);
        void Delete(int id);
        List<UserProfile> GetAll();
        UserProfile GetById(int Id);
        UserProfile GetUserProfileByIdWithComments(int id);
        void Update(UserProfile userProfile);
    }
}