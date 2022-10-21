namespace ByndyusoftTest.Support.PageObjects
{
    public class GoogleMainPage:AbstractPage
    {
        private const string PageUrl = "https://www.google.ru/";
        public IWebElement TextBoxSearch => _driver.FindElement(By.XPath("//input[@title='Поиск']"));
        public IWebElement ButtonSearchInGoogle => GetButtonSearchInGoogle();

        public GoogleMainPage() : base()
        {
        }

        public void InputSearchText(string text)
        {
            TextBoxSearch.SendKeys(text);
        }

        public void ClickButtonSearchInGoogle()
        {
            ButtonSearchInGoogle.Click();
        }

        public void OpenThisPage()
        {
            _driver.Navigate().GoToUrl(PageUrl);
        }

        private IWebElement GetButtonSearchInGoogle()
        {
            WebDriverWait webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));
            return webDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='lJ9FBc']//input[@value='Поиск в Google']")));
        }
    }
}