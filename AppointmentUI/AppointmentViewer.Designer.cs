namespace AppointmentUI
{
    partial class AppointmentViewer
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
            LblAppointmentCreationDate = new Label();
            label6 = new Label();
            LblAppointmentDueDate = new Label();
            label5 = new Label();
            LblAppointmentStatus = new Label();
            label4 = new Label();
            RtbAppointmentDescription = new RichTextBox();
            label2 = new Label();
            LblAppointmentTitle = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAppointmentCreationDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(LblAppointmentDueDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(LblAppointmentStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(RtbAppointmentDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LblAppointmentTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 547);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Appointment Details";
            // 
            // LblAppointmentCreationDate
            // 
            LblAppointmentCreationDate.AutoSize = true;
            LblAppointmentCreationDate.Location = new Point(298, 438);
            LblAppointmentCreationDate.Name = "LblAppointmentCreationDate";
            LblAppointmentCreationDate.Size = new Size(84, 28);
            LblAppointmentCreationDate.TabIndex = 9;
            LblAppointmentCreationDate.Text = "<none>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 438);
            label6.Name = "label6";
            label6.Size = new Size(258, 28);
            label6.TabIndex = 8;
            label6.Text = "Appointment Creation Date:";
            // 
            // LblAppointmentDueDate
            // 
            LblAppointmentDueDate.AutoSize = true;
            LblAppointmentDueDate.Location = new Point(264, 110);
            LblAppointmentDueDate.Name = "LblAppointmentDueDate";
            LblAppointmentDueDate.Size = new Size(84, 28);
            LblAppointmentDueDate.TabIndex = 7;
            LblAppointmentDueDate.Text = "<none>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 110);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 6;
            label5.Text = "Appointment Due Date:";
            // 
            // LblAppointmentStatus
            // 
            LblAppointmentStatus.AutoSize = true;
            LblAppointmentStatus.Location = new Point(238, 486);
            LblAppointmentStatus.Name = "LblAppointmentStatus";
            LblAppointmentStatus.Size = new Size(84, 28);
            LblAppointmentStatus.TabIndex = 5;
            LblAppointmentStatus.Text = "<none>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 486);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 4;
            label4.Text = "Appointment Status:";
            // 
            // RtbAppointmentDescription
            // 
            RtbAppointmentDescription.BorderStyle = BorderStyle.FixedSingle;
            RtbAppointmentDescription.Location = new Point(34, 204);
            RtbAppointmentDescription.Name = "RtbAppointmentDescription";
            RtbAppointmentDescription.ReadOnly = true;
            RtbAppointmentDescription.Size = new Size(467, 190);
            RtbAppointmentDescription.TabIndex = 3;
            RtbAppointmentDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 162);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 2;
            label2.Text = "Appointment Description:";
            // 
            // LblAppointmentTitle
            // 
            LblAppointmentTitle.AutoSize = true;
            LblAppointmentTitle.Location = new Point(224, 56);
            LblAppointmentTitle.Name = "LblAppointmentTitle";
            LblAppointmentTitle.Size = new Size(84, 28);
            LblAppointmentTitle.TabIndex = 1;
            LblAppointmentTitle.Text = "<none>";
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
            // AppointmentViewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 571);
            Controls.Add(groupBox1);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AppointmentViewer";
            Text = "Appointment Viewer";
            FormClosing += AppointmentViewer_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAppointmentTitle;
        private Label label1;
        private Label LblAppointmentStatus;
        private Label label4;
        private RichTextBox RtbAppointmentDescription;
        private Label label2;
        private Label LblAppointmentDueDate;
        private Label label5;
        private Label LblAppointmentCreationDate;
        private Label label6;
    }
}