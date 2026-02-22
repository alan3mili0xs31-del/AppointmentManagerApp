using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IAppointmentRepository
    {
        Guid Save(Appointment appointment);
        List<Appointment> GetAll(AppointmentFilter parameters);
        List<AppointmentStatus> GetAppointmentStatus();
        Appointment? GetById(Guid id);
        bool Update(Appointment appointment);
        bool Delete(Guid id);
    }
}
