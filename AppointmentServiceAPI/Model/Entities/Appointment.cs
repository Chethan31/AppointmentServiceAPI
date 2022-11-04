namespace AppointmentServiceAPI.Model.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public string ReasonForVisit { get; set; }
        public int PetIssueId { get; set; }
        public int PetId { get; set; }
        public int PetOwnerId { get; set; }
        public int DoctorId { get; set; }
        public int UserId { get; set; }
    }
}
