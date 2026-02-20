using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocumentada.Dominio
{
    public class AppointmentFilter
    {
        public string? Title { get; set; }
        // public int? AppointmentStatus { get; set; }
        public bool IncludeCanceled { get; set; } = false;
        public bool IncludeCompleted { get; set; } = false;
    }
}
