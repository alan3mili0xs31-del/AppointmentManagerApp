using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace Persistence.Repositories
{
    public class AppointmentMemoryRepo : IAppointmentRepository
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();

        public bool Delete(Guid id)
        {
            var appointment = GetById(id);
            return _appointments.Remove(appointment);
        }

        public List<Appointment> GetAll(AppointmentFilter parameters)
        {
            var appointments = _appointments.FindAll((appointments) => 
                appointments.AppointmentStatus == 1);
            if (parameters.Title != null)
                appointments = _appointments.FindAll((appointment) => 
                    appointment.Title.Contains(parameters.Title, StringComparison.CurrentCultureIgnoreCase));
            if (parameters.AppointmentStatus != null)
                appointments.AddRange(_appointments.FindAll((appointment) =>
                    appointment.AppointmentStatus == parameters.AppointmentStatus));
            return appointments;
        }

        public Appointment? GetById(Guid id)
        {
            return _appointments.Find((appointment) => 
                appointment.Id == id);
        }

        public Guid Save(Appointment appointment)
        {
            _appointments.Add(appointment);
            return appointment.Id;
        }

        public bool Update(Appointment appointment)
        {
            _appointments.Remove(appointment);
            _appointments.Add(appointment);
            return true;
        }

        List<AppointmentStatus> IAppointmentRepository.GetAppointmentStatus()
        {
            throw new NotImplementedException();
        }
    }
}
