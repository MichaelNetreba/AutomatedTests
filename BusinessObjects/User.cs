
namespace AutomatedTests.Entities
{
    public class User
    {
        public static readonly string defaultPassword = "TestP@s321";
        public static readonly string defaultName = "MN";

        private string userName;
        private string userPassword;

        public User(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
    }
}
