using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases.Appointments
{
    public class GetAppointmentsByUserIdUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public GetAppointmentsByUserIdUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public List<Appointment> Execute(Guid userId, string? title = null, int? appointmentStatus = null)
        {
            var parameters = new AppointmentFilter()
            {
                Title = title,
                AppointmentStatus = appointmentStatus
            };
            return _appointmentRepo.GetByUserId(userId, parameters);
        }
    }
}
