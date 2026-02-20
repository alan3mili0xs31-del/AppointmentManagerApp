using AppDocumentada.Dominio.AppointmentUseCases;
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
    public partial class AppointmentCreator : Form
    {
        private readonly CreateAppointmentUseCase _createAppointment;

        public AppointmentCreator(
            CreateAppointmentUseCase createAppointmentUC)
        {
            _createAppointment = createAppointmentUC;

            InitializeComponent();
        }

        private void AppointmentCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void BtnCreateAppointment_Click(object sender, EventArgs e)
        {
            CreateAppointment();
        }

        private void CreateAppointment()
        {
            try
            {
                string title = TxtbAppointmentTitle.Text.Trim();
                string description = RtbAppointmentDescription.Text.Trim();
                DateTime dueDate = DtpAppointmentDueDate.Value;

                _createAppointment.Execute(title, description, dueDate);

                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanControls()
        {
            TxtbAppointmentTitle.Text = string.Empty;
            RtbAppointmentDescription.Text = string.Empty;
            DtpAppointmentDueDate.Value = DateTime.Now;
        }
    }
}
