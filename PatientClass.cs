namespace GP_System
{
    internal class Patient
    {

        // Attributes
        private string firstName;
        private string lastName;
        private string nhsNumber;
        private string email;
        private string phone;
        private string address;
        private string assignedDoctor;

        // Constructor(s)
        public Patient(string FirstName, string LastName, string NHSNumber, string Email, string Phone, string Address, string doctor)
        {
            firstName = FirstName;
            lastName = LastName;
            nhsNumber = NHSNumber;
            email = Email;
            phone = Phone;
            address = Address;
            assignedDoctor = doctor;
        }

        // Returns all patient information as a dictionary.
        public Dictionary<string, string> GetPatient()
        {
            var data = new Dictionary<string, string>
            {
                { "firstName", firstName },
                { "lastName", lastName },
                { "nhsNumber", nhsNumber },
                { "email", email },
                { "phone", phone },
                { "address", address },
                { "assignedDoctor", assignedDoctor }
            };
            return data;
        }
    }
}