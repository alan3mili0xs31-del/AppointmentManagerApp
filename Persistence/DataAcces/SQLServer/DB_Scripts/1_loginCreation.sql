CREATE DATABASE DBAppointmentsManager;
USE DBAppointmentsManager;

CREATE LOGIN appointment_app WITH PASSWORD = 'genshin456', DEFAULT_DATABASE = DBAppointmentsManager;
USE DBAppointmentsManager;
CREATE USER appointment_app FOR LOGIN appointment_app;



