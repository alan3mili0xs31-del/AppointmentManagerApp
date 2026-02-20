namespace AppointmentUI
{
    partial class AppointmentCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            DtpAppointmentDueDate = new DateTimePicker();
            TxtbAppointmentTitle = new TextBox();
            label5 = new Label();
            RtbAppointmentDescription = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            BtnCreateAppointment = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnCreateAppointment);
            groupBox1.Controls.Add(DtpAppointmentDueDate);
            groupBox1.Controls.Add(TxtbAppointmentTitle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(RtbAppointmentDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 531);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment Entry Data";
            // 
            // DtpAppointmentDueDate
            // 
            DtpAppointmentDueDate.CustomFormat = "dd/MM/yyyy";
            DtpAppointmentDueDate.Format = DateTimePickerFormat.Custom;
            DtpAppointmentDueDate.Location = new Point(262, 376);
            DtpAppointmentDueDate.Name = "DtpAppointmentDueDate";
            DtpAppointmentDueDate.Size = new Size(162, 34);
            DtpAppointmentDueDate.TabIndex = 9;
            // 
            // TxtbAppointmentTitle
            // 
            TxtbAppointmentTitle.Location = new Point(215, 56);
            TxtbAppointmentTitle.Name = "TxtbAppointmentTitle";
            TxtbAppointmentTitle.Size = new Size(325, 34);
            TxtbAppointmentTitle.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 377);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 6;
            label5.Text = "Appointment Due Date:";
            // 
            // RtbAppointmentDescription
            // 
            RtbAppointmentDescription.BorderStyle = BorderStyle.FixedSingle;
            RtbAppointmentDescription.Location = new Point(34, 154);
            RtbAppointmentDescription.Name = "RtbAppointmentDescription";
            RtbAppointmentDescription.Size = new Size(506, 190);
            RtbAppointmentDescription.TabIndex = 3;
            RtbAppointmentDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 110);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 2;
            label2.Text = "Appointment Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 56);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Appointment Title:";
            // 
            // BtnCreateAppointment
            // 
            BtnCreateAppointment.Location = new Point(185, 437);
            BtnCreateAppointment.Name = "BtnCreateAppointment";
            BtnCreateAppointment.Size = new Size(215, 61);
            BtnCreateAppointment.TabIndex = 10;
            BtnCreateAppointment.Text = "Create Appointment";
            BtnCreateAppointment.UseVisualStyleBackColor = true;
            BtnCreateAppointment.Click += BtnCreateAppointment_Click;
            // 
            // AppointmentCreator
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 555);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AppointmentCreator";
            Text = "Appointment Creator";
            FormClosing += AppointmentCreator_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtbAppointmentTitle;
        private Label label5;
        private RichTextBox RtbAppointmentDescription;
        private Label label2;
        private Label label1;
        private DateTimePicker DtpAppointmentDueDate;
        private Button BtnCreateAppointment;
    }
}