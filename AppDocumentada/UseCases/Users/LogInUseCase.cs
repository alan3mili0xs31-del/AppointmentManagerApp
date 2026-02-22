using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases.Users
{
    public class LogInUseCase
    {
        private readonly IUserRepository _userRepo;

        public LogInUseCase(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Execute(string userName, string password)
        {
            var userFound = new FindUserUseCase(_userRepo).FindByUserName(userName);
            userFound.DoesPasswordMatch(password);
            return userFound;
        }
    }
}
