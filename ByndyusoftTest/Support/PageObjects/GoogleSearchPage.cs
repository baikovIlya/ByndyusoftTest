namespace ByndyusoftTest.Support.PageObjects
{
    public class GoogleSearchPage : AbstractPage
    {
        public IWebElement FirstSearchResult => _driver.FindElements(By.XPath("//div[@class='MjjYud']//a")).FirstOrDefault();

        public GoogleSearchPage() : base()
        {
        }

        public void ClickFirstSearchResult()
        {
            FirstSearchResult.Click();
        }
    }
}