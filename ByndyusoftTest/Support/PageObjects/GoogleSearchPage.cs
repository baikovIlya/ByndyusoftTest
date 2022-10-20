namespace ByndyusoftTest.Support.PageObjects
{
    public class GoogleSearchPage : AbstractPage
    {
        public IWebElement FirstSearchResult => _driver.FindElement(By.XPath("//h1[text()='Результаты поиска']/following-sibling::div/div[1]//link"));

        public GoogleSearchPage() : base()
        {
        }

        public void ClickFirstSearchResult()
        {
            FirstSearchResult.Click();
        }
    }
}