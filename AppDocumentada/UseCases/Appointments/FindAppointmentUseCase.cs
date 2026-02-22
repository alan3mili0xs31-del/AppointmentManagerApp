using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases.Appointments
{
    internal class FindAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public FindAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public Appointment Execute(Guid id)
        {
            return _appointmentRepo.GetById(id)
                ?? throw new KeyNotFoundException("Appointment not found with that id.");
        }
    }
}
