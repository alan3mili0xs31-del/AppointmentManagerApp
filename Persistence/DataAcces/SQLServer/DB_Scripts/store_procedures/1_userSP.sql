USE DBAppointmentsManager;

GO
CREATE OR ALTER PROCEDURE spGetAppointmetsByUserId
	@p_id_user UNIQUEIDENTIFIER,
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
		id_user = @p_id_user
		AND
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
CREATE OR ALTER PROCEDURE getUserByUserName
	@p_user_name NVarChar(100)
AS
BEGIN
	SELECT 
		id_user,
		user_name,
		email_adress,
		password,
		creation_date,
		status
	FROM 
		dbo.users
	WHERE
		user_name = @p_user_name
END;

EXEC getUserByUserName @p_user_name = 'alan021';