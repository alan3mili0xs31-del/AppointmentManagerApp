using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Gets the user in the repository that matches user's id providen .
        /// </summary>
        /// <param name="id">
        /// User's id to be found.
        /// </param>
        /// <returns>
        /// Returns either an User Objet instance if found or null if not.
        /// </returns>
        User? GetById(Guid id);

        /// <summary>
        /// Gets the user in the repository that matches user's name providen .
        /// </summary>
        /// <param name="userName">
        /// User's name to be found.
        /// </param>
        /// <returns>
        /// Returns either an User Objet instance if found or null if not.
        /// </returns>
        User? GetByUserName(string userName);
    }
}
