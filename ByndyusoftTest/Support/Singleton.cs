namespace ByndyusoftTest.Support
{
    public class Singleton
    {
        private static IWebDriver _driverInstance;

        private Singleton() { }

        public static IWebDriver GetDriverInstance(string driverName)
        {

            if (_driverInstance == null)
            {
                switch (driverName)
                {
                    case "Chrome":
                        {
                            _driverInstance = new ChromeDriver();
                        }
                        break;
                    case "FireFox":
                        {
                            _driverInstance = new FirefoxDriver();
                        }
                        break;
                        default:
                        {
                            throw new ArgumentOutOfRangeException("Incorrect browser name");
                        }
                }
            }        
            return _driverInstance;
        }

        public static void CloseChromeDriver()
        {
            _driverInstance.Close();
            _driverInstance = null;
        }
    }
}