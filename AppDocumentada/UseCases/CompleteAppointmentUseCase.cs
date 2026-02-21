using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases
{
    public class CompleteAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public CompleteAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public bool Execute(Guid id)
        {
            var appointment = new FindAppointmentUseCase(_appointmentRepo).Execute(id);
            appointment.SetStatusToCompleted();
            return _appointmentRepo.Update(appointment);
        }
    }
}
