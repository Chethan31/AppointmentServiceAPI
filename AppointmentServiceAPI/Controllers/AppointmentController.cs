using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppointmentServiceAPI.Model.Entities;
using AppointmentServiceAPI.Model.DataAccess.AppointmentService;

namespace AppointmentServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        IAppointmentRepository Repo = new AppointmentRepository(); 

        [HttpPost]
        [Route("AddAppointment")]
        public ActionResult AddAppointment(Appointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            Repo.AddAppointment(Appointment);

            return Created("api/Appointment/GetAppointment/{id}", Appointment);
        }

        [HttpPut]
        [Route("UpdateAppointment")]
        public ActionResult UpdateAppointment(Appointment Appointment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid Input");
            Repo.UpdateAppointment(Appointment);
            return Ok();
        }

        [HttpDelete]
        [Route("RemoveAppointment/{id}")]
        public ActionResult DeleteAppointment(int id)
        {
            var res = Repo.GetAppointment(id);
            if (res == null)
                return NotFound();
            Repo.DeleteAppointment(res);
            return Ok();
        }

        [HttpGet]
        [Route("GetAppointments/User/{id}")]
        public ActionResult<List<Appointment>> GetAppointmentsByUserId(int id)
        {
            var res = Repo.GetAllAppointmentByUserId(id);
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("GetAppointments/PetOwner/{id}")]
        public ActionResult<List<Appointment>> GetAppointmentsByPetOwnerId(int id)
        {
            var res = Repo.GetAllAppointmentByOwnerId(id);
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }

        [HttpGet]
        [Route("GetAppointments/Doctor/{id}")]
        public ActionResult<List<Appointment>> GetAppointmentsByDoctorId(int id)
        {
            var res = Repo.GetAllAppointmentByDoctorId(id);
            if (res.Count == 0)
                return NotFound();
            return Ok(res);
        }


        [HttpGet]
        [Route("GetAppointment/{id}")]
        public ActionResult<Appointment> GetAppointment(int id)
        {
            var res = Repo.GetAppointment(id);
            if (res == null)
                return NotFound();
            return Ok(res);
        }
  
    }
}
