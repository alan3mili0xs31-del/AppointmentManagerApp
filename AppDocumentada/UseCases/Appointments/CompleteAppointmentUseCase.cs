using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases.Appointments
{
    public class CompleteAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public CompleteAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        /// <summary>
        /// Change pending status from pending to completed.
        /// </summary>
        public bool Execute(Guid id)
        {
            var appointment = new FindAppointmentUseCase(_appointmentRepo).Execute(id);
            appointment.SetStatusToCompleted();
            return _appointmentRepo.Update(appointment);
        }
    }
}
