using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace Persistence.Repositories
{
    public class AppointmentFileRepo : IAppointmentRepository
    {
        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll(AppointmentFilter parameters)
        {
            throw new NotImplementedException();
        }

        public List<AppointmentStatus> GetAppointmentStatus()
        {
            throw new NotImplementedException();
        }

        public Appointment? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Save(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public bool Update(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
