using AppointmentUI.Interfaces;
using BusinessLogic.Entities;
using BusinessLogic.UseCases;

namespace AppointmentUI
{
    public partial class AppointmentDashboard : Form
    {
        private readonly AppointmentCreator _appointmentCreator;
        private readonly AppointmentViewer _appointmentViewer;
        private readonly AppointmentCreator _appointmentEditor;
        private readonly GetAppointmentsUseCase _getAppointments;
        private readonly CompleteAppointmentUseCase _completeAppointment;
        private readonly CancelAppointmentUseCase _cancelAppointment;
        private readonly GetAppointmentStatusUseCase _getAppointmentStatus;

        public AppointmentDashboard(
            GetAppointmentsUseCase getAppointmentUC,
            CreateAppointmentUseCase createAppointmentUC,
            CompleteAppointmentUseCase completeAppointmentUC,
            CancelAppointmentUseCase cancelAppointmentUC,
            UpdateAppointmentUseCase updateAppointment,
            GetAppointmentStatusUseCase getAppointmentStatus
            )
        {
            _appointmentCreator = new AppointmentCreator(createAppointmentUC);
            _appointmentCreator.AppointmentDataSubmitted += Appointment_DataSubmitted;
            _appointmentEditor = new AppointmentCreator(updateAppointment);
            _appointmentEditor.AppointmentDataSubmitted += Appointment_DataSubmitted;

            _appointmentViewer = new AppointmentViewer(getAppointmentStatus);
            _getAppointments = getAppointmentUC;
            _completeAppointment = completeAppointmentUC;
            _cancelAppointment = cancelAppointmentUC;
           _getAppointmentStatus = getAppointmentStatus;

            InitializeComponent();

            
        }

        /// <summary>
        /// Refresh appointment list whenever new data is submitted.
        /// </summary>
        private void Appointment_DataSubmitted()
        {
            if (CmbAppointmentStatus.SelectedIndex != 0)
                CmbAppointmentStatus.SelectedIndex = 0;
            else 
                LoadAppointmentsIntoList();
        }

        private void AppointmentDashboard_Load(object sender, EventArgs e)
        {
            LoadAppointmentsIntoList();
            LoadAppointmentStatusIntoComboBox();
            LbAppointments.SelectedIndex = -1;
        }

        private void BtnCreateAppointment_Click(object sender, EventArgs e)
        {
            ActivateAppointmentCreator();
        }

        private void BtnEditAppointment_Click(object sender, EventArgs e)
        {
            EditSelectedAppointment();
        }

        private void BtnShowAppointmentDetails_Click(object sender, EventArgs e)
        {
            ActivateAppointmentViewer();
        }

        private void BtnCompleteAppointment_Click(object sender, EventArgs e)
        {
            CompleteSelectedAppointmen();
        }

        private void BtnCancelAppointment_Click(object sender, EventArgs e)
        {
            CancelSelectedAppointment();
        }

        private void LbAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbAppointments.SelectedIndex > -1 && CmbAppointmentStatus.SelectedIndex == 0)
            {
                AbleEditButtons(true);
                BtnShowAppointmentDetails.Enabled = true;
            }
            else if (LbAppointments.SelectedIndex > -1)
                BtnShowAppointmentDetails.Enabled = true;
            else
            {
                AbleEditButtons(false);
                BtnShowAppointmentDetails.Enabled = false;
            }
        }

        private void CmbAppointmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAppointmentsByStatus();
            AbleEditButtons(CmbAppointmentStatus.SelectedIndex == 0);
        }

        /// <summary>
        /// Able or unable cancel, complete and edit appointment's buttons.
        /// </summary>
        /// <param name="able">
        /// Send true to able them, false to unable.
        /// </param>
        private void AbleEditButtons(bool able)
        {
            BtnEditAppointment.Enabled = able;
            BtnCancelAppointment.Enabled = able;
            BtnCompleteAppointment.Enabled = able;
        }

        /// <summary>
        /// Gets appointments by the status provided at combo box status selector.
        /// </summary>
        private void FilterAppointmentsByStatus()
        {
            try
            {
                int appointmentStatusSelected = int.TryParse(CmbAppointmentStatus.SelectedValue?.ToString(), out int status) ? status : 1;
                var appointmentStatusList = _getAppointments.Execute(appointmentStatus: appointmentStatusSelected);
                LoadAppointmentsIntoList(appointmentStatusList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads status retrieved from db.
        /// </summary>
        private void LoadAppointmentStatusIntoComboBox()
        {
            try
            {
                CmbAppointmentStatus.DataSource = null;
                CmbAppointmentStatus.DataSource = _getAppointmentStatus.Execute();
                CmbAppointmentStatus.DisplayMember = "statusName";
                CmbAppointmentStatus.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads appointments into list. 
        /// Loads pending appointments if any specified appointments list is providen.
        /// </summary>
        /// <param name="appointments">
        /// List of appointments to be loaded into list.
        /// </param>
        private void LoadAppointmentsIntoList(List<Appointment>? appointments = null)
        {
            try
            {
                LbAppointments.DataSource = null;
                LbAppointments.DataSource = appointments ?? _getAppointments.Execute(appointmentStatus: 1);
                LbAppointments.DisplayMember = "title";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves and parses the Appointment from the list.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private Appointment GetSelectedAppointmentFromList()
        {
            if (LbAppointments.SelectedValue is not Appointment appointment)
                throw new Exception("The appointment could not be loaded.");
            return appointment;
        }

        /// <summary>
        /// Shows appointment creator form on screen.
        /// </summary>
        private void ActivateAppointmentCreator()
        {
            try
            {
                _appointmentCreator.CleanControls();
                _appointmentCreator.ChangeToCreateMode();
                _appointmentCreator.Show();
                _appointmentCreator.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Shows appointment viewer form on screen.
        /// </summary>
        private void ActivateAppointmentViewer()
        {
            try
            {
                var appointment = GetSelectedAppointmentFromList();
                _appointmentViewer.LoadAppointmentDetails(appointment);
                _appointmentViewer.Show();
                _appointmentViewer.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Shows appointment creator form on edit mode.
        /// </summary>
        private void EditSelectedAppointment()
        {
            try
            {
                _appointmentEditor.CleanControls();
                _appointmentEditor.ChangeToEditMode();
                var appointment = GetSelectedAppointmentFromList();
                _appointmentEditor.LoadAppointmentDetails(appointment);
                _appointmentEditor.Show();
                _appointmentEditor.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Use complete appointment use case to set appointment status as completed.
        /// </summary>
        private void CompleteSelectedAppointmen()
        {
            try
            {
                var appointment = GetSelectedAppointmentFromList();
                _completeAppointment.Execute(appointment.Id);
                MessageBox.Show("Appointment set as completed!");
                LoadAppointmentsIntoList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Use cancel appointment use case to set appointment status as canceled.
        /// </summary>
        private void CancelSelectedAppointment()
        {
            try
            {
                var appointment = GetSelectedAppointmentFromList();
                _cancelAppointment.Execute(appointment.Id);
                MessageBox.Show("Appointment set as canceled correctly!");
                LoadAppointmentsIntoList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


    }
}
