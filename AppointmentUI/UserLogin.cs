using BusinessLogic.UseCases.Appointments;
using BusinessLogic.UseCases.Users;

namespace AppointmentUI
{
    public partial class UserLogin : Form
    {
        private readonly AppointmentDashboard _appointmentDashboard;
        private readonly LogInUseCase _logIn;

        public UserLogin(
            LogInUseCase loginUC,
            GetAppointmentsByUserIdUseCase getAppointmentsUC,
            CreateAppointmentUseCase createAppointmentUC,
            CompleteAppointmentUseCase completeAppointmentUC,
            CancelAppointmentUseCase cancelAppointmentUC,
            UpdateAppointmentUseCase updateAppointment,
            GetAppointmentStatusUseCase getAppointmentStatus
            )
        {
            _logIn = loginUC;
            _appointmentDashboard = new AppointmentDashboard(
                    getAppointmentsUC,
                    createAppointmentUC,
                    completeAppointmentUC,
                    cancelAppointmentUC,
                    updateAppointment,
                    getAppointmentStatus
                );
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {
            try
            {
                string userName = TxtbUserName.Text.Trim();
                string password = TxtbPassword.Text.Trim();

                var token = _logIn.Execute(userName, password);

                this.Hide();

                _appointmentDashboard.SessionClosed += AppointmentDashboard_SessionClosed;
                _appointmentDashboard.LoadUserInfoIntoForm(token);
                _appointmentDashboard.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AppointmentDashboard_SessionClosed()
        {
            _appointmentDashboard.SessionClosed -= AppointmentDashboard_SessionClosed;
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
