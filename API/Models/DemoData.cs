namespace API.Models
{
    public class DemoData
    {
        public Guid UUID { get; init; }

        public string Username { get; set; }
        // should probably use a DateTime but I cannot be bothered
        public int YearOfBirth { get; init; }
        // need to devise a cheeky way of hashing and comparing the passwords for future reference 
        // this is a demo of the concepts so I dont think it is a 100% necessary
        public string Password { get; set; }
        public DemoData(string _username, int _yearOfBirth, string _password)
        {
            UUID = Guid.NewGuid();
            Username = _username;
            YearOfBirth = _yearOfBirth;
            Password = _password;
        }
        public string GetUUID => UUID.ToString();
    }
}