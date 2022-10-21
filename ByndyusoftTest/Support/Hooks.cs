namespace ByndyusoftTest.Support
{
    [Binding]
    public sealed class Hooks
    {
        [AfterScenario]
        public void AfterScenario()
        {
            Singleton.CloseDriver();
        }
    }
}