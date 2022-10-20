namespace ByndyusoftTest.StepDefinitions
{
    [Binding]
    public sealed class PopUpWindowOrderPresentationStepDefinitions
    {
        [Given(@"Open Google web page")]
        public void GivenOpenGoogleWebPage()
        {
            var page = new GoogleMainPage();
            page.OpenThisPage();
        }

        [When(@"Input ""([^""]*)"" in textbox search")]
        public void WhenInputInTextboxSearch(string searchText)
        {
            var page = new GoogleMainPage();
            page.InputSearchText(searchText);
        }

        [When(@"Click button Search In Google")]
        public void WhenClickButtonSearchInGoogle()
        {
            var page = new GoogleMainPage();
            page.ClickButtonSearchInGoogle();
        }

        [When(@"Click on first link")]
        public void WhenClickOnFirstLink()
        {
            var page = new GoogleSearchPage();
            page.ClickFirstSearchResult();
        }

        [When(@"Click on button OrderPresentation")]
        public void WhenClickOnButtonOrderPresentation()
        {
            var page = new ByndyusoftMainPage();
            page.ClickButtonOrderPresentation();
        }

        [Then(@"PopUp window should appear")]
        public void ThenPopUpWindowShouldAppear()
        {
            var page = new ByndyusoftMainPage();
            Assert.True(page.PopUpWindowOrderPresentation.Displayed);
        }

        [Then(@"Email in PopUp window should match ""([^""]*)""")]
        public void ThenEmailInPopUpWindowShouldMatch(string email)
        {
            var page = new ByndyusoftMainPage();
            string expectedEmail = email;
            string actualEmail = page.LinkMailInPopUpWindow.Text;
            Assert.Equal(expectedEmail, actualEmail);
        }

        [Then(@"Phone number in PopUp window should match ""([^""]*)""")]
        public void ThenPhoneNumberInPopUpWindowShouldMatch(string phone)
        {
            var page = new ByndyusoftMainPage();
            string expectedPhone = phone;
            string actualPhone = page.LinkPhoneInPopUpWindow.Text;
            Assert.Equal(expectedPhone, actualPhone);
        }
    }
}