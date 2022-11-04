using AppointmentServiceAPI.Model.Entities;

namespace AppointmentServiceAPI.Model.DataAccess.AppointmentService
{
    public interface IAppointmentRepository
    {
        void AddAppointment(Appointment Appointment);
        Appointment GetAppointment(int id);
        List<Appointment> GetAllAppointmentByUserId(int id);
        List<Appointment> GetAllAppointmentByDoctorId(int id);
        List<Appointment> GetAllAppointmentByOwnerId(int id);
        void UpdateAppointment(Appointment Appointment);
        void DeleteAppointment(Appointment Appointment);
    }
}
