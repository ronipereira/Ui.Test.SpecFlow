using Allure.Commons;
using TechTalk.SpecFlow;
using Ui.Test.Drivers;

namespace Ui.Test.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.CloseDriver();
        }
    }
}
