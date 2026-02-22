using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IAppointmentRepository
    {
        /// <summary>
        /// Saves a new appointment into the repository.
        /// </summary>
        /// <param name="appointment">
        /// Appointment instance to be saved.
        /// </param>
        /// <returns></returns>
        Guid Save(Appointment appointment);

        /// <summary>
        /// Gets all appointments in the repository.
        /// </summary>
        /// <param name="parameters">
        /// Filter object to filter appointments based on certain parameters.
        /// </param>
        /// <returns>
        /// Returns a list with the appointments found.
        /// </returns>
        List<Appointment> GetAll(AppointmentFilter parameters);

        /// <summary>
        /// Gets all the appointments that belong to one user in the repository.
        /// </summary>
        /// <param name="userId">
        /// User's id of the appointments to be gotten.
        /// </param>
        /// <param name="parameters">
        /// Filter object to filter appointments based on certain parameters.
        /// </param>
        /// <returns>
        /// Returns a list with the appointments found.
        /// </returns>
        List<Appointment> GetByUserId(Guid userId, AppointmentFilter parameters);

        /// <summary>
        /// Gets all appointment status in the repository.
        /// </summary>
        /// <returns>
        /// Returns a list of appointment status object.
        /// </returns>
        List<AppointmentStatus> GetAppointmentStatus();

        /// <summary>
        /// Gets the appointment with the specified id in the respository.
        /// </summary>
        /// <param name="id">
        /// Appointment's id to be found.
        /// </param>
        /// <returns>
        /// Returns either the appointment if found or null if not.
        /// </returns>
        Appointment? GetById(Guid id);

        /// <summary>
        /// Updates data of an existing appointment in the repository.
        /// </summary>
        /// <param name="appointment">
        /// Appointment to be updated.
        /// </param>
        /// <returns>
        /// Returns true if appointment was successfully updated or false when not.
        /// </returns>
        bool Update(Appointment appointment);

        /// <summary>
        /// Deletes the specified appointment from the repository.
        /// </summary>
        /// <param name="id">
        /// Appointment's id to be deleted.
        /// </param>
        /// <returns>
        /// Returns true if delition was successful or false if not.
        /// </returns>
        bool Delete(Guid id);
    }
}
