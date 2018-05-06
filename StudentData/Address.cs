namespace StudentData
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public Address()
        {
        }
        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }
    }
}