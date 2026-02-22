using System.Text.RegularExpressions;

namespace BusinessLogic.Entities
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public Guid UserId { get; private set; }
        public int AppointmentStatus { get; private set; }
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// This constructor is used for persisting data for Appointment model.
        /// Id and AppointmentStatus will automaticly inicialized.
        /// </summary>
        /// <param name="title">
        /// Represents the appointment's title
        /// </param>
        /// <param name="description">
        /// Represents details describing what the appointment is about.
        /// </param>
        /// <param name="dueDate">
        /// Represent the date scheduled for the appointment to be done.
        /// </param>
        public Appointment(
            string title, 
            string description, 
            DateTime dueDate,
            Guid userId)
        {
            IsValidData(title, description, dueDate);

            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            DueDate = dueDate;
            UserId = userId;
            CreationDate = DateTime.Now;
            AppointmentStatus = 1;
        }

        /// <summary>
        /// This constructor acts as a DTO for Appointment model,
        /// it'll be only used when retrieving data from persistance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="dueDate"></param>
        /// <param name="appointmentStatus"></param>
        public Appointment(
            Guid id,
            string title,
            string description,
            DateTime dueDate,
            Guid userId,
            int appointmentStatus,
            DateTime creationDate)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            UserId = userId;
            AppointmentStatus = appointmentStatus;
            CreationDate = creationDate;
        }

        public void ChangeTitle(string title)
        {
            CanBeUpdated();
            IsValidTitle(title);
            Title = title;
        }

        public void ChangeDescription(string description)
        {
            CanBeUpdated();
            IsValidDescription(description);
            Description = description;
        }

        public void ChangeDueDate(DateTime dueDate)
        {
            CanBeUpdated();
            IsValidDueDate(dueDate);
            DueDate = dueDate;
        }

        private void CanBeUpdated()
        {
            if (AppointmentStatus != 1)
                throw new InvalidDataException("Appointment cannot be modified since it's already canceled or finished.");
        }

        private void IsValidData(string title, string description, DateTime dueDate)
        {
            IsValidTitle(title);
            IsValidDescription(description);
            IsValidDueDate(dueDate);
        }

        public void SetStatusToCanceled()
        {
            if (AppointmentStatus != 1)
                throw new InvalidDataException("Appointment cannot be set as canceled since it's already canceled or finished.");
            AppointmentStatus = 3;
        }

        public void SetStatusToCompleted()
        {
            if (AppointmentStatus != 1)
                throw new InvalidDataException("Appointment cannot be set as completed since it's already canceled or finished.");
            AppointmentStatus = 2;
        }

        private void IsValidDueDate(DateTime dueDate)
        {
            if (dueDate <= DateTime.Now)
                throw new ArgumentException("Value entered for appointment's due date cannot be earlier than current time.");
            if (dueDate > DateTime.Now.AddMonths(1))
                throw new ArgumentException("Value entered for appointment's due date cannot be later than 1 month.");
        }

        private void IsValidDescription(string description)
        {
            string pattern = @"^[\w.\'\,\-_0-9 ]{5,200}$";
            if (!Regex.IsMatch(description, pattern))
                throw new ArgumentException("Value entered for appointment's description is not valid.");
        }

        private void IsValidTitle(string title)
        {
            string pattern = @"^[\w.\'\,\-_0-9 ]{5,100}$";
            if (!Regex.IsMatch(title, pattern))
                throw new ArgumentException("Value entered for appointment's title is not valid.");
        }
    }
}
