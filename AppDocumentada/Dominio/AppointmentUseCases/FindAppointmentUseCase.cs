using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocumentada.Dominio.AppointmentUseCases
{
    internal class FindAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public FindAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public Appointment Execute(Guid id)
        {
            return _appointmentRepo.GetById(id)
                ?? throw new KeyNotFoundException("Appointment not found with that id.");
        }
    }
}
