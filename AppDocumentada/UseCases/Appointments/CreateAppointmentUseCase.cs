using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases.Appointments
{
    public class CreateAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public CreateAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public Guid Execute(string title, string description, DateTime dueDate, Guid userId)
        {
            var newAppointment = new Appointment(title, description, dueDate, userId);
            return _appointmentRepo.Save(newAppointment);
        }
    }
}
