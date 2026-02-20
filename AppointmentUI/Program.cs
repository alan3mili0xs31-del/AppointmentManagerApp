using AppDocumentada.Dominio.AppointmentUseCases;
using AppDocumentada.Persistencia;

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
            var getAppointmentsUC = new GetAppointmentsUseCase(appointmentMemoryRepo);
            var createAppointmentUC = new CreateAppointmentUseCase(appointmentMemoryRepo);
            var completeAppointmentUC = new CompleteAppointmentUseCase(appointmentMemoryRepo);
            var cancelAppointmentUC = new CancelAppointmentUseCase(appointmentMemoryRepo);

            Application.Run(
                new AppointmentDashboard(
                    getAppointmentsUC, 
                    createAppointmentUC, 
                    completeAppointmentUC, 
                    cancelAppointmentUC
                )
            );
        }
    }
}