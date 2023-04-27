using CihanAbay.Models;

namespace CihanAbay.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetSingle(int id);
        User Add(User toAdd);
        User Update(User toUpdate);
        void Delete(User toDelete);
        int Save();
    }
}
