namespace NewGlobeAssignment.Common.Models
{
    public class UserCredentials
    {
        public string? UserName { get; }

        public string? Password { get; }

        public UserCredentials(string? userName, string? password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
