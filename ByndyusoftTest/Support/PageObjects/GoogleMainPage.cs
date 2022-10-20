namespace ByndyusoftTest.Support.PageObjects
{
    public class GoogleMainPage:AbstractPage
    {
        public IWebElement TextBoxSearch => _driver.FindElement(By.XPath("//input[@title='Поиск']"));
        public IWebElement ButtonSearchInGoogle => _driver.FindElement(By.XPath("//input[@title='Поиск']"));

        public GoogleMainPage(string driver) : base(driver)
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
    }
}