using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases.Users
{
    internal class FindUserUseCase
    {
        private readonly IUserRepository _userRepo;

        public FindUserUseCase(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User FindById(Guid id)
        {
            return _userRepo.GetById(id)
                ?? throw new KeyNotFoundException("User not found with that id.");
        }

        public User FindByUserName(string userName)
        {
            return _userRepo.GetByUserName(userName)
                ?? throw new KeyNotFoundException("User not found with that user's name.");
        }
    }
}
