namespace Composition
{
    public class Instaler
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("We are installing the cpplication.");
        }
    }
}