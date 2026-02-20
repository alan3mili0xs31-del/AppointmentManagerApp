using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocumentada.Dominio.AppointmentUseCases
{
    public class CreateAppointmentUseCase
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public CreateAppointmentUseCase(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public Guid Execute(string title, string description, DateTime dueDate)
        {
            var newAppointment = new Appointment(title, description, dueDate);
            return _appointmentRepo.Save(newAppointment);
        }
    }
}
