

namespace LibraryManager.Authentication
{
    public class AuthService
    {
        string username;
        string password;

        public AuthService(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool Login()
        {

            if (this.username == "test" && this.password == "test")
            {
                return true;
            }
            return false;
        }
    }
}