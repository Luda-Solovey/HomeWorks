namespace ConfigurationsHomeWork2.Models
{
    public class SmtpSettingsModel
    {
        public string SmtpServer { get; set; } = string.Empty;
        public int Port { get; set; }
        public bool EnableSsl { get; set; }

        public NetworkCredentialsModel Credentials { get; set; } = new();
    }
}
