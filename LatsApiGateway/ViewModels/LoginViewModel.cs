namespace LatsApiGateway.ViewModels
{
    public class LoginViewModel
    {
        public string? Password { get; set; }
        public string? UserName { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
