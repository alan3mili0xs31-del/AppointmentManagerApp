USE DBAppointmentsManager;

CREATE TABLE appointments (
	id_appointment UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NULL,
	title NVARCHAR(100) NOT NULL,
	description NVARCHAR(200) NOT NULL,
	due_date DATETIME2 NOT NULL,
	id_appointment_status INT NOT NULL DEFAULT 1,

	CONSTRAINT chk_due_date CHECK (due_date > GETDATE()),
	CONSTRAINT fk_appointment_status 
		FOREIGN KEY (id_appointment_status) 
		REFERENCES appointment_status(id_appointment_status)
);

CREATE TABLE appointment_status (
	id_appointment_status INT IDENTITY(1,1) PRIMARY KEY,
	status_name VARCHAR(50) NOT NULL
);

INSERT INTO appointment_status(status_name) VALUES
('pending'),('completed'),('canceled');

-- test
EXEC spInsertAppointment @p_id_appointment = '3F2504E0-4F89-11D3-9A0C-0305E82C3301', @p_title = 'HSAJFASJFSLD', @p_description = 'jjflasjflsfsjafjklfdjfafj', @p_due_date = '2026-12-12';