using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases.Appointments
{
    public class UpdateAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public UpdateAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public bool Execute(Guid id, string title, string description, DateTime dueDate)
        {
            var appointmet = new FindAppointmentUseCase(_appointmentRepo).Execute(id);
            appointmet.ChangeTitle(title);
            appointmet.ChangeDescription(description);
            appointmet.ChangeDueDate(dueDate);
            return _appointmentRepo.Update(appointmet);
        }
    }
}
