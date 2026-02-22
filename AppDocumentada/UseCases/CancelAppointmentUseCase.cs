using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases
{
    public class CancelAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public CancelAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        /// <summary>
        /// Change pending status from pending to canceled.
        /// </summary>
        public bool Execute(Guid id)
        {
            var appointment = new FindAppointmentUseCase(_appointmentRepo).Execute(id);
            appointment.SetStatusToCanceled();
            return _appointmentRepo.Update(appointment);
        }
    }
}
