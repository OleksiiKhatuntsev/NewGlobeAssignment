namespace NewGlobeAssignment.Common.Models
{
    public class UserCredentials
    {
        #region Constructors

        public UserCredentials(string? userName, string? password)
        {
            UserName = userName;
            Password = password;
        }

        #endregion

        #region Properties

        public string? UserName { get; }

        public string? Password { get; }

        #endregion
    }
}