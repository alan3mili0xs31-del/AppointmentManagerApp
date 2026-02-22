GRANT EXECUTE ON dbo.spDeleteAppointmentById TO appointment_app;
GRANT EXECUTE ON dbo.spGetAppointmentById TO appointment_app;
GRANT EXECUTE ON dbo.spGetAllAppointments TO appointment_app;
GRANT EXECUTE ON dbo.spInsertAppointment TO appointment_app;
GRANT EXECUTE ON dbo.spUpdateAppointment TO appointment_app;
GRANT EXECUTE ON dbo.spGetAppointmentStatus TO appointment_app;
GRANT EXECUTE ON dbo.spGetAppointmentsByUserId TO appointment_app;
GRANT EXECUTE ON dbo.spGetUserByUserName TO appointment_app;
GRANT EXECUTE ON dbo.spGetUserById TO appointment_app;

DENY SELECT, INSERT, DELETE, UPDATE ON SCHEMA::dbo TO appointment_app;