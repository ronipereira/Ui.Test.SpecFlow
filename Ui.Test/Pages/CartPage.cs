using OpenQA.Selenium;
using Ui.Test.Drivers;

namespace Ui.Test.Pages
{
    public class CartPage : Browser
    {
        private IWebElement CartLnk => driver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement CheckoutCartBtn => driver.FindElement(By.Id("checkout"));

        public void CartClick() => CartLnk.Click();
        public void CheckoutCartClick() => CheckoutCartBtn.Click();
    }
}
