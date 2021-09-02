using OpenQA.Selenium;
using Ui.Test.Drivers;

namespace Ui.Test.Pages
{
    public class CheckoutStepTwoPage : Browser
    {
        private IWebElement FinishBtn => driver.FindElement(By.Id("finish"));
        public void FinishBtnClick() => FinishBtn.Click();
    }
}
