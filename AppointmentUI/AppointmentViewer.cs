using AppointmentUI.Interfaces;
using BusinessLogic.Entities;
using BusinessLogic.UseCases.Appointments;
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
    public partial class AppointmentViewer : Form, ILoadAppointmentDetails
    {
        private readonly GetAppointmentStatusUseCase _getAppointmentStatus;
        private List<AppointmentStatus>? _appointmentStatus;

        public AppointmentViewer(GetAppointmentStatusUseCase getAppointmentStatus)
        {
            _getAppointmentStatus = getAppointmentStatus;
            InitializeComponent();
            LoadAppointmentStatus();
        }

        public void LoadAppointmentDetails(Appointment appointment)
        {
            LblAppointmentTitle.Text = appointment.Title;
            RtbAppointmentDescription.Text = appointment.Description;
            LblAppointmentDueDate.Text = appointment.DueDate.ToString();
            LblAppointmentStatus.Text = GetAppointmentStatusName(appointment.AppointmentStatus);
        }

        private void LoadAppointmentStatus()
        {
            try
            {
                _appointmentStatus = _getAppointmentStatus.Execute();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetAppointmentStatusName(int id)
        {
            return _appointmentStatus?.Find((status) => status.Id == id)?.StatusName 
                ?? "Not Specified";
        }

        private void AppointmentViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }


    }
}
