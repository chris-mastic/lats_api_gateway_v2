namespace LatsApiGateway.ViewModels
{
    public class LogoutViewModel
    {
        public string? Password { get; set; }
        public string? UserName { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
