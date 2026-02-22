using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases
{
    public class GetAllAppointmentsUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public GetAllAppointmentsUseCase(IAppointmentRepository appointmentRepo)
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
