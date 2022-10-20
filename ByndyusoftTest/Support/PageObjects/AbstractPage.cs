namespace ByndyusoftTest.Support.PageObjects
{
    public abstract class AbstractPage
    {
        protected IWebDriver _driver;

        public AbstractPage(string driver)
        {
            _driver = Singleton.GetDriverInstance(driver);
            _driver.Manage().Window.Maximize();
        }
    }
}
