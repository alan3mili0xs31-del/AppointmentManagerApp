using AppointmentUI.Interfaces;
using BusinessLogic.Entities;
using BusinessLogic.UseCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentUI
{
    public partial class AppointmentCreator : Form, ILoadAppointmentDetails
    {
        private readonly CreateAppointmentUseCase _createAppointment;
        private readonly UpdateAppointmentUseCase _updateAppointment;
        public bool EditMode { get; private set; } = false;
        private Guid _selectedAppointmentId = Guid.Empty;

        public AppointmentCreator(
            CreateAppointmentUseCase createAppointmentUC,
            UpdateAppointmentUseCase updateAppointment)
        {
            _createAppointment = createAppointmentUC;
            _updateAppointment = updateAppointment;

            InitializeComponent();
        }

        public void ChangeToEditMode()
        {
            EditMode = true;
            BtnCreateAppointment.Text = "Submit Changes";
        }

        public void ChangeToCreateMode()
        {
            EditMode = false;
            BtnCreateAppointment.Text = "Create Appointment";
        }

        private void AppointmentCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void BtnCreateAppointment_Click(object sender, EventArgs e)
        {
            if (!EditMode)
                CreateAppointment();
            else
                EditAppointment();
        }

        private void EditAppointment()
        {
            try
            {
                string title = TxtbAppointmentTitle.Text.Trim();
                string description = RtbAppointmentDescription.Text.Trim();
                DateTime dueDate = DtpAppointmentDueDate.Value;

                _updateAppointment.Execute(_selectedAppointmentId, title, description, dueDate);
                MessageBox.Show("Appointment was updated successfully!");
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAppointment()
        {
            try
            {
                string title = TxtbAppointmentTitle.Text.Trim();
                string description = RtbAppointmentDescription.Text.Trim();
                DateTime dueDate = DtpAppointmentDueDate.Value;

                var newAppointmentId = _createAppointment.Execute(title, description, dueDate);
                MessageBox.Show($"New appointment with id <{newAppointmentId}> created!");
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CleanControls()
        {
            TxtbAppointmentTitle.Text = string.Empty;
            RtbAppointmentDescription.Text = string.Empty;
            DtpAppointmentDueDate.Value = DateTime.Now;
        }

        public void LoadAppointmentDetails(Appointment appointment)
        {
            _selectedAppointmentId = appointment.Id;
            TxtbAppointmentTitle.Text = appointment.Title;
            RtbAppointmentDescription.Text = appointment.Description;
            DtpAppointmentDueDate.Value = appointment.DueDate;
        }
    }
}
