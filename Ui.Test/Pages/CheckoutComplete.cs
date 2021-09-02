
using OpenQA.Selenium;
using Ui.Test.Drivers;

namespace Ui.Test.Pages
{
    public class CheckoutComplete : Browser
    {
        private IWebElement OrderSentMsg => driver.FindElement(By.XPath("//*[@id=\"checkout_complete_container\"]/h2"));
        public bool IsOrderSentMsgExist() => OrderSentMsg.Displayed;
        public string GetOrderSentMsg() => OrderSentMsg.Text;
    }
}
