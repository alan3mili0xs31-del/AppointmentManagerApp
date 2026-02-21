
namespace BusinessLogic.Entities
{
    public class AppointmentFilter
    {
        public string? Title { get; set; }
        // public int? AppointmentStatus { get; set; }
        public bool IncludeCanceled { get; set; } = false;
        public bool IncludeCompleted { get; set; } = false;
    }
}
