using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using Persistence.DataAcces.SQLServer;
using System.Data;

namespace Persistence.Repositories
{
    public class AppointmentDBRepo : IAppointmentRepository
    {
        private readonly SQLServerQueryManager _queryManager;

        public AppointmentDBRepo(SQLServerQueryManager queryManager)
        {
            _queryManager = queryManager;
        }

        public bool Delete(Guid id)
        {
            var result = _queryManager.ExecuteNonQuerySP("spDeleteAppointmentById", (command) =>
            {
                command.Parameters.Add("@p_id_appointment", SqlDbType.UniqueIdentifier).Value = id;
            });

            return result;
        }

        public List<Appointment> GetAll(AppointmentFilter parameters)
        {
            var appointments = _queryManager.ExecuteQuerySP("spGetAppointments", (command) =>
            {
                if (parameters.Title != null) 
                    command.Parameters.Add("@p_title", SqlDbType.NVarChar).Value = parameters.Title;
                if (parameters.IncludeCompleted)
                    command.Parameters.Add("@p_include_completed", SqlDbType.Int).Value = 1;
                if (parameters.IncludeCanceled)
                    command.Parameters.Add("@p_include_canceled", SqlDbType.Int).Value = 1;
            });

            return MapTableToAppointmentsList(appointments);
        }

        public Appointment? GetById(Guid id)
        {
            var appointments = _queryManager.ExecuteQuerySP("spGetAppointmentById", (command) =>
            {
                command.Parameters.Add("@p_id_appointment", SqlDbType.UniqueIdentifier).Value = id;
            });

            return appointments.Rows.Count > 0 ? MapRowToAppointment(appointments.Rows[0]) : null;
        }

        public Guid Save(Appointment appointment)
        {
            var idGenerado = _queryManager.ExecuteScalarSP("spInsertAppointment", (command) =>
            {
                command.Parameters.Add("@p_id_appointment", SqlDbType.UniqueIdentifier).Value = appointment.Id;
                command.Parameters.Add("@p_title", SqlDbType.NVarChar).Value = appointment.Title;
                command.Parameters.Add("@p_description", SqlDbType.NVarChar).Value = appointment.Description;
                command.Parameters.Add("@p_due_date", SqlDbType.DateTime2).Value = appointment.DueDate;
            });

            return idGenerado;
        }

        public bool Update(Appointment appointment)
        {
            var result = _queryManager.ExecuteNonQuerySP("spUpdateAppointment", (command) =>
            {
                command.Parameters.Add("@p_id_appointment", SqlDbType.UniqueIdentifier).Value = appointment.Id;
                command.Parameters.Add("@p_title", SqlDbType.NVarChar).Value = appointment.Title;
                command.Parameters.Add("@p_description", SqlDbType.NVarChar).Value = appointment.Description;
                command.Parameters.Add("@p_due_date", SqlDbType.DateTime2).Value = appointment.DueDate;
                command.Parameters.Add("@p_id_appointment_status", SqlDbType.Int).Value = appointment.AppointmentStatus;
            });

            return result;
        }

        private Appointment MapRowToAppointment(DataRow row)
        {
            Guid id = Guid.Parse(row["id_appointment"].ToString() ?? string.Empty);
            string title = row["title"].ToString() ?? string.Empty;
            string description = row["description"].ToString() ?? string.Empty;
            DateTime dueDate = DateTime.Parse(row["due_date"].ToString() ?? string.Empty);
            int appointmentStatus = Convert.ToInt32(row["id_appointment_status"]);

            return new Appointment(id, title, description, dueDate, appointmentStatus);
        }

        private List<Appointment> MapTableToAppointmentsList(DataTable table)
        {
            var appointments = new List<Appointment>();
            foreach (DataRow row in table.Rows)
                appointments.Add(MapRowToAppointment(row));
            return appointments;
        }
    }
}
