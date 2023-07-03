namespace BackgroundServicesDemo.Models
{
    public class Configuration
    {
        public string Hostname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public bool AutomaticRecoveryEnabled { get; set; }
        public string Exchange { set; get; }
        public string RoutingKey { set; get;}
    }
}
