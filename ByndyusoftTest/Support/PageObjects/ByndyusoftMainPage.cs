namespace ByndyusoftTest.Support.PageObjects
{
    public class ByndyusoftMainPage : AbstractPage
    {
        public IWebElement ButtonOrderPresentation => GetButtonOrderPresentation();
        public IWebElement LinkMailInPopUpWindow => _driver.FindElement(By.XPath("//div[@class='popup-callback__content']//a[@href='mailto:sales@byndyusoft.com']"));
        public IWebElement LinkPhoneInPopUpWindow => _driver.FindElement(By.XPath("//div[@class='popup-callback__content']//a[@href='tel:88007751521']"));
        public IWebElement PopUpWindowOrderPresentation => _driver.FindElement(By.XPath("//div[contains(@class,'popup-callback js')]"));

        public ByndyusoftMainPage() : base()
        {
        }

        public void ClickButtonOrderPresentation()
        {
            ButtonOrderPresentation.Click();
        }

        private IWebElement GetButtonOrderPresentation()
        {
            WebDriverWait webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            return webDriverWait.Until(ExpectedConditions.ElementExists(By.XPath($"//*[text()='Узнайте больше о наших продуктах']/following-sibling::*[contains(text(),'Заказать презентацию')]")));
        }
    }
}