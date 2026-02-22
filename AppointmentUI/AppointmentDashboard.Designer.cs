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
            label2 = new Label();
            label1 = new Label();
            CmbAppointmentStatus = new ComboBox();
            BtnEditAppointment = new Button();
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
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CmbAppointmentStatus);
            groupBox1.Controls.Add(BtnEditAppointment);
            groupBox1.Controls.Add(BtnShowAppointmentDetails);
            groupBox1.Controls.Add(BtnCancelAppointment);
            groupBox1.Controls.Add(BtnCompleteAppointment);
            groupBox1.Controls.Add(BtnCreateAppointment);
            groupBox1.Controls.Add(LbAppointments);
            groupBox1.Location = new Point(29, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 517);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 371);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 10;
            label2.Text = "Only";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 371);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 9;
            label1.Text = "Show";
            // 
            // CmbAppointmentStatus
            // 
            CmbAppointmentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAppointmentStatus.Location = new Point(187, 368);
            CmbAppointmentStatus.Name = "CmbAppointmentStatus";
            CmbAppointmentStatus.Size = new Size(120, 36);
            CmbAppointmentStatus.TabIndex = 8;
            CmbAppointmentStatus.SelectedIndexChanged += CmbAppointmentStatus_SelectedIndexChanged;
            // 
            // BtnEditAppointment
            // 
            BtnEditAppointment.Location = new Point(506, 88);
            BtnEditAppointment.Name = "BtnEditAppointment";
            BtnEditAppointment.Size = new Size(244, 61);
            BtnEditAppointment.TabIndex = 6;
            BtnEditAppointment.Text = "Edit Selected";
            BtnEditAppointment.UseVisualStyleBackColor = true;
            BtnEditAppointment.Click += BtnEditAppointment_Click;
            // 
            // BtnShowAppointmentDetails
            // 
            BtnShowAppointmentDetails.Location = new Point(506, 155);
            BtnShowAppointmentDetails.Name = "BtnShowAppointmentDetails";
            BtnShowAppointmentDetails.Size = new Size(244, 61);
            BtnShowAppointmentDetails.TabIndex = 5;
            BtnShowAppointmentDetails.Text = "Show Selected's Details";
            BtnShowAppointmentDetails.UseVisualStyleBackColor = true;
            BtnShowAppointmentDetails.Click += BtnShowAppointmentDetails_Click;
            // 
            // BtnCancelAppointment
            // 
            BtnCancelAppointment.Location = new Point(506, 289);
            BtnCancelAppointment.Name = "BtnCancelAppointment";
            BtnCancelAppointment.Size = new Size(244, 61);
            BtnCancelAppointment.TabIndex = 3;
            BtnCancelAppointment.Text = "Cancel Selected";
            BtnCancelAppointment.UseVisualStyleBackColor = true;
            BtnCancelAppointment.Click += BtnCancelAppointment_Click;
            // 
            // BtnCompleteAppointment
            // 
            BtnCompleteAppointment.Location = new Point(506, 222);
            BtnCompleteAppointment.Name = "BtnCompleteAppointment";
            BtnCompleteAppointment.Size = new Size(244, 61);
            BtnCompleteAppointment.TabIndex = 2;
            BtnCompleteAppointment.Text = "Complete Selected";
            BtnCompleteAppointment.UseVisualStyleBackColor = true;
            BtnCompleteAppointment.Click += BtnCompleteAppointment_Click;
            // 
            // BtnCreateAppointment
            // 
            BtnCreateAppointment.Location = new Point(137, 432);
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
            LbAppointments.Size = new Size(439, 284);
            LbAppointments.TabIndex = 0;
            LbAppointments.SelectedIndexChanged += LbAppointments_SelectedIndexChanged;
            // 
            // AppointmentDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 553);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AppointmentDashboard";
            Text = "Appointment Dashboard";
            Load += AppointmentDashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCreateAppointment;
        private ListBox LbAppointments;
        private Button BtnShowAppointmentDetails;
        private Button BtnCancelAppointment;
        private Button BtnCompleteAppointment;
        private Button BtnEditAppointment;
        private Label label2;
        private Label label1;
        private ComboBox CmbAppointmentStatus;
    }
}
