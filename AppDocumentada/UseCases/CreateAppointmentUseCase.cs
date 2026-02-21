using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases
{
    public class CreateAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public CreateAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public Guid Execute(string title, string description, DateTime dueDate)
        {
            var newAppointment = new Appointment(title, description, dueDate);
            return _appointmentRepo.Save(newAppointment);
        }
    }
}
