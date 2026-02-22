using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IUserRepository
    {
        User? GetById(Guid id);
        User? GetByUserName(string userName);
    }
}
