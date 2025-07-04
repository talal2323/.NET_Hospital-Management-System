namespace HospitalManagement.Domain.Exceptions
{
    public class AppointmentValidationException : Exception
    {
        public AppointmentValidationException(string message) : base(message)
        {
        }
    }
}