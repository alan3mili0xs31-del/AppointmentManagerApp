namespace AppointmentUI
{
    partial class AppointmentDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BtnShowAppointmentDetails = new Button();
            BtnCancelAppointment = new Button();
            BtnCompleteAppointment = new Button();
            BtnCreateAppointment = new Button();
            LbAppointments = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnShowAppointmentDetails);
            groupBox1.Controls.Add(BtnCancelAppointment);
            groupBox1.Controls.Add(BtnCompleteAppointment);
            groupBox1.Controls.Add(BtnCreateAppointment);
            groupBox1.Controls.Add(LbAppointments);
            groupBox1.Location = new Point(29, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointments";
            // 
            // BtnShowAppointmentDetails
            // 
            BtnShowAppointmentDetails.Location = new Point(523, 83);
            BtnShowAppointmentDetails.Name = "BtnShowAppointmentDetails";
            BtnShowAppointmentDetails.Size = new Size(244, 61);
            BtnShowAppointmentDetails.TabIndex = 5;
            BtnShowAppointmentDetails.Text = "Show Selected's Details";
            BtnShowAppointmentDetails.UseVisualStyleBackColor = true;
            BtnShowAppointmentDetails.Click += BtnShowAppointmentDetails_Click;
            // 
            // BtnCancelAppointment
            // 
            BtnCancelAppointment.Location = new Point(523, 217);
            BtnCancelAppointment.Name = "BtnCancelAppointment";
            BtnCancelAppointment.Size = new Size(244, 61);
            BtnCancelAppointment.TabIndex = 3;
            BtnCancelAppointment.Text = "Cancel Selected";
            BtnCancelAppointment.UseVisualStyleBackColor = true;
            BtnCancelAppointment.Click += BtnCancelAppointment_Click;
            // 
            // BtnCompleteAppointment
            // 
            BtnCompleteAppointment.Location = new Point(523, 150);
            BtnCompleteAppointment.Name = "BtnCompleteAppointment";
            BtnCompleteAppointment.Size = new Size(244, 61);
            BtnCompleteAppointment.TabIndex = 2;
            BtnCompleteAppointment.Text = "Complete Selected";
            BtnCompleteAppointment.UseVisualStyleBackColor = true;
            BtnCompleteAppointment.Click += BtnCompleteAppointment_Click;
            // 
            // BtnCreateAppointment
            // 
            BtnCreateAppointment.Location = new Point(148, 326);
            BtnCreateAppointment.Name = "BtnCreateAppointment";
            BtnCreateAppointment.Size = new Size(215, 61);
            BtnCreateAppointment.TabIndex = 1;
            BtnCreateAppointment.Text = "Create Appointment";
            BtnCreateAppointment.UseVisualStyleBackColor = true;
            BtnCreateAppointment.Click += BtnCreateAppointment_Click;
            // 
            // LbAppointments
            // 
            LbAppointments.FormattingEnabled = true;
            LbAppointments.ItemHeight = 28;
            LbAppointments.Location = new Point(33, 62);
            LbAppointments.Name = "LbAppointments";
            LbAppointments.Size = new Size(439, 228);
            LbAppointments.TabIndex = 0;
            LbAppointments.SelectedIndexChanged += LbAppointments_SelectedIndexChanged;
            // 
            // AppointmentDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 451);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AppointmentDashboard";
            Text = "Appointment Dashboard";
            Activated += AppointmentDashboard_Activated;
            Load += AppointmentDashboard_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCreateAppointment;
        private ListBox LbAppointments;
        private Button BtnShowAppointmentDetails;
        private Button BtnCancelAppointment;
        private Button BtnCompleteAppointment;
    }
}
