using Microsoft.EntityFrameworkCore;
using AppointmentServiceAPI.Model.Data;
using AppointmentServiceAPI.Model.Entities;

namespace AppointmentServiceAPI.Model.DataAccess.AppointmentService
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private PetzeyDbContext db = new PetzeyDbContext();

        public void AddAppointment(Appointment Appointment)
        {
            db.Appointments.Add(Appointment);
            db.SaveChanges();
        }

        public void DeleteAppointment(Appointment Appointment)
        {
            db.Appointments.Remove(Appointment);
            db.SaveChanges();
        }

        public List<Appointment> GetAllAppointmentByDoctorId(int id)
        {
            return (from appointment in db.Appointments
                    where appointment.DoctorId == id
                    select appointment).ToList();
        }

        public List<Appointment> GetAllAppointmentByOwnerId(int id)
        {
            return (from appointment in db.Appointments
                    where appointment.PetOwnerId == id
                    select appointment).ToList();
        }

        public List<Appointment> GetAllAppointmentByUserId(int id)
        {
            return (from appointment in db.Appointments
                    where appointment.UserId == id
                    select appointment).ToList();
        }

        public Appointment GetAppointment(int id)
        {
            return db.Appointments.Find(id);
        }

        public void UpdateAppointment(Appointment Appointment)
        {
            db.Entry(Appointment).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
