namespace ProdigyProducts.BLL.Domain
{
    public interface ILogin
    {
        string Email { get; set; }
        string Password { get; set; }
        string RegistrationCode { get; set; }
        bool? Registered { get; set; }
        bool? IsAdmin { get; set; }
    }

    public class Login : ILogin
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string RegistrationCode { get; set; }
        public bool? Registered { get; set; }
        public bool? IsAdmin { get; set; }
    }
}