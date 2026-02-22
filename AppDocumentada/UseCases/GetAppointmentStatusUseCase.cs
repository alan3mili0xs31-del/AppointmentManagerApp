using BusinessLogic.Entities;
using BusinessLogic.Interfaces;

namespace BusinessLogic.UseCases
{
    public class GetAppointmentStatusUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public GetAppointmentStatusUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public List<AppointmentStatus> Execute()
        {
            return _appointmentRepo.GetAppointmentStatus();
        }
    }
}
