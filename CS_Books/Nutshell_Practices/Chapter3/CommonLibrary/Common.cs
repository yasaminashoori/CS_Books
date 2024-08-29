namespace CommonLibrary
{
    public class Customer
    {
        public Customer(string name, string email, string phone, string address, string city, string zip, string country)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _address = address;
            _city = city;
            _zip = zip;
            _country = country;
        }

        private static int _id = 1;

        public int Id
        {
            get { return _id++; }
            set { _id = value; }
        }

        private readonly string _name;
        private readonly string _email;
        private readonly string _phone; 
        private readonly string _address;
        private readonly string _city;
        private readonly string _zip;   
        private readonly string _country;
    }
}
