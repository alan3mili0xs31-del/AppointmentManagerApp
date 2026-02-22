USE DBAppointmentsManager;

CREATE TABLE appointments (
	id_appointment UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	title NVARCHAR(100) NOT NULL,
	description NVARCHAR(200) NOT NULL,
	due_date DATETIME2 NOT NULL,
	id_user UNIQUEIDENTIFIER NOT NULL,
	id_appointment_status INT NOT NULL DEFAULT 1,
	creation_date DateTime2 NOT NULL DEFAULT GETDATE(),

	CONSTRAINT chk_due_date CHECK (due_date > GETDATE()),
	CONSTRAINT fk_appointment_user 
		FOREIGN KEY (id_user)
		REFERENCES users(id_user),
	CONSTRAINT fk_appointment_status 
		FOREIGN KEY (id_appointment_status) 
		REFERENCES appointment_status(id_appointment_status)
);

CREATE TABLE appointment_status (
	id_appointment_status INT IDENTITY(1,1) PRIMARY KEY,
	status_name VARCHAR(50) NOT NULL
);


CREATE TABLE users (
	id_user UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	user_name NVARCHAR(100) NOT NULL,
	email_adress VARCHAR(200) NOT NULL,
	password VARCHAR(64) NOT NULL,
	creation_date DateTime2 NOT NULL DEFAULT GETDATE(),
	status BIT NOT NULL DEFAULT 1

	CONSTRAINT chk_user_status CHECK (status in (0,1)),
	CONSTRAINT chk_user_email CHECK (email_adress LIKE '%@%')
);

INSERT INTO users(id_user, user_name, email_adress, password)
	VALUES ('3F2504E0-4F89-11D3-9A0C-0305E82C3301', 'alan021', 'alan@gmail.com', 'afasfsf');

INSERT INTO appointment_status(status_name) VALUES
('Pending'),('Completed'),('Canceled');

-- test
EXEC spInsertAppointment @p_id_appointment = '3F2504E0-4F89-11D3-9A0C-0305E82C3301', @p_title = 'HSAJFASJFSLD', @p_description = 'jjflasjflsfsjafjklfdjfafj', @p_due_date = '2026-12-12';