namespace ByndyusoftTest.Support.PageObjects
{
    public abstract class AbstractPage
    {
        protected IWebDriver _driver;

        public AbstractPage()
        {
            _driver = Singleton.GetDriverInstance(Options.CurrentDriverName);
            _driver.Manage().Window.Maximize();
        }

        public void SwitchToLastTab()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        }
    }
}