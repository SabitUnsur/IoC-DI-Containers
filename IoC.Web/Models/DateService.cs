namespace IoC.Web.Models
{
    public class DateService : ISingletonDateService, IScopeDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            _logger.LogWarning("DateService Constructoruna girdi.");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
