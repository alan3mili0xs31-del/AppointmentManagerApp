GO
CREATE OR ALTER PROCEDURE spInsertAppointment
	@p_id_appointment UNIQUEIDENTIFIER,
	@p_title NVARCHAR(100),
	@p_description NVARCHAR(200),
	@p_due_date DATETIME2,
	@p_id_user UNIQUEIDENTIFIER
AS 
BEGIN
    SET NOCOUNT ON;

	INSERT INTO dbo.appointments(id_appointment, title, description, due_date, id_user)
	VALUES (@p_id_appointment, @p_title, @p_description, @p_due_date, @p_id_user);

	SELECT @p_id_appointment;
END;

GO
CREATE OR ALTER PROCEDURE spGetAppointmentById
	@p_id_appointment UNIQUEIDENTIFIER
AS 
BEGIN
    SET NOCOUNT ON;

	SELECT
		id_appointment,
		title,
		description,
		due_date,
		id_user,
		id_appointment_status,
		creation_date
	FROM
		dbo.appointments
	WHERE
		id_appointment = @p_id_appointment
END;


GO
CREATE OR ALTER PROCEDURE spUpdateAppointment
	@p_id_appointment UNIQUEIDENTIFIER,
	@p_title NVARCHAR(100),
	@p_description NVARCHAR(200),
	@p_due_date DATETIME2,
	@p_id_appointment_status INT
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.appointments
	SET 
		title = @p_title,
		description = @p_description,
		due_date = @p_due_date,
		id_appointment_status = @p_id_appointment_status
	WHERE
		id_appointment = @p_id_appointment;
END;


GO
CREATE OR ALTER PROCEDURE spDeleteAppointmentById
	@p_id_appointment UNIQUEIDENTIFIER
AS 
BEGIN
	SET NOCOUNT ON;

	DELETE FROM
		dbo.appointments
	WHERE
		id_appointment = @p_id_appointment
END;


Exec spGetAppointmentsByUserId @p_id_user = '3F2504E0-4F89-11D3-9A0C-0305E82C3301';
-- Exec spInsertAppointment @p_id_appointment = '3F2504E0-4F89-11D3-9A0C-0305E82C3302', @p_title = 'FAJLFDSJLFKAF', @p_description = 'FALFJDSKLFJSFLKFAF', @p_due_date = '2026-3-1', @p_id_user = '3F2504E0-4F89-11D3-9A0C-0305E82C3301';

GO
CREATE OR ALTER PROCEDURE spGetAllAppointments
	@p_title NVARCHAR(100) = NULL,
    @p_id_appointment_status INT = NULL
AS 
BEGIN
	    SET NOCOUNT ON;

	SELECT
		id_appointment,
		title,
		description,
		due_date,
		id_user,
		id_appointment_status,
		creation_date
	FROM
		dbo.appointments
	WHERE
		(
			@p_id_appointment_status IS NULL
			OR id_appointment_status = @p_id_appointment_status
		)
        AND
        (
            @p_title IS NULL
            OR title LIKE '%' + @p_title + '%'
        );
END;


GO 
CREATE OR ALTER PROCEDURE spGetAppointmentStatus
AS
BEGIN
	SELECT
		id_appointment_status,
		status_name
	FROM 
		appointment_status
END;