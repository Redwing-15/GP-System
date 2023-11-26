namespace GP_System
{
    internal class Appointment
    {

        // Attributes
        static int count = 1;
        private string id;
        private string patient;
        private string doctor;
        private string date;
        private string time;
        private string comment;

        // Constructor(s)
        public Appointment(string Patient, string Doctor, string Date, string Time, string Comment)
        {
            id = count.ToString();
            patient = Patient;
            doctor = Doctor;
            date = Date;
            time = Time;
            comment = Comment;
            count += 1;
        }

        // Returns all doctor information as a dictionary.
        public Dictionary<string, string> GetData()
        {
            return new Dictionary<string, string>
            {
                { "id", id },
                { "patient", patient },
                { "doctor", doctor },
                { "date", date },
                { "time", time },
                { "comment", comment }
            };
        }
    }
}