using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocumentada.Dominio.AppointmentUseCases
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
