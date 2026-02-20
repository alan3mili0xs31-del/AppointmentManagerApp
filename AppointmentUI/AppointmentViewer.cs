using AppDocumentada.Dominio;
using AppointmentUI.Interfaces;
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
        public AppointmentViewer()
        {
            InitializeComponent();
        }

        public void LoadAppointmentDetails(Appointment appointment)
        {
            LblAppointmentTitle.Text = appointment.Title;
            RtbAppointmentDescription.Text = appointment.Description;
            LblAppointmentDueDate.Text = appointment.DueDate.ToString();
            int appointmentStatus = appointment.AppointmentStatus; 
            LblAppointmentStatus.Text = 
                appointmentStatus == 1 ? "Pending" 
                : appointmentStatus == 2 ? "Completed" 
                : "Canceled";
        }

        private void AppointmentViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void AppointmentViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
