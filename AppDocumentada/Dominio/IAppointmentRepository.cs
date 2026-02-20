using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocumentada.Dominio
{
    public interface IAppointmentRepository
    {
        Guid Save(Appointment appointment);
        List<Appointment> GetAll(AppointmentFilter parameters);
        Appointment? GetById(Guid id);
        bool Update(Appointment appointment);
        bool Delete(Guid id);
    }
}
