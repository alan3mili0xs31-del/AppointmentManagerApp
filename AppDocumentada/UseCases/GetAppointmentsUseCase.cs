using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases
{
    public class GetAppointmentsUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public GetAppointmentsUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public List<Appointment> Execute(string? title = null, int? appointmentStatus = null)
        {
            var parameters = new AppointmentFilter()
            {
                Title = title,
                AppointmentStatus = appointmentStatus
            };
            return _appointmentRepo.GetAll(parameters);
        }
    }
}
