using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocumentada.Dominio.AppointmentUseCases
{
    public class CancelAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public CancelAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public bool Execute(Guid id)
        {
            var appointment = new FindAppointmentUseCase(_appointmentRepo).Execute(id);
            appointment.SetStatusToCanceled();
            return _appointmentRepo.Update(appointment);
        }
    }
}
