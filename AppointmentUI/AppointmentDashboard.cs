using AppDocumentada.Dominio.AppointmentUseCases;
using AppointmentUI.Interfaces;
using AppDocumentada.Dominio;

namespace AppointmentUI
{
    public partial class AppointmentDashboard : Form
    {
        private readonly AppointmentCreator _appointmentCreator;
        private readonly AppointmentViewer _appointmentViewer;
        private readonly GetAppointmentsUseCase _getAppointments;
        private readonly CompleteAppointmentUseCase _completeAppointment;
        private readonly CancelAppointmentUseCase _cancelAppointment;
        private bool _includeCompletedAppointments = false;
        private bool _includeCanceledAppointments = false;

        public AppointmentDashboard(
            GetAppointmentsUseCase getAppointmentUC,
            CreateAppointmentUseCase createAppointmentUC,
            CompleteAppointmentUseCase completeAppointmentUC,
            CancelAppointmentUseCase cancelAppointmentUC,
            UpdateAppointmentUseCase updateAppointment
            )
        {
            _appointmentCreator = new AppointmentCreator(createAppointmentUC, updateAppointment);
            _appointmentViewer = new AppointmentViewer();
            _getAppointments = getAppointmentUC;
            _completeAppointment = completeAppointmentUC;
            _cancelAppointment = cancelAppointmentUC;

            InitializeComponent();
        }

        private void AppointmentDashboard_Load(object sender, EventArgs e)
        {
            LoadAppointmentsIntoList();
            LockAppointmentSelectedButtons();
        }

        private void LoadAppointmentsIntoList(List<Appointment>? appointments = null)
        {
            try
            {
                LbAppointments.DataSource = null;
                LbAppointments.DataSource = appointments ?? _getAppointments.Execute(
                    includeCanceled: _includeCanceledAppointments,
                    includeCompleted: _includeCompletedAppointments);
                LbAppointments.DisplayMember = "title";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowAppointmentDetails_Click(object sender, EventArgs e)
        {
            ActivateAppointmentViewer();
        }

        private void BtnCreateAppointment_Click(object sender, EventArgs e)
        {
            ActivateAppointmentCreator();
        }

        private void ActivateAppointmentCreator()
        {
            try
            {
                _appointmentCreator.ChangeToCreateMode();
                _appointmentCreator.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AppointmentDashboard_Activated(object sender, EventArgs e)
        {
            LoadAppointmentsIntoList();
        }

        private Appointment GetSelectedAppointmentFromList()
        {
            if (LbAppointments.SelectedValue is not Appointment appointment)
                throw new Exception("The appointment could not be loaded.");
            return appointment;
        }

        private void ActivateAppointmentViewer()
        {
            try
            {
                var appointment = GetSelectedAppointmentFromList();
                _appointmentViewer.LoadAppointmentDetails(appointment);
                _appointmentViewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCompleteAppointment_Click(object sender, EventArgs e)
        {
            CompleteSelectedAppointmen();
        }

        private void CompleteSelectedAppointmen()
        {
            try
            {
                var appointment = GetSelectedAppointmentFromList();
                _completeAppointment.Execute(appointment.Id);
                LoadAppointmentsIntoList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelAppointment_Click(object sender, EventArgs e)
        {
            CancelSelectedAppointment();
        }

        private void CancelSelectedAppointment()
        {
            try
            {
                var appointment = GetSelectedAppointmentFromList();
                _cancelAppointment.Execute(appointment.Id);
                LoadAppointmentsIntoList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LbAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbAppointments.SelectedIndex > -1)
                UnlockAppointmetSelectedButtons();
            else
                LockAppointmentSelectedButtons();
        }

        private void LockAppointmentSelectedButtons()
        {
            BtnEditAppointment.Enabled = false;
            BtnShowAppointmentDetails.Enabled = false;
            BtnCompleteAppointment.Enabled = false;
            BtnCancelAppointment.Enabled = false;
        }

        private void UnlockAppointmetSelectedButtons()
        {
            BtnEditAppointment.Enabled = true;
            BtnShowAppointmentDetails.Enabled = true;
            BtnCompleteAppointment.Enabled = true;
            BtnCancelAppointment.Enabled = true;
        }

        private void ChkbShowPendingOnly_CheckedChanged(object sender, EventArgs e)
        {
            _includeCanceledAppointments = !ChkbShowPendingOnly.Checked;
            _includeCompletedAppointments = !ChkbShowPendingOnly.Checked;
            LoadAppointmentsIntoList();
        }

        private void BtnEditAppointment_Click(object sender, EventArgs e)
        {
            EditSelectedAppointment();
        }

        private void EditSelectedAppointment()
        {
            try
            {
                _appointmentCreator.ChangeToEditMode();
                var appointment = GetSelectedAppointmentFromList();
                _appointmentCreator.LoadAppointmentDetails(appointment);
                _appointmentCreator.Show();
                _appointmentCreator.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
