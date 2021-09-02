using OpenQA.Selenium;
using Ui.Test.Drivers;

namespace Ui.Test.Pages
{
    public class CheckoutStepOnePage : Browser
    {
        private IWebElement FirstNameTxt => driver.FindElement(By.Id("first-name"));
        private IWebElement LastNameTxt => driver.FindElement(By.Id("last-name"));
        private IWebElement PostalCodeTxt => driver.FindElement(By.Id("postal-code"));
        private IWebElement ContinueBtn => driver.FindElement(By.Id("continue"));

        public void YourInformationSendKeys(string firstname, string lastname, string postalcode)
        {
            FirstNameTxt.SendKeys(firstname);
            LastNameTxt.SendKeys(lastname);
            PostalCodeTxt.SendKeys(postalcode);
        }

        public void ContinueBtnClick() => ContinueBtn.Click();
    }
}
