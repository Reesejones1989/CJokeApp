namespace CreateanApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string Username { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}