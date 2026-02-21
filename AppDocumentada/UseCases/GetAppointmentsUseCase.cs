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

        public List<Appointment> Execute(string? title = null, 
            bool includeCanceled = false, 
            bool includeCompleted = false)
        {
            var parameters = new AppointmentFilter()
            {
                Title = title,
                IncludeCanceled = includeCanceled,
                IncludeCompleted = includeCompleted
            };
            return _appointmentRepo.GetAll(parameters);
        }
    }
}
