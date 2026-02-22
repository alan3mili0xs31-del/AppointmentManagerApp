using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class AppointmentStatus
    {
        public int Id { get; private set; }
        public string StatusName { get; private set; }

        public AppointmentStatus(int id, string statusName)
        {
            Id = id;
            StatusName = statusName;
        }
    }
}
