namespace GP_System
{
    internal class Doctor
    {

        // Attributes
        static int count = 1;
        private string id;
        private string firstName;
        private string lastName;
        private string position;
        private string email;
        private string phone;
        private string address;

        // Constructor(s)
        public Doctor(string FirstName, string LastName, string Position, string Email, string Phone, string Address)
        {
            id = count.ToString();
            firstName = FirstName;
            lastName = LastName;
            position = Position;
            email = Email;
            phone = Phone;
            address = Address;
            count += 1;
        }

        // Returns all doctor information as a dictionary.
        public Dictionary<string, string> GetData()
        {
            return new Dictionary<string, string>
            {
                { "id", id },
                { "firstName", firstName },
                { "lastName", lastName },
                { "position", position },
                { "email", email },
                { "phone", phone },
                { "address", address }
            };
        }
        public string GetName()
        {
            return $"{firstName} {lastName}";
        }
    }
}