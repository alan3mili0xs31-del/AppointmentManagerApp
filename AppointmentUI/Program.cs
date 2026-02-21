using BusinessLogic.UseCases;
using Persistence.DataAcces.SQLServer;
using Persistence.Repositories;

namespace AppointmentUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var appointmentMemoryRepo = new AppointmentMemoryRepo();

            string connString = @"Data Source=EMILIA-TOSCANO\SQLEXPRESS2025;Persist Security Info=False;User ID=appointment_app;Password=genshin456;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""SQL Server Management Studio"";Command Timeout=0";
            var sqlDbConnection = new SqlDbConnection(connString);
            var sqlServerQueryManager = new SQLServerQueryManager(sqlDbConnection);
            var appointmentDBRepo = new AppointmentDBRepo(sqlServerQueryManager);

            /*
            var getAppointmentsUC = new GetAppointmentsUseCase(appointmentMemoryRepo);
            var createAppointmentUC = new CreateAppointmentUseCase(appointmentMemoryRepo);
            var completeAppointmentUC = new CompleteAppointmentUseCase(appointmentMemoryRepo);
            var cancelAppointmentUC = new CancelAppointmentUseCase(appointmentMemoryRepo);
            var updateAppointment = new UpdateAppointmentUseCase(appointmentMemoryRepo);
            */
            var getAppointmentsUC = new GetAppointmentsUseCase(appointmentDBRepo);
            var createAppointmentUC = new CreateAppointmentUseCase(appointmentDBRepo);
            var completeAppointmentUC = new CompleteAppointmentUseCase(appointmentDBRepo);
            var cancelAppointmentUC = new CancelAppointmentUseCase(appointmentDBRepo);
            var updateAppointment = new UpdateAppointmentUseCase(appointmentDBRepo);

            Application.Run(
                new AppointmentDashboard(
                    getAppointmentsUC, 
                    createAppointmentUC, 
                    completeAppointmentUC, 
                    cancelAppointmentUC,
                    updateAppointment
                )
            );
        }
    }
}